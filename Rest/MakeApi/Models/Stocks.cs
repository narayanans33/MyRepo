namespace MakeApi.Models {
    public class Stock {
        public int Id { get; set; }
        public string Name { get; set; }

        public Stock(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}