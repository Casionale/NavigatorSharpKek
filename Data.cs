using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public static class Storage
    {
        public static RootObject root;
        public static List<Group> groups = new List<Group>();

        public class RootObject
        {
            [JsonProperty("data")]
            public Data Data { get; set; }

            [JsonProperty("err_code")]
            public int ErrorCode { get; set; }

            [JsonProperty("success")]
            public bool Success { get; set; }
        }

        public class Data
        {
            [JsonProperty("user")]
            public User User { get; set; }

            [JsonProperty("perms")]
            public Dictionary<string, bool> Permissions { get; set; }

            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("expired_at")]
            public string ExpiredAt { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }
        }

        public class User
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("group_id")]
            public string GroupId { get; set; }

            [JsonProperty("is_deleted")]
            public bool IsDeleted { get; set; }

            [JsonProperty("last_authorize_ts")]
            public string LastAuthorizeTimestamp { get; set; }

            [JsonProperty("created_ts")]
            public string CreatedTimestamp { get; set; }

            [JsonProperty("partner_id")]
            public string PartnerId { get; set; }

            [JsonProperty("municipality_id")]
            public string MunicipalityId { get; set; }

            [JsonProperty("teacher_id")]
            public string TeacherId { get; set; }

            [JsonProperty("department_id")]
            public string DepartmentId { get; set; }

            [JsonProperty("group_name")]
            public string GroupName { get; set; }

            [JsonProperty("group_code")]
            public string GroupCode { get; set; }

            [JsonProperty("municipality_name")]
            public string MunicipalityName { get; set; }

            [JsonProperty("is_allow_private_data")]
            public bool? IsAllowPrivateData { get; set; }

            [JsonProperty("group_code_name")]
            public string GroupCodeName { get; set; }

            [JsonProperty("is_password_outdated")]
            public bool IsPasswordOutdated { get; set; }
        }

        public class GroupsCount
        {
            [JsonProperty("data")]
            public List<Group> Data { get; set; }

            [JsonProperty("err_code")]
            public int ErrorCode { get; set; }

            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("recordsFiltered")]
            public string RecordsFiltered { get; set; } // Приведено как строка, так как в JSON это строка
        }

        public class Group
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("event_id")]
            public string EventId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("teacher")]
            public string Teacher { get; set; }

            [JsonProperty("age_to")]
            public string AgeTo { get; set; }

            [JsonProperty("age_from")]
            public string AgeFrom { get; set; }

            [JsonProperty("size_min")]
            public string SizeMin { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("is_pfdod")]
            public bool IsPfdod { get; set; }

            [JsonProperty("hours_year")]
            public string HoursYear { get; set; }

            [JsonProperty("cost_hour_manual")]
            public object CostHourManual { get; set; } // null в JSON, поэтому используем object

            [JsonProperty("date_start")]
            public string DateStart { get;set; }

            [JsonProperty("date_end")]
            public string DateEnd { get; set; }

            [JsonProperty("is_locked")]
            public bool IsLocked { get; set; }

            [JsonProperty("order_from")]
            public string OrderFrom { get; set; }

            [JsonProperty("order_to")]
            public string OrderTo { get; set; }

            [JsonProperty("is_locked_next_year")]
            public bool IsLockedNextYear { get; set; }

            [JsonProperty("available_next_year_order_from")]
            public object AvailableNextYearOrderFrom { get; set; } // null в JSON

            [JsonProperty("available_next_year_order_to")]
            public object AvailableNextYearOrderTo { get; set; } // null в JSON

            [JsonProperty("is_deleted")]
            public bool IsDeleted { get; set; }

            [JsonProperty("year")]
            public object Year { get; set; } // null в JSON

            [JsonProperty("date_created")]
            public string DateCreated { get; set; }

            [JsonProperty("sport_stage_id")]
            public object SportStageId { get; set; }


            [JsonProperty("sport_training_year")]
            public object SportTrainingYear { get; set; } // null в JSON

            [JsonProperty("entrance_exams_enabled")]
            public bool EntranceExamsEnabled { get; set; }

            [JsonProperty("is_event_address")]
            public bool IsEventAddress { get; set; }

            [JsonProperty("address")]
            public object Address { get; set; } // null в JSON

            [JsonProperty("municipality_id")]
            public string MunicipalityId { get; set; }

            [JsonProperty("municipality_region_id")]
            public object MunicipalityRegionId { get; set; } // null в JSON

            [JsonProperty("program_name")]
            public string ProgramName { get; set; }

            [JsonProperty("event_state")]
            public string EventState { get; set; }

            [JsonProperty("partner_id")]
            public string PartnerId { get; set; }

            [JsonProperty("event/municipality_id")]
            public string EventMunicipalityId { get; set; }

            [JsonProperty("url_code")]
            public string UrlCode { get; set; }

            [JsonProperty("financing_sources")]
            public List<string> FinancingSources { get; set; }

            [JsonProperty("available_order_current_year")]
            public bool AvailableOrderCurrentYear { get; set; }

            [JsonProperty("available_order_next_year")]
            public bool AvailableOrderNextYear { get; set; }

            [JsonProperty("has_schedule")]
            public bool HasSchedule { get; set; }

            [JsonProperty("program_type")]
            public string ProgramType { get; set; }
        }

        public class ChildMember
        {
            public string id { get; set; }
            public string type { get; set; }
            public string order_id { get; set; }
            public string kid_id { get; set; }
            public string kid_last_name { get; set; }
            public string kid_first_name { get; set; }
            public string kid_patro_name { get; set; }
            public string kid_birthday { get; set; }
            public bool kid_is_approved { get; set; }
            public int kid_age { get; set; }
            public string type_code { get; set; }
            public int type_active { get; set; }
            public string type_details { get; set; }
            public string state { get; set; }
            public string info { get; set; }
            public string actual_financing_source { get; set; }
        }

        public class MembersGroup
        {
            public List<ChildMember> data { get; set; }
            public int err_code { get; set; }
            public bool success { get; set; }
            public int recordsFiltered { get; set; }
        }

        public class Certificate
        {
            public string certificate_id { get; set; }
            public string certificate_number { get; set; }
            public string certificate_date_start { get; set; }
            public string certificate_date_end { get; set; }
            public string certificate_type { get; set; }
            public string certificate_variant { get; set; }
            public string certificate_amount_type { get; set; }
            public int certificate_amount_total { get; set; }
            public int certificate_amount_withdraw { get; set; }
            public int certificate_amount_current { get; set; }
            public bool certificate_is_cancelled { get; set; }
            public double category_amount_current { get; set; }
            public int certificate_amount_public { get; set; }
        }

        public class Child
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string patro_name { get; set; }
            public bool is_approved { get; set; }
            public bool is_deleted { get; set; }
            public string sex { get; set; }
            public string citizenship { get; set; }
            public bool is_resident { get; set; }
            public string fio { get; set; }
            public string municipality_id { get; set; }
            public string date_updated { get; set; }
            public string date_created { get; set; }
            public string date_approved { get; set; }
            public string birthday { get; set; }
            public int age { get; set; }
            public object place_of_birth { get; set; }
            public string parent_fio { get; set; }
            public string parent_email { get; set; }
            public string parent_phone { get; set; }
            public string approve_org_caption { get; set; }
            public string approve_user_caption { get; set; }
            public string address_region { get; set; }
            public string address_area { get; set; }
            public string address_address { get; set; }
            public string address_zip { get; set; }
            public object address_date_registration { get; set; }
            public bool is_fact_same_address { get; set; }
            public object fact_address_region { get; set; }
            public object fact_address_area { get; set; }
            public object fact_address_address { get; set; }
            public object fact_address_zip { get; set; }
            public object fact_address_date_registration { get; set; }
            public object org_type { get; set; }
            public object org_name { get; set; }
            public object org_partner_id { get; set; }
            public string site_user_id { get; set; }
            public bool user_can_get_identity_docs { get; set; }
            public bool user_can_insert_identity_docs { get; set; }
            public bool user_can_update_identity_docs { get; set; }
            public bool user_can_delete_identity_docs { get; set; }
            public bool user_can_get_insurance_docs { get; set; }
            public bool user_can_insert_insurance_docs { get; set; }
            public bool user_can_update_insurance_docs { get; set; }
            public bool user_can_delete_insurance_docs { get; set; }
            public List<Certificate> certificates { get; set; }
            public string municipality_name { get; set; }
        }

        public class ChildInfo
        {
            public List<Child> data { get; set; }
            public int err_code { get; set; }
            public bool success { get; set; }
            public int recordsFiltered { get; set; }
        }
    }


}
