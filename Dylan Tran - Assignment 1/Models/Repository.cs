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

        private static List<Equipment> equipmentList = new()
    {
        new Equipment { Id = 1, Type = EquipmentType.Laptop, Description = "Dell XPS 13", IsAvailable = true },
        new Equipment { Id = 2, Type = EquipmentType.Phone, Description = "iPhone 12", IsAvailable = false },
        new Equipment { Id = 3, Type = EquipmentType.Tablet, Description = "iPad Air", IsAvailable = true }
    };

        public static IEnumerable<Equipment> GetAllEquipment() => equipmentList;

        public static IEnumerable<Equipment> GetAvailableEquipment()
        {
            return equipmentList.Where(e => e.IsAvailable);
        }

    }
}
