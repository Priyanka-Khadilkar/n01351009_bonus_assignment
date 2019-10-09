using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01351009_bonus_assignment
{
    public partial class Raffle_Bundle_form : System.Web.UI.Page
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
                    //Gather number of ticket and store in variable.
                    int Number_Of_Tickets = Convert.ToInt32(number_of_tickets.Text);

                    //Reset the previous raffle bundle summary with empty string
                    raffle_bundle_summary.InnerHtml = "";

                    //According to given Problem build conditions for bundling
                    if (Number_Of_Tickets <= 50)
                    {
                        //If number of tickets under or equal 50, it should be bundled individually
                        PrintRaffleBundleOutput(Number_Of_Tickets, 1);
                    }
                    else if (Number_Of_Tickets >= 51 && Number_Of_Tickets <= 150)
                    {
                        //If number of tickets in between 51(including) and 150(including) , it should be bundled in set of two
                        PrintRaffleBundleOutput(Number_Of_Tickets, 2);
                    }
                    else if (Number_Of_Tickets >= 151 && Number_Of_Tickets <= 300)
                    {
                        //If number of tickets in between 151(including) and 300(including) , it should be bundled in set of three
                        PrintRaffleBundleOutput(Number_Of_Tickets, 3);
                    }
                    else
                    {
                        //If number of tickets more than 300 , it should be bundled in set of five
                        PrintRaffleBundleOutput(Number_Of_Tickets, 5);
                    }
                }

            }
        }

        /// <summary>
        /// Function for Print output according to number of Bundle
        /// </summary>
        /// <param name="Number_of_Tickets">Number of tickets</param>
        /// <param name="Number_of_Bundle">Number of bundle</param>
        public void PrintRaffleBundleOutput(int Number_of_Tickets, int Number_of_Bundle)
        {
            for (int i = Number_of_Bundle; i <= Number_of_Tickets + Number_of_Bundle; i = i + Number_of_Bundle)
            {
                if (i <= Number_of_Tickets)
                {
                    raffle_bundle_summary.InnerHtml += "You received a bundle of " + Number_of_Bundle + " ! That’s " + i + " ticket(s)!<br/>";
                }
                else
                {
                    var Last_Ticket_Bundle = Number_of_Tickets - (i - Number_of_Bundle);
                    if (Last_Ticket_Bundle > 0)
                    {
                        raffle_bundle_summary.InnerHtml += "You received a bundle of " + Last_Ticket_Bundle + " ! That’s " + Number_of_Tickets + " ticket(s)!<br/>";
                    }
                }
            }

            //Calculate the cost of tickets 
            double Ticket_Cost = System.Math.Round(Number_of_Tickets * 0.25, 2);
            raffle_bundle_summary.InnerHtml += "<br/>Your total ticket(s) is " + Number_of_Tickets + " and your cost is $" + Ticket_Cost.ToString("0.00") + "cad!";

        }

        /// <summary>
        /// Validate the Number of ticket input and check if it's number or not as for IE browser type=number is not working
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Number_Of_Tickets_Validate(object sender, ServerValidateEventArgs e)
        {
            bool Number_Of_Tickets_IsInteger = Int32.TryParse(e.Value, out int Number_Of_Tickets);

            if (!Number_Of_Tickets_IsInteger)
            {
                e.IsValid = false;
            }
            else if(Number_Of_Tickets <=0)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }

        }
    }
}