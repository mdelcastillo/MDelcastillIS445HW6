using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Task2()
        {
            return View();
        }


        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber))
          {
            return Content("invalid input, please try again");
          }
          else if (inputNumber.Length != 10)
          {
              return Content("Please enter 10 digit number");
          }
          else
          {
            string formatted = formatNumber(inputNumber);
            return View((object)formatted);
          }
        }

        public ActionResult ReverseText(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return Content("invalid input, please try again");
            }
            else
            {
                string reverseT = Reverse(inputText);
                return View((object)reverseT);
            }
        }



        private string formatNumber(string inputNumber)
        {
            char[] cArray = inputNumber.ToCharArray();
            string AreaCode = "(" + inputNumber.Substring(0, 3) + ")";
            string Prefix = " " + inputNumber.Substring(3,3) + "-";
            string LineNumber = inputNumber.Substring(6,4);

            string formatted = AreaCode+Prefix+LineNumber;

          return formatted;
        }

        private string Reverse(string inputText)
        {

            string reverse = String.Empty;



            string[] strArr = inputText.Split(' ');

            for (int i = strArr.Count() - 1; i> -1;i--)
            {
                reverse = reverse + strArr[i]+" ";
            }
            

            return reverse;
        }

    }
}
