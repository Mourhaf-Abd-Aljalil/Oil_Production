namespace OilProduction.Domain.Entities.FarmTree
{
    public class Fertilizers : BaseModel
    {
        public long DescriptionId { get; set; }
        public string Name {  set; get; }
        public int OldestTestAge { get; set; }
    }
}
