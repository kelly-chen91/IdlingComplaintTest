using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace IdlingComplaintTest.Pages.CreateAnAccount
{
    internal class CreateAnAccountModel : PageSetup
    {
        public CreateAnAccountModel(IWebDriver driver) : base(driver) { }

        private IWebElement FirstName => driver.FindElement(By.CssSelector("input[formcontrolname = 'firstname']"));                            //First Name
        private IWebElement LastName => driver.FindElement(By.CssSelector("input[formcontrolname = 'lastname']"));                              //Last Name
        private IWebElement Email => driver.FindElement(By.CssSelector("input[formcontrolname = 'emailaddress1']"));                            //Email
        private IWebElement Password => driver.FindElement(By.CssSelector("input[formcontrolname = 'idc_password']"));                          //Password
        private IWebElement ConfirmPassword => driver.FindElement(By.CssSelector("input[formcontrolname = 'confirmPassword']"));                 //Confirm Password
        private IWebElement SecurityQuestion => driver.FindElement(By.CssSelector("mat-select[formcontrolname = '_idc_securityquestion_value']"));    //Security Question                                                                                                     
        private IWebElement SecurityAnswer => driver.FindElement(By.CssSelector("input[formcontrolname = 'idc_securityanswer']"));              //Security Answer
        private IWebElement Address1 => driver.FindElement(By.CssSelector("input[formcontrolname = 'address1_line1']"));                        //Address1
        private IWebElement Address2 => driver.FindElement(By.CssSelector("input[formcontrolname = 'address1_line2']"));                        //Address2
        private IWebElement City => driver.FindElement(By.CssSelector("input[formcontrolname = 'address1_city']"));                             //City
        private IWebElement State => driver.FindElement(By.CssSelector("mat-select[formcontrolname = 'address1_stateorprovince']"));                 //State                                                                                                 
        private IWebElement ZipCode => driver.FindElement(By.CssSelector("input[formcontrolname = 'address1_postalcode']"));                    //Zip Code
        private IWebElement Telephone => driver.FindElement(By.CssSelector("input[formcontrolname = 'address1_telephone1']"));                  //Telephone
        private IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[color = 'primary']"));                                    //Submit Button
        private IWebElement CancelButton => driver.FindElement(By.CssSelector("button[type = 'reset']"));                                       //Cancel Button

        private string selectedSecurityQuestion = "--";
        private string selectedState = "--";

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
            List<IWebElement> optionElementList = new List<IWebElement>
            {
                driver.FindElement(By.XPath("//*[@id=\"mat-option-1\"]/span")), //Default Option
                driver.FindElement(By.XPath("//*[@id=\"mat-option-53\"]/span")),
                driver.FindElement(By.XPath("//*[@id=\"mat-option-54\"]/span")),
                driver.FindElement(By.XPath("//*[@id=\"mat-option-55\"]/span")),
                driver.FindElement(By.XPath("//*[@id=\"mat-option-56\"]/span")),
                driver.FindElement(By.XPath("//*[@id=\"mat-option-57\"]/span"))
            };

            List<string> questionList = ConvertOptionToText(optionElementList);
            if (questionIndex >= questionList.Count || questionIndex < 0) return;
            optionElementList[questionIndex].Click();
            UpdateOption(questionList[questionIndex], true);
            Thread.Sleep(5000);
        }

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
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-0\"]/span"))); //Default Option
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-2\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-3\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-4\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-5\"]/span")));
            optionElementList.Add(driver.FindElement(By.XPath("//*[@id=\"mat-option-6\"]/span")));

            List<string> stateList = ConvertOptionToText(optionElementList);
            if (stateIndex >= stateList.Count || stateIndex < 0) return;
            optionElementList[stateIndex].Click();
            UpdateOption(stateList[stateIndex], false);
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
        public IWebElement GetCancelButton() { return CancelButton;}

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

        public List<string> ConvertOptionToText(List<IWebElement> elements)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < elements.Count; i++)
            {
                list.Add(elements[i].Text);
            }
            return list;
        }

    }
}
