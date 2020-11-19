namespace RehberApp.Entities
{
    public class Rehber
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string internalNumber { get; set; }
        public string mobileNumber { get; set; }
        public string shortNumber { get; set; }
        public string shortCode { get; set; }
        public bool isManager { get; set; }
    }
}