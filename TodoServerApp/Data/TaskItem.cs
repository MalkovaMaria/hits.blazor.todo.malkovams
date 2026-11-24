namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreateData { get; set; }
        public DateTime? FinishData { get; set; }
    }
}
