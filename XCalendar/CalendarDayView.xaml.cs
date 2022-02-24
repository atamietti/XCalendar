﻿using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XCalendar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarDayView : FramedLabel
    {
        #region Properties

        #region Bindable Properties
        public DateTime DateTime
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }
        public bool IsCurrentMonth
        {
            get { return (bool)GetValue(IsCurrentMonthProperty); }
            set { SetValue(IsCurrentMonthProperty, value); }
        }
        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
        public bool IsOutOfRange
        {
            get { return (bool)GetValue(IsOutOfRangeProperty); }
            set { SetValue(IsOutOfRangeProperty, value); }
        }
        public bool IsToday
        {
            get { return (bool)GetValue(IsTodayProperty); }
            set { SetValue(IsTodayProperty, value); }
        }
        public CalendarView CalendarView
        {
            get { return (CalendarView)GetValue(CalendarViewProperty); }
            set { SetValue(CalendarViewProperty, value); }
        }
        public Color CurrentMonthTextColor
        {
            get { return (Color)GetValue(CurrentMonthTextColorProperty); }
            set { SetValue(CurrentMonthTextColorProperty, value); }
        }
        public Color CurrentMonthBackgroundColor
        {
            get { return (Color)GetValue(CurrentMonthBackgroundColorProperty); }
            set { SetValue(CurrentMonthBackgroundColorProperty, value); }
        }
        public Color CurrentMonthBorderColor
        {
            get { return (Color)GetValue(CurrentMonthBorderColorProperty); }
            set { SetValue(CurrentMonthBorderColorProperty, value); }
        }
        public Color TodayTextColor
        {
            get { return (Color)GetValue(TodayTextColorProperty); }
            set { SetValue(TodayTextColorProperty, value); }
        }
        public Color TodayBackgroundColor
        {
            get { return (Color)GetValue(TodayBackgroundColorProperty); }
            set { SetValue(TodayBackgroundColorProperty, value); }
        }
        public Color TodayBorderColor
        {
            get { return (Color)GetValue(TodayBorderColorProperty); }
            set { SetValue(TodayBorderColorProperty, value); }
        }
        public Color OtherMonthTextColor
        {
            get { return (Color)GetValue(OtherMonthTextColorProperty); }
            set { SetValue(OtherMonthTextColorProperty, value); }
        }
        public Color OtherMonthBackgroundColor
        {
            get { return (Color)GetValue(OtherMonthBackgroundColorProperty); }
            set { SetValue(OtherMonthBackgroundColorProperty, value); }
        }
        public Color OtherMonthBorderColor
        {
            get { return (Color)GetValue(OtherMonthBorderColorProperty); }
            set { SetValue(OtherMonthBorderColorProperty, value); }
        }
        public Color OutOfRangeTextColor
        {
            get { return (Color)GetValue(OutOfRangeTextColorProperty); }
            set { SetValue(OutOfRangeTextColorProperty, value); }
        }
        public Color OutOfRangeBackgroundColor
        {
            get { return (Color)GetValue(OutOfRangeBackgroundColorProperty); }
            set { SetValue(OutOfRangeBackgroundColorProperty, value); }
        }
        public Color OutOfRangeBorderColor
        {
            get { return (Color)GetValue(OutOfRangeBorderColorProperty); }
            set { SetValue(OutOfRangeBorderColorProperty, value); }
        }
        public Color SelectedTextColor
        {
            get { return (Color)GetValue(SelectedTextColorProperty); }
            set { SetValue(SelectedTextColorProperty, value); }
        }
        public Color SelectedBackgroundColor
        {
            get { return (Color)GetValue(SelectedBackgroundColorProperty); }
            set { SetValue(SelectedBackgroundColorProperty, value); }
        }
        public Color SelectedBorderColor
        {
            get { return (Color)GetValue(SelectedBorderColorProperty); }
            set { SetValue(SelectedBorderColorProperty, value); }
        }
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }
        #endregion

        #region Bindable Properties Initialisers
        public static readonly BindableProperty CalendarViewProperty = BindableProperty.Create(nameof(CalendarView), typeof(CalendarView), typeof(CalendarDayView), propertyChanged: CalendarViewPropertyChanged);
        public static readonly BindableProperty DateTimeProperty = BindableProperty.Create(nameof(DateTime), typeof(DateTime), typeof(CalendarDayView), DateTime.Today);
        public static readonly BindableProperty IsCurrentMonthProperty = BindableProperty.Create(nameof(IsCurrentMonth), typeof(bool), typeof(CalendarDayView));
        public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(nameof(IsSelected), typeof(bool), typeof(CalendarDayView));
        public static readonly BindableProperty IsOutOfRangeProperty = BindableProperty.Create(nameof(IsOutOfRange), typeof(bool), typeof(CalendarDayView));
        public static readonly BindableProperty IsTodayProperty = BindableProperty.Create(nameof(IsToday), typeof(bool), typeof(CalendarDayView));
        public static readonly BindableProperty CurrentMonthTextColorProperty = BindableProperty.Create(nameof(CurrentMonthTextColor), typeof(Color), typeof(CalendarDayView), Color.Black);
        public static readonly BindableProperty CurrentMonthBackgroundColorProperty = BindableProperty.Create(nameof(CurrentMonthBackgroundColor), typeof(Color), typeof(CalendarDayView), Color.Transparent);
        public static readonly BindableProperty CurrentMonthBorderColorProperty = BindableProperty.Create(nameof(CurrentMonthBorderColor), typeof(Color), typeof(CalendarDayView), BorderColorProperty.DefaultValue);
        public static readonly BindableProperty TodayTextColorProperty = BindableProperty.Create(nameof(TodayTextColor), typeof(Color), typeof(CalendarDayView), Color.Black);
        public static readonly BindableProperty TodayBackgroundColorProperty = BindableProperty.Create(nameof(TodayBackgroundColor), typeof(Color), typeof(CalendarDayView), Color.Transparent);
        public static readonly BindableProperty TodayBorderColorProperty = BindableProperty.Create(nameof(TodayBorderColor), typeof(Color), typeof(CalendarDayView), Color.FromHex("#E00000"));
        public static readonly BindableProperty OtherMonthTextColorProperty = BindableProperty.Create(nameof(OtherMonthTextColor), typeof(Color), typeof(CalendarDayView), Color.FromHex("#A0A0A0"));
        public static readonly BindableProperty OtherMonthBackgroundColorProperty = BindableProperty.Create(nameof(OtherMonthBackgroundColor), typeof(Color), typeof(CalendarDayView), Color.Transparent);
        public static readonly BindableProperty OtherMonthBorderColorProperty = BindableProperty.Create(nameof(OtherMonthBorderColor), typeof(Color), typeof(CalendarDayView), BorderColorProperty.DefaultValue);
        public static readonly BindableProperty OutOfRangeTextColorProperty = BindableProperty.Create(nameof(OutOfRangeTextColor), typeof(Color), typeof(CalendarDayView), Color.FromHex("#FFA0A0"));
        public static readonly BindableProperty OutOfRangeBackgroundColorProperty = BindableProperty.Create(nameof(OutOfRangeBackgroundColor), typeof(Color), typeof(CalendarDayView), Color.Transparent);
        public static readonly BindableProperty OutOfRangeBorderColorProperty = BindableProperty.Create(nameof(OutOfRangeBorderColor), typeof(Color), typeof(CalendarDayView), BorderColorProperty.DefaultValue);
        public static readonly BindableProperty SelectedTextColorProperty = BindableProperty.Create(nameof(SelectedTextColor), typeof(Color), typeof(CalendarDayView), Color.White);
        public static readonly BindableProperty SelectedBackgroundColorProperty = BindableProperty.Create(nameof(SelectedBackgroundColor), typeof(Color), typeof(CalendarDayView), Color.FromHex("#E00000"));
        public static readonly BindableProperty SelectedBorderColorProperty = BindableProperty.Create(nameof(SelectedBorderColor), typeof(Color), typeof(CalendarDayView), BorderColorProperty.DefaultValue);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CalendarDayView));
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(CalendarDayView));
        #endregion

        #endregion

        #region Commands
        protected ICommand UpdateCalendarViewDateSelectionCommand { get; set; }
        #endregion

        #region Constructors
        public CalendarDayView()
        {
            UpdateCalendarViewDateSelectionCommand = new Command<DateTime>(UpdateCalendarViewDateSelection);
            Command = UpdateCalendarViewDateSelectionCommand;
            SetBinding(CommandParameterProperty, new Binding("DateTime", source: this));

            InitializeComponent();
        }
        #endregion

        #region Methods
        protected void UpdateCalendarViewDateSelection(DateTime DateTime)
        {
            CalendarView?.ChangeDateSelection(DateTime);
        }
        private void CalendarView_MonthViewDaysInvalidated(object sender, EventArgs e)
        {
            UpdateProperties();
            UpdateView();
        }
        public virtual void UpdateProperties()
        {
            IsCurrentMonth = IsDateTimeCurrentMonth(DateTime);
            IsOutOfRange = IsDateTimeOutOfRange(DateTime);
            IsSelected = IsDateTimeSelected(DateTime);
            IsToday = IsDateTimeToday(DateTime);
        }
        public virtual void UpdateView()
        {
            bool IsOtherMonth = !IsCurrentMonth;

            if (IsOutOfRange)
            {
                BackgroundColor = OutOfRangeBackgroundColor;
                BorderColor = OutOfRangeBorderColor;
                TextColor = OutOfRangeTextColor;
            }
            else if (IsSelected && IsCurrentMonth)
            {
                BackgroundColor = SelectedBackgroundColor;
                BorderColor = SelectedBorderColor;
                TextColor = SelectedTextColor;
            }
            else if (IsToday && IsCurrentMonth)
            {
                BackgroundColor = TodayBackgroundColor;
                BorderColor = TodayBorderColor;
                TextColor = TodayTextColor;
            }
            else if (IsOtherMonth)
            {
                BackgroundColor = OtherMonthBackgroundColor;
                BorderColor = OtherMonthBorderColor;
                TextColor = OtherMonthTextColor;
            }
            else if (IsCurrentMonth)
            {
                BackgroundColor = CurrentMonthBackgroundColor;
                BorderColor = CurrentMonthBorderColor;
                TextColor = CurrentMonthTextColor;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public virtual bool IsDateTimeCurrentMonth(DateTime DateTime)
        {
            return DateTime.Month == CalendarView?.NavigatedDate.Month && DateTime.Year == CalendarView?.NavigatedDate.Year;
        }
        public virtual bool IsDateTimeOutOfRange(DateTime DateTime)
        {
            return DateTime.Date < CalendarView?.DayRangeMinimumDate.Date || DateTime.Date > CalendarView?.DayRangeMaximumDate.Date;
        }
        public virtual bool IsDateTimeToday(DateTime DateTime)
        {
            return DateTime.Date == CalendarView?.TodayDate.Date;
        }
        public virtual bool IsDateTimeSelected(DateTime DateTime)
        {
            return CalendarView?.SelectedDates.Any(x => x.Date == DateTime.Date) == true;
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            UpdateProperties();
            UpdateView();
        }

        #region Bindable Properties Methods
        private static void CalendarViewPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            CalendarDayView Control = (CalendarDayView)bindable;
            CalendarView OldCalendarView = (CalendarView)oldValue;
            CalendarView NewCalendarView = (CalendarView)newValue;

            if (OldCalendarView != null) { OldCalendarView.MonthViewDaysInvalidated -= Control.CalendarView_MonthViewDaysInvalidated; }
            if (NewCalendarView != null) { NewCalendarView.MonthViewDaysInvalidated += Control.CalendarView_MonthViewDaysInvalidated; }

            Control.UpdateProperties();
            Control.UpdateView();
        }
        #endregion

        #endregion
    }
}