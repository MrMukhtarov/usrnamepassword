using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass
{

    class User
    {
        private string _userName;
        private string _password;
        
        

        
        
 
       public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length >= 8)
                {
                    _userName = UserName;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil et");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length >= 8)
                {
                    
                    _password = Password;
                    foreach (char item in _password)
                    {
                        if (char.IsUpper(item))
                        {
                            
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Yeniden daxil edin");
                }
            }
        }

            public User(string Username, string Password)
            {
              _userName = Username;
              
            }
            public User(string Password)
            {
                _password = Password;
            }
        
    }
}
