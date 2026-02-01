using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class Activity
    {

        private string activityType;

        public Activity(string activityType)
        {
            this.activityType = activityType;
        }

        public int CalWalkingCaloriesBurned(int numsOfSteps, int distance, int timeTaken)
        {
            // Calories burned per step and per meter
            double caloriesPerStep = 0.04;
            double caloriesPerMeter = 0.05;

            int caloriesFromSteps = (int)(numsOfSteps * caloriesPerStep);
            int caloriesFromDistance = (int)(distance * caloriesPerMeter);

            double caloriesPerMinute = 4.5;
            int caloriesFromTime = (int)(timeTaken * caloriesPerMinute);


            int totalCaloriesBurned = caloriesFromSteps + caloriesFromDistance + caloriesFromTime;

            return totalCaloriesBurned;
        }

        public int CalJumpingRopeCalories(int duration, int weight, int speed)
        {
            // Using a simplified formula for jumping rope calories burned
            return (int)Math.Floor((0.00055 * weight * duration * speed));
        }

        public int MetBasedCalulation(int duration, int intensity, int weight, double constant)
        {
            // MET values based on activity type and intensity
            double met = 1;

            if (this.activityType == "Yoga")
            {
                switch (intensity)
                {
                    case 0:
                        met = 2.5;
                        break;
                    case 1:
                        met = 3.0;
                        break;
                    case 2:
                        met = 4.0;
                        break;
                    default:
                        met = 2.5;
                        break;
                }
            } else
            {
                switch (intensity)
                {
                    case 0:
                        met = 6;
                        break;
                    case 1:
                        met = 7.5;
                        break;
                    case 2:
                        met = 9.5;
                        break;
                    default:
                        met = 6;
                        break;
                }
            }


            return (int)Math.Floor((duration * weight * met) / constant);
           
        }

        public int MetBasedCalulation(int duration, int intensity, int weight, double constant, double constantII)
        {
            return (int)Math.Floor(MetBasedCalulation(duration, intensity, weight, constant) * constantII);
        }

        public void submitActivity(int userId, int goalId, int caloriesBurned)
        {
            // Submit activity and update user data
            User user = new User(userId, goalId);
            user.UpdateActivity(this.activityType, caloriesBurned);
            
        }
    }
}
