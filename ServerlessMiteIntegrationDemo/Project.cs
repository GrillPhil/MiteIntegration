namespace ServerlessMiteIntegrationDemo
{
    class Project
    {
        public int Budget { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public int ConsumedBudget { get; set; }
    }

    class ProjectWrapper
    {
        public Project Project { get; set; }
    }
}
