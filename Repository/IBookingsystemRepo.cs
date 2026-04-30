namespace dsv_mini.Repository;
using dsv_mini.Model;

    public interface IBookingsystemRepo
    {
        public void Update(Bookingsystem bookingsystem);
        

        public void Add(Bookingsystem bookingsystem);

        public void Delete(Bookingsystem bookingsystem);
    }

