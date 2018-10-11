using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateMe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validationResult = false;
            List<ValidDataCheck> validDataChecks = new List<ValidDataCheck>();
            string userPrompt = "";

            #region Set up valid data headers and add them to List object
            ValidDataCheck nameCheck = new ValidDataCheck(StringTable.NamePrompt, InformationType.Name, StringTable.ValidNameMessage, StringTable.InvalidNameMessage);
            ValidDataCheck emailCheck = new ValidDataCheck(StringTable.EmailPrompt, InformationType.EmailAddress, StringTable.ValidEmailMessage, StringTable.InvalidEmailMessage);
            ValidDataCheck phoneNumberCheck = new ValidDataCheck(StringTable.TelephoneNumberPrompt, InformationType.TelephoneNumber, StringTable.ValidTelephoneNumberMessage, StringTable.InvalidTelephoneNumberMessage);
            ValidDataCheck dateCheck = new ValidDataCheck(StringTable.DatePrompt, InformationType.Date, StringTable.ValidDateMessage, StringTable.InvalidDateMessage);

            validDataChecks.Add(nameCheck);
            validDataChecks.Add(emailCheck);
            validDataChecks.Add(phoneNumberCheck);
            validDataChecks.Add(dateCheck);
            #endregion

            Console.Write("***********************************************************\n" +
                          "*             Dev.Build(2.0) - Input Validation           *\n" +
                          "***********************************************************\n\n");

            while (true)
            {
                foreach (ValidDataCheck c in validDataChecks)
                {
                    PromptReentry:
                    Console.Write("\n" + c.DataTypePrompt);   //Prompt the user for data to be validated
                    validationResult = Validation.ValidateInfo(c.informationType, Console.ReadLine()); //have Validation class let us know if the data fits our format
                    Console.WriteLine(validationResult == true ? c.validDataMessage : c.invalidDataMessage); //let the user know about Data Validation's findings
                    if (!validationResult)
                    {
                        while (userPrompt != "y" && userPrompt != "n")      //if data is invalid, ask if the user would like to re-enter data
                        {
                            Console.Write(StringTable.ReEnterDataPrompt);
                            userPrompt = Console.ReadLine().ToLower();
                        }
                        if (userPrompt == "y") { userPrompt = ""; goto PromptReentry; }
                        else if (userPrompt == "n") { userPrompt = ""; continue; }
                    }
                }

                while (userPrompt != "y" && userPrompt != "n")
                {
                    Console.Write(StringTable.RestartPrompt);
                    userPrompt = Console.ReadLine().ToLower();
                }
                if (userPrompt == "y") { userPrompt = ""; continue; }
                else if (userPrompt == "n") { userPrompt = ""; return; }
            }


        }
    }
}
