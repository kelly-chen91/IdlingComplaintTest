using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace IdlingComplaintTest.Pages.CreateAnAccount
{
    internal class CreateAnAccountModel : PageSetup
    {
        public CreateAnAccountModel(IWebDriver driver) : base(driver) { }

        private IWebElement FirstName => driver.FindElement(By.Id("mat-input-0"));                              //First Name
        private IWebElement LastName => driver.FindElement(By.Id("mat-input-1"));                               //Last Name
        private IWebElement Email => driver.FindElement(By.Id("mat-input-2"));                                  //Email
        private IWebElement Password => driver.FindElement(By.Id("mat-input-8"));                               //Password
        private IWebElement ConfirmPassword => driver.FindElement(By.Id("mat-input-9"));                        //Confirm Password
        private IWebElement SecurityQuestion => driver.FindElement(By.Id("mat-select-1"));                      //Security Question                                                                                                     
        private IWebElement SecurityAnswer => driver.FindElement(By.Id("mat-input-10"));                        //Security Answer
        private IWebElement Address1 => driver.FindElement(By.Id("mat-input-3"));                               //Address1
        private IWebElement Address2 => driver.FindElement(By.Id("mat-input-4"));                               //Address2
        private IWebElement City => driver.FindElement(By.Id("mat-input-5"));                                   //City
        private IWebElement State => driver.FindElement(By.Id("mat-select-0"));                                 //State                                                                                                 
        private IWebElement ZipCode => driver.FindElement(By.Id("mat-input-6"));                                //Zip Code
        private IWebElement Telephone => driver.FindElement(By.Id("mat-input-7"));                              //Telephone
        private IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[color = 'primary']"));    //Submit Button
        private IWebElement CancelButton => driver.FindElement(By.CssSelector("button[type = 'reset']"));       //Cancel Button
        private string selectedSecurityQuestion = "--";
        private string selectedState = "--";


        /*SelectElement*/
        //private SelectElement securityDropDown;
        //private SelectElement stateOptions;

        /* Mutator Methods for the Form Fields */
        public void EnterFirstName(string firstName)
        {
            FirstName.SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            LastName.SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void EnterConfirmPassword(string confirmPassword)
        {
            ConfirmPassword.SendKeys(confirmPassword);
        }

        
        public void SelectSecurityQuestion(int questionIndex) 
        {
            SecurityQuestion.Click();
            List<IWebElement> optionElementList = new List<IWebElement>();
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-53\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-54\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-55\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-56\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-57\"]/span")));

            List<string> questionList = new List<string>();
            questionList.Add(ExtractTextFromXPath("//*[@id=\"mat-option-53\"]/span/text()"));
            questionList.Add(ExtractTextFromXPath("//*[@id=\"mat-option-54\"]/span/text()"));
            questionList.Add(ExtractTextFromXPath("//*[@id=\"mat-option-55\"]/span/text()"));
            questionList.Add(ExtractTextFromXPath("//*[@id=\"mat-option-56\"]/span/text()"));
            questionList.Add(ExtractTextFromXPath("//*[@id=\"mat-option-57\"]/span/text()"));
            if (questionIndex >= questionList.Count || questionIndex < 0)
            {
                return; 
            }
            optionElementList[questionIndex].Click();
            UpdateOption(questionList[questionIndex], true);
            //GetDriver().find
            Thread.Sleep(5000);
        }

        //public void SelectSecurityQuestion1(SelectElement dropDown)
        //{
        //    dropDown = new SelectElement(SecurityQuestion);
        //    dropDown.SelectByValue(securityQuestion);
        //}

        public void EnterSecurityAnswer(string answer)
        {
            SecurityAnswer.SendKeys(answer);
        }

        public void EnterAddress1(string address1) 
        {
            Address1.SendKeys(address1);
        }

        public void EnterAddress2(string address2) 
        {
            Address2.SendKeys(address2);
        }

        public void EnterCity(string city) 
        { 
            City.SendKeys(city);
        }

        public void SelectState(int stateIndex)
        {
            State.Click();
            List<IWebElement> optionElementList = new List<IWebElement>();
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-2\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-3\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-4\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-5\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-6\"]/span")));

            List<string> stateList = new List<string>();
            stateList.Add(optionElementList[0].Text);
            stateList.Add(optionElementList[1].Text);
            stateList.Add(optionElementList[2].Text);
            stateList.Add(optionElementList[3].Text);
            stateList.Add(optionElementList[4].Text);
            if (stateIndex >= stateList.Count || stateIndex < 0)
            {
                return;
            }
            optionElementList[stateIndex].Click();
            UpdateOption(stateList[stateIndex], false);
            //GetDriver().find
            Thread.Sleep(5000);
        }
        public void EnterZipCode(string zipCode) 
        { 
            ZipCode.SendKeys(zipCode);
        }

        public void EnterPhone(string phone)
        {
            Telephone.SendKeys(phone);
        }

        /*Get Attributes*/

        public string GetFirstNameValue()
        {
            return FirstName.GetAttribute("value");
        }
        public string GetLastNameValue()
        {
            return LastName.GetAttribute("value");
        }

        public string GetEmailValue()
        {
            return Email.GetAttribute("value");
        }

        public string GetPasswordValue()
        {
            return Password.GetAttribute("value");
        }

        public string GetConfirmPasswordValue()
        {
            return ConfirmPassword.GetAttribute("value");
        }


        public string SelectSecurityQuestionValue() 
        {
            return selectedSecurityQuestion;
        }

        public string GetSecurityAnswerValue()
        {
            return SecurityAnswer.GetAttribute("value");
        }

        public string GetAddress1Value()
        {
            return Address1.GetAttribute("value");
        }

        public string GetAddress2Value()
        {
            return Address2.GetAttribute("value");
        }

        public string GetCityValue()
        {
            return City.GetAttribute("value");
        }

        public string GetStateValue()
        {
            return selectedState;
        }
        public string GetZipCodeValue()
        {
            return ZipCode.GetAttribute("value");
        }

        public string GetPhoneValue()
        {
            return Telephone.GetAttribute("value");
        }

        /*Buttons*/
        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }

        public void ClickCancelButton()
        {
            CancelButton.Click();
        }

        public void ScrollToButton()
        {
            ScrollToElement(SubmitButton);
        }

        public IWebElement GetFirstName() { return FirstName; }
        public IWebElement GetLastName() {  return LastName; }
        public IWebElement GetEmail() { return Email; }
        public IWebElement GetPassword() { return Password;}
        public IWebElement GetConfirmPassword() { return ConfirmPassword;}
        public IWebElement GetSecurityQuestion() { return  SecurityQuestion;}
        public IWebElement GetSecurityAnswer() {  return SecurityAnswer;}
        public IWebElement GetAddress1() { return Address1; }
        public IWebElement GetAddress2() { return Address2; }
        public IWebElement GetCity() { return City;}
        public IWebElement GetState() { return State;}
        public IWebElement GetZipCode() { return ZipCode;}
        public IWebElement GetTelephone() { return  Telephone;}

        /* The following methods checking for validation of the fields: Email, Phone #, ZipCode, password */
        public Boolean IsValidEmail(string email)
        {
            var regexPattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(regexPattern);
            return regex.IsMatch(email);
        }
        
        public String FormatPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"[^\d]");
            phone = regex.Replace(phone.Trim(), "");
            phone = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            return phone;
        }
        public Boolean IsValidPhoneNumber(string phoneNumber)
        {
            Console.WriteLine("original: " + phoneNumber);
            phoneNumber = FormatPhoneNumber(phoneNumber);
            Console.WriteLine("new: " + phoneNumber);
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return false;
            }
            string validPhoneRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            return Regex.IsMatch(phoneNumber, validPhoneRegex);
        }

        public void UpdateOption(string elementText, Boolean isSecurityQuestion)
        {
            if (isSecurityQuestion) this.selectedSecurityQuestion = elementText;
            else this.selectedState = elementText;
        }

    }
}
