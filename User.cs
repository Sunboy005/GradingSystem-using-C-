namespace GradingSystem
{
    public class User
    {
        public User()
        {

        }
        public User(int userId)
        {

        }
        public int UserId { get; private set; }
        public string Dept { get; set; }
        public string FirstName { get; set; }
        private string _lastName;
        public string LastName 
        { 
            get 
            {
                return _lastName;
            } 
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public static int instanceCount { get; set; }




        //Retrieval Method
        public void Retrieve(int userId)
        {
            UserId = userId;            
        }

        //Validate Method
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(Dept)) isValid = false;
            return isValid;
        }

    }
}
