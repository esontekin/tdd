namespace FizzBuzz.Library
{
    public class Greeter
    {
        private INameService nameService;

        public Greeter(INameService nameService)
        {
            this.nameService = nameService;
        }

        public string SayHello()
        {
            var txt = "Hello, ";
            txt += this.nameService.GetName();
            return txt;
        }
    }
}