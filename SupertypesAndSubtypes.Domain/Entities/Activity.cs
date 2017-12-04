using System;

namespace SupertypesAndSubtypes.Domain.Entities
{
    public class Activity
    {
        public Activity(Guid activityId, string activityName)
        {
            ActivityId = activityId;
            ActivityName = activityName;
        }

        public Guid ActivityId { get; }
        public string ActivityName { get; }
    }
}
