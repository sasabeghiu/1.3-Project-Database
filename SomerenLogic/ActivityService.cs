using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;
        //basic constructor creating an dao object
        public ActivityService() 
        {
            activitydb = new ActivityDao();
        }
        //get a list with all activities from db
        public List<Activity> GetActivities() 
        {
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }
        //removes a activity using the method from dao class
        public void RemoveActivity(Activity activity) 
        {
            activitydb.RemoveActivity(activity);
        }
        //modifyies a activity using the method from dao class
        public void ModifyActivity(Activity activity) 
        {
            activitydb.ModifyActivity(activity);
        }
        //adds a activity using the method from dao class
        public void AddActivity(Activity activity) 
        {
            activitydb.AddActivity(activity);
        }
    }
}
