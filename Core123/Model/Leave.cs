namespace Core123.Model
{
    public class Leave
    {
    public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string? Reason { get; set; }
        public string? Status { get; set; }

    }

}
    
