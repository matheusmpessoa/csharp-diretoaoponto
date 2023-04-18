using System;
namespace CsharpDiretoAoPonto
{
	public class DateTime
	{
		public DateTime()
		{
			var now = DateTime.Now;
			var today = DateTime.Today;

            var threeDaysAgo = now.AddDays(-3);
			var sixMonthsLater = today.AddMonths(6);
			var twoYearsLater = today.AddYerars(-2);

			var shortDate = now.ToShortDateString();
			var longDate = now.ToLongDateString();

			var shortTime = now.ToShortTimeString();
			var longTime = now.ToLongTimeString();

			var date = now.Date;
			var day = now.Day;
			var month = now.Month;
			var year = now.Year;
			var hour = now.Hour;
			var minute = now.Minute;
			var second = now.Second;

			var dayOfWeek = now.DayOfWeek;

			if(dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
			{
				Console.WriteLine("É fim de semana!");
			}

			var dayOfYear = now.DateOfYear;

            Console.ReadKey();
        }
	}
}

