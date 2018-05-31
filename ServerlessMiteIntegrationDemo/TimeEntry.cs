using Newtonsoft.Json;
namespace ServerlessMiteIntegrationDemo
{
    class TimeEntry
    {
        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        public int Minutes { get; set; }
    }

    class TimeEntryWrapper
    {
        [JsonProperty("time_entry")]
        public TimeEntry TimeEntry { get; set; }
    }
}
