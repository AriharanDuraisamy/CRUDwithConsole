using System;

namespace DapperDataAccessLayer
{
    public class TicketModelSP
    {
        public int PASSENGERID { get; set; }
        public long TICKETNUMBER { get; set; }
        public string PASSENGERNAME { get; set; }
        public long PHNUMBER { get; set; }
        public string EMAILID { get; set; }
        public DateTime JOURNEYDATE { get; set; }
    }
}
