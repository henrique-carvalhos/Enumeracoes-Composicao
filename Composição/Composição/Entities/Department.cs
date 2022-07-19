namespace Composição.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        //Construtor Padrão
        public Department()
        {
        }

        //Construtor que recebe o name como parametro do construtor
        public Department(string name)
        {
            Name = name;
        }

    }
}
