namespace Dylan_Tran___Assignment_1.Models
{
    public static class Repository
    {
        private static List<RequestForm> requests = new();
        public static IEnumerable<RequestForm> Requests => requests;
        public static void AddRequest(RequestForm requestForm)
        {
            Console.WriteLine(requestForm.ToString());
            requests.Add(requestForm);
        }
    }
}
