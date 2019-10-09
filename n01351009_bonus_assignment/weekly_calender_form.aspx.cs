using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01351009_bonus_assignment
{
    public partial class weekly_calender_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.IsPostBack checks whether the page is being rendered for the first time or is being loaded in response to a postback
            if (Page.IsPostBack)
            {
                //Validate page on the server side again.
                Page.Validate();

                //If page is valid then we can proceed further.
                if (Page.IsValid)
                {
                    //List for storing selected schedule days.
                    List<int> Weekly_Schedule_Days = new List<int>();

                    //Reset the previous weekly calender summary with empty string
                    weekly_calender_summary.InnerHtml = "";

                    //Gather all selected schedule days from checkbox list and save into  a list.
                    foreach (ListItem day in weekly_schedule_days.Items)
                    {
                        if (day.Selected == true)
                        {
                            Weekly_Schedule_Days.Add(Convert.ToInt32(day.Value));
                        }
                    }

                    //Check schedule days for october month. 
                    for (int i = 0; i < 31; i++)
                    {
                        //Store reminder for every date of october mont.Variable value will be updated according to date
                        int Reminder = (i + 1) % 7;

                        //Get day name according to date and store into Week_day variable.
                        string Week_Day = Enum.GetName(typeof(WeekDays), Reminder);

                        //check if reminder matches with selected weekly days value, if it matches then it'll be working day else it'll be sun day
                        if (Weekly_Schedule_Days.Contains(Reminder))
                        {
                            //working day of month
                            weekly_calender_summary.InnerHtml += "Oct " + (i + 1) + " is a " + Week_Day + "! Time to work..<br/>";
                        }
                        else
                        {
                            //fun day of month
                            weekly_calender_summary.InnerHtml += "Oct " + (i + 1) + " is a " + Week_Day + "! Time to fun..<br/>";
                        }
                    }
                }

            }

        }

        /// <summary>
        /// Enum for holding constant values for days and compare values with checkbox value for output.
        /// </summary>
        enum WeekDays { Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday = 5, Sunday = 6, Monday = 0 };
    }
}