namespace Dylan_Tran___Assignment_1.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public EquipmentType Type { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }

    public enum EquipmentType
    {
        Laptop,
        Phone,
        Tablet,
        Other
    }

}
