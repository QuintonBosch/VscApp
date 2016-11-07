using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VscApp.Data
{
    public class RouteRepository : IRouteRepository
    {
        VscEntities db = new VscEntities();

        public DriverInfo Get(int id)
        {
            try
            {
                DriverInfo driver = db.DriverInfoes.FirstOrDefault(p => p.ID.Equals(id));
                if(driver != null)
                {
                    return driver;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public List<DriverInfo> GetAll()
        {
            return db.DriverInfoes.ToList();
        }

        public bool Update(DriverInfo item)
        {
            try
            {
                DriverInfo driver = db.DriverInfoes.FirstOrDefault(p => p.ID.Equals(item.ID));
                if (driver != null)
                {
                    driver.CustomerID = item.CustomerID;
                    driver.CustomerName = item.CustomerName;
                    driver.DepotID = item.DepotID;
                    driver.DepotName = item.DepotName;
                    driver.DriverID = item.DriverID;
                    driver.DriverName = item.DriverName;
                    driver.DriverReference = item.DriverReference;
                    driver.DriverTag = item.DriverTag;
                    driver.HasArrived = item.HasArrived;
                    driver.HasDeparted = item.HasDeparted;
                    driver.Lat = item.Lat;
                    driver.LocationName = item.LocationName;
                    driver.Long = item.Long;
                    driver.PlannedArrivalTime = item.PlannedArrivalTime;
                    driver.PlannedDepartureTime = item.PlannedDepartureTime;
                    driver.PlannedEndDate = item.PlannedEndDate;
                    driver.PlannedStartDate = item.PlannedStartDate;
                    driver.RouteID = item.RouteID;
                    driver.RouteName = item.RouteName;
                    driver.SequenceNo = item.SequenceNo;
                    driver.StopElementID = item.StopElementID;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
