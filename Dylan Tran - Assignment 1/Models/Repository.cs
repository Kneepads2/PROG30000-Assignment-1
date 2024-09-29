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
        new Equipment { Id = 4, Type = EquipmentType.Tablet, Description = "iPad Air", IsAvailable = true },
        new Equipment { Id = 5, Type = EquipmentType.Phone, Description = "iPhone 1", IsAvailable = true },
        new Equipment { Id = 6, Type = EquipmentType.Laptop, Description = "Macbook", IsAvailable = true },
        new Equipment { Id = 7, Type = EquipmentType.Phone, Description = "Windows Phone", IsAvailable = false },
        new Equipment { Id = 8, Type = EquipmentType.Tablet, Description = "iPhone 16", IsAvailable = false }
    };

        public static IEnumerable<Equipment> GetAllEquipment() => equipmentList;

        public static IEnumerable<Equipment> GetAvailableEquipment()
        {
            return equipmentList.Where(e => e.IsAvailable);
        }

    }
}
