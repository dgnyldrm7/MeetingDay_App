namespace meetingday.Models
{
    public static class Repository
    {


        public static int counter = 0;

        //private liste oluşturma 
        private static List<Userinfo> _user = new List<Userinfo>();



        //return etme. Listeyi yazdırma
        public static List<Userinfo> Users
        {
            get { return _user; }
        }



         //listeye elememan ekleme...Formdan gelen verileri model sayfasına eklemek!
        public static void CreateUsers(Userinfo user)
        {
            user.Id = counter + 1;
            counter++;
            _user.Add(user);
        }

        public static Userinfo? GetById(int id)
        {
            return _user.FirstOrDefault(user => user.Id == id);
        }



        
        


    }
}
