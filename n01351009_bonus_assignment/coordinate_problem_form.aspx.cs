using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01351009_bonus_assignment
{
    public partial class coordinate_problem_form : System.Web.UI.Page
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
                    //Reset the previous quadrant summary with empty string
                    quadrant_summary.InnerHtml = "";

                    //Gather all information for quadrant and store in variables 
                    int X_Axis_Value = Convert.ToInt32(x_axis_value.Text);
                    int Y_Axis_Value = Convert.ToInt32(y_axis_value.Text);
                    string Quadrant = "";

                    //Check coordinates value and determine the Quadrant
                    if (X_Axis_Value == 0 && Y_Axis_Value == 0)
                    {
                        //if X and Y coordinates holds zero value - falls on origin of axis
                        Quadrant = "Origin";
                    }
                    else if (X_Axis_Value == 0 && (Y_Axis_Value > 0 || Y_Axis_Value < 0))
                    {
                        //if Y value is zero and X value is positive or negative  - falls on X axis
                        Quadrant = "y-axis";
                    }
                    else if ((X_Axis_Value > 0 || X_Axis_Value < 0) && Y_Axis_Value == 0)
                    {
                        //if Y value is zero and X value is positive or negative  - falls on X axis
                        Quadrant = "x-axis";
                    }
                    else if (X_Axis_Value > 0 && Y_Axis_Value > 0)
                    {
                        //if X and Y coordinates holds positive value - falls on I quadrant
                        Quadrant = "Quadrant I";
                    }
                    else if (X_Axis_Value < 0 && Y_Axis_Value > 0)
                    {
                        //if X coordinate negative and Y coordinate positive - falls on II quadrant
                        Quadrant = "Quadrant II";
                    }
                    else if (X_Axis_Value < 0 && Y_Axis_Value < 0)
                    {
                        //if X and Y coordinates holds negative value - falls on III quadrant
                        Quadrant = "Quadrant III";
                    }
                    else
                    {
                        //if X coordinate positive and Y coordinate negative -falls on IV quadrant
                        Quadrant = "Quadrant IV";
                    }

                    //print quadrant summary
                    quadrant_summary.InnerHtml = "A value of (" + X_Axis_Value + "," + Y_Axis_Value + ") fall on <b>" + Quadrant + "</b>";
                }

            }

        }
        
        //server validation function on Axis value - type="number" is not supported in IE
        protected void Validate_Axis_Value(object sender, ServerValidateEventArgs e)
        {
            bool Axis_Value_IsInteger = Int32.TryParse(e.Value, out int Axis_Value);
       
            if (!Axis_Value_IsInteger)
            {
                e.IsValid = false;
            }
            
        }
    }

}