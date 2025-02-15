/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// TaskQueueCumulativeStatisticsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue
{

    public class TaskQueueCumulativeStatisticsResource : Resource
    {
        private static Request BuildFetchRequest(FetchTaskQueueCumulativeStatisticsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskQueues/" + options.PathTaskQueueSid + "/CumulativeStatistics",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskQueueCumulativeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueCumulativeStatistics </returns>
        public static TaskQueueCumulativeStatisticsResource Fetch(FetchTaskQueueCumulativeStatisticsOptions options,
                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskQueueCumulativeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueCumulativeStatistics </returns>
        public static async System.Threading.Tasks.Task<TaskQueueCumulativeStatisticsResource> FetchAsync(FetchTaskQueueCumulativeStatisticsOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch </param>
        /// <param name="pathTaskQueueSid"> The SID of the TaskQueue for which to fetch statistics </param>
        /// <param name="endDate"> Only calculate statistics from on or before this date </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past </param>
        /// <param name="startDate"> Only calculate statistics from on or after this date </param>
        /// <param name="taskChannel"> Only calculate cumulative statistics on this TaskChannel </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to
        ///                       calculate statistics on </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueCumulativeStatistics </returns>
        public static TaskQueueCumulativeStatisticsResource Fetch(string pathWorkspaceSid,
                                                                  string pathTaskQueueSid,
                                                                  DateTime? endDate = null,
                                                                  int? minutes = null,
                                                                  DateTime? startDate = null,
                                                                  string taskChannel = null,
                                                                  string splitByWaitTime = null,
                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueCumulativeStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid){EndDate = endDate, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch </param>
        /// <param name="pathTaskQueueSid"> The SID of the TaskQueue for which to fetch statistics </param>
        /// <param name="endDate"> Only calculate statistics from on or before this date </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past </param>
        /// <param name="startDate"> Only calculate statistics from on or after this date </param>
        /// <param name="taskChannel"> Only calculate cumulative statistics on this TaskChannel </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to
        ///                       calculate statistics on </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueCumulativeStatistics </returns>
        public static async System.Threading.Tasks.Task<TaskQueueCumulativeStatisticsResource> FetchAsync(string pathWorkspaceSid,
                                                                                                          string pathTaskQueueSid,
                                                                                                          DateTime? endDate = null,
                                                                                                          int? minutes = null,
                                                                                                          DateTime? startDate = null,
                                                                                                          string taskChannel = null,
                                                                                                          string splitByWaitTime = null,
                                                                                                          ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueCumulativeStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid){EndDate = endDate, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TaskQueueCumulativeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueueCumulativeStatisticsResource object represented by the provided JSON </returns>
        public static TaskQueueCumulativeStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskQueueCumulativeStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The average time in seconds between Task creation and acceptance
        /// </summary>
        [JsonProperty("avg_task_acceptance_time")]
        public int? AvgTaskAcceptanceTime { get; private set; }
        /// <summary>
        /// The beginning of the interval during which these statistics were calculated
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }
        /// <summary>
        /// The end of the interval during which these statistics were calculated
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }
        /// <summary>
        /// The total number of Reservations created for Tasks in the TaskQueue
        /// </summary>
        [JsonProperty("reservations_created")]
        public int? ReservationsCreated { get; private set; }
        /// <summary>
        /// The total number of Reservations accepted for Tasks in the TaskQueue
        /// </summary>
        [JsonProperty("reservations_accepted")]
        public int? ReservationsAccepted { get; private set; }
        /// <summary>
        /// The total number of Reservations rejected for Tasks in the TaskQueue
        /// </summary>
        [JsonProperty("reservations_rejected")]
        public int? ReservationsRejected { get; private set; }
        /// <summary>
        /// The total number of Reservations that timed out for Tasks in the TaskQueue
        /// </summary>
        [JsonProperty("reservations_timed_out")]
        public int? ReservationsTimedOut { get; private set; }
        /// <summary>
        /// The total number of Reservations canceled for Tasks in the TaskQueue
        /// </summary>
        [JsonProperty("reservations_canceled")]
        public int? ReservationsCanceled { get; private set; }
        /// <summary>
        /// The total number of Reservations rescinded
        /// </summary>
        [JsonProperty("reservations_rescinded")]
        public int? ReservationsRescinded { get; private set; }
        /// <summary>
        /// A list of objects that describe the Tasks canceled and reservations accepted above and below the specified thresholds
        /// </summary>
        [JsonProperty("split_by_wait_time")]
        public object SplitByWaitTime { get; private set; }
        /// <summary>
        /// The SID of the TaskQueue from which these statistics were calculated
        /// </summary>
        [JsonProperty("task_queue_sid")]
        public string TaskQueueSid { get; private set; }
        /// <summary>
        /// The wait duration statistics for Tasks accepted while in the TaskQueue
        /// </summary>
        [JsonProperty("wait_duration_until_accepted")]
        public object WaitDurationUntilAccepted { get; private set; }
        /// <summary>
        /// The wait duration statistics for Tasks canceled while in the TaskQueue
        /// </summary>
        [JsonProperty("wait_duration_until_canceled")]
        public object WaitDurationUntilCanceled { get; private set; }
        /// <summary>
        /// The relative wait duration statistics for Tasks accepted while in the TaskQueue
        /// </summary>
        [JsonProperty("wait_duration_in_queue_until_accepted")]
        public object WaitDurationInQueueUntilAccepted { get; private set; }
        /// <summary>
        /// The total number of Tasks canceled in the TaskQueue
        /// </summary>
        [JsonProperty("tasks_canceled")]
        public int? TasksCanceled { get; private set; }
        /// <summary>
        /// The total number of Tasks completed in the TaskQueue
        /// </summary>
        [JsonProperty("tasks_completed")]
        public int? TasksCompleted { get; private set; }
        /// <summary>
        /// The total number of Tasks deleted in the TaskQueue
        /// </summary>
        [JsonProperty("tasks_deleted")]
        public int? TasksDeleted { get; private set; }
        /// <summary>
        /// The total number of Tasks entered into the TaskQueue
        /// </summary>
        [JsonProperty("tasks_entered")]
        public int? TasksEntered { get; private set; }
        /// <summary>
        /// The total number of Tasks that were moved from one queue to another
        /// </summary>
        [JsonProperty("tasks_moved")]
        public int? TasksMoved { get; private set; }
        /// <summary>
        /// The SID of the Workspace that contains the TaskQueue
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The absolute URL of the TaskQueue statistics resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private TaskQueueCumulativeStatisticsResource()
        {

        }
    }

}