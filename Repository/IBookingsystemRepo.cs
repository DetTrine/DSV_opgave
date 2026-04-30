namespace dsv_mini.Repository
{
    public interface IBookingsystemRepo
    {
        public void Update(Bookingsystem bookingsystem);
        

        public void Add(Bookingsystem bookingsystem);

        public void Delete(Bookingsystem bookingsystem);
    }
}
