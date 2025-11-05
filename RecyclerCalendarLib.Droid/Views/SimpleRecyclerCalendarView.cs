using Android.Content;
using Android.Util;
using AndroidX.RecyclerView.Widget;
using Com.Polyariz.RecyclerCalendar.Adapter;
using Com.Polyariz.RecyclerCalendar.Model;

namespace Com.Polyariz.RecyclerCalendar.Views
{
    public class SimpleRecyclerCalendarView : RecyclerView
    {
        private SimpleRecyclerCalendarConfiguration _configuration = null!;

        public SimpleRecyclerCalendarView(Context context) : base(context)
        {
        }

        public SimpleRecyclerCalendarView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public SimpleRecyclerCalendarView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public void Initialise(
            DateTime startDate,
            DateTime endDate,
            SimpleRecyclerCalendarConfiguration configuration,
            SimpleRecyclerCalendarAdapter.IOnDateSelected dateSelectListener)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            var simpleRecyclerCalendarAdapter = new SimpleRecyclerCalendarAdapter(
                startDate,
                endDate,
                configuration,
                dateSelectListener ?? throw new ArgumentNullException(nameof(dateSelectListener))
            );

            SetAdapter(simpleRecyclerCalendarAdapter);
        }

        public SimpleRecyclerCalendarConfiguration GetConfiguration() => _configuration;
    }
}