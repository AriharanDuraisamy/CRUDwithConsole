using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDataAccessLayer;


namespace TicketDetails
{
    public class TMenuDriven
    {
        ITicketSP _crud =null;
        public List<TicketModelSP> records = new List<TicketModelSP>();
        public TMenuDriven()
        {
            _crud = new TicketBookingSP();
        }
        public void TMenu()
        {
            int Action;
            do
            {
                Console.WriteLine("\t\t\t\tTICKET RESERVATION");
                Console.WriteLine("1.INSERT");
                Console.WriteLine("2.DELETE");
                Console.WriteLine("3.UPDATE");
                Console.WriteLine("4.SELECTID");
                Console.WriteLine("5.SELECT");
                Console.WriteLine("ABOVE 5.EXIT ACTION");
                Console.WriteLine("ENTER THE ACTION: ");
                Action = Convert.ToInt32(Console.ReadLine());

                switch (Action)
                {
                    //insert
                    case 1:
                        Console.WriteLine("Enter the no of ticket: ");
                        int noofprod = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < noofprod; i++)
                        {
                            TicketModelSP Details = new TicketModelSP();
                            Console.Write("Enter the TICKET NUMBER: ");
                            Details.TICKETNUMBER = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter Name OF PASSENGERNAME: ");
                            Details.PASSENGERNAME = Console.ReadLine();
                            Console.Write("Enter the PHONE NUMBER: ");
                            Details.PHNUMBER = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter the Email_ID: ");
                            Details.EMAILID = Console.ReadLine();
                            Console.Write("Enter Journeydate(MM-DD-YYYY) of Passenger: ");
                            Details.EMAILID = Console.ReadLine();
                            records.Add(Details);
                            _crud.InsertSP(Details);
                            var record1 = _crud.ReadSP();
                            Console.WriteLine("PASSENGERID\tTICKETNUMBER\tPASSENGERNAME\tPHNUMBER\tEMAILID\tJOURNEYDATE");
                            foreach (var p in record1)
                            {
                                Console.WriteLine($"{p.PASSENGERID}\t{p.TICKETNUMBER}\t{p.PASSENGERNAME}\t{p.PHNUMBER}\t{p.EMAILID}\t{p.JOURNEYDATE}");
                            }

                        }
                        break;
                    //delete
                    case 2:
                        {
                            Console.WriteLine("Enter the deleting passenger id");
                            long del = Convert.ToInt64(Console.ReadLine());
                            var record = _crud.ReadbyIDSP(del);
                            if (record != null)
                            {
                                _crud.DeleteSP(del);
                            }
                            else
                            {
                                Console.WriteLine("invalid ticketid");
                            }
                            Console.WriteLine("PASSENGERID\tTICKETNUMBER\tPASSENGERNAME\tPHNUMBER\tEMAILID\tJOURNEYDATE");
                            var record2 = _crud.ReadSP();
                            foreach (var p in record2)
                            {
                                Console.WriteLine($"{p.PASSENGERID}\t{p.TICKETNUMBER}\t{p.PASSENGERNAME}\t{p.PHNUMBER}\t{p.EMAILID}\t{p.JOURNEYDATE}");
                            }
                        }
                        break;
                    //update
                    case 3:
                        {
                            Console.WriteLine("enter the update passenger id");
                            int ticid = Convert.ToInt32(Console.ReadLine());
                            TicketModelSP Details = new TicketModelSP();
                            Console.Write("Enter the TICKET NUMBER: ");
                            Details.TICKETNUMBER = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter Name OF PASSENGERNAME: ");
                            Details.PASSENGERNAME = Console.ReadLine();
                            Console.Write("Enter the PHONE NUMBER: ");
                            Details.PHNUMBER = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter the Email_ID: ");
                            Details.EMAILID = Console.ReadLine();
                            Console.Write("Enter Journeydate(MM-DD-YYYY) of Passenger: ");
                            Details.JOURNEYDATE = Convert.ToDateTime(Console.ReadLine());
                            _crud.UpdateSP(ticid, Details);
                            var record3 = _crud.ReadSP();
                            Console.WriteLine("PASSENGERID\tTICKETNUMBER\tPASSENGERNAME\tPHNUMBER\tEMAILID\tJOURNEYDATE");
                            foreach (var p in record3)
                            {
                                Console.WriteLine($"{p.PASSENGERID}\t{p.TICKETNUMBER}\t{p.PASSENGERNAME}\t{p.PHNUMBER}\t{p.EMAILID}\t{p.JOURNEYDATE}");
                            }
                        }
                        break;
                    //selectid
                    case 4:
                        {
                            Console.WriteLine("enter the selected passenger id");
                            long selectid = Convert.ToInt64(Console.ReadLine());
                            var record4 = _crud.ReadbyIDSP(selectid);
                            Console.WriteLine("PASSENGERID\tTICKETNUMBER\tPASSENGERNAME\tPHNUMBER\tEMAILID\tJOURNEYDATE");
                            foreach (var p in record4)
                            {
                                Console.WriteLine("{p.PASSENGERID}\t{p.TICKETNUMBER}\t{p.PASSENGERNAME}\t{p.PHNUMBER}\t{p.EMAILID}\t{p.JOURNEYDATE}");
                            }
                            /*if(record4==null)
                            {
                                Console.WriteLine("Invalid passenger id");
                            }
                            else
                            {
                                Console.WriteLine($"{.PASSENGERID}\t{record4.TICKETNUMBER}\t{record4.PASSENGERNAME}\t{record4.PHNUMBER}\t{record4.EMAILID}\t{record4.JOURNEYDATE}");
                            }*/
                        }
                        break;
                    //selectall
                    case 5:
                        {
                            var record5 = _crud.ReadSP();
                            Console.WriteLine("PASSENGERID\tTICKETNUMBER\tPASSENGERNAME\tPHNUMBER\tEMAILID\tJOURNEYDATE");
                            foreach (var p in record5)
                            {
                                Console.WriteLine($" {p.PASSENGERID}\t{p.TICKETNUMBER}\t{p.PASSENGERNAME}\t{p.PHNUMBER}\t{p.EMAILID}\t{p.JOURNEYDATE}");
                            }
                        }
                        break;

                        case 6:
                            Console.WriteLine("invalid");
                            break;
                }
            } while (Action < 6);
        }
    }
}

