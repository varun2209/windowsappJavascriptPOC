using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeComponent1
{
    public sealed class  LoginResponseModel
    {
        public bool success { get; set; }
        public IList<Datum> data { get; set; }
        public IList<Message> message { get; set; }

        public void setModel(Object obj)
        {

        }

        public void assignTempObjResult()
        {

        }
    }

    public sealed class  SegmentCollection
    {
        public string discount_score { get; set; }
        public string frequency { get; set; }
        public string mvp_score { get; set; }
        public string recency { get; set; }
        public string segment { get; set; }
    }

    public sealed class  User
    {
        public string created_at { get; set; }
        public string email { get; set; }
        public string email_encrypted { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string giftcard_credits_available { get; set; }
        public string id_customer { get; set; }
        public string id_customer_encrypted { get; set; }
        public string is_confirmed { get; set; }
        public string order_count { get; set; }
        public string phone { get; set; }
        public string store_credits_available { get; set; }
        public string total_store_credits { get; set; }
        public string reward_type { get; set; }
        public SegmentCollection segment_collection { get; set; }
    }

    public sealed class  Datum
    {
        public User user { get; set; }
    }

    public sealed class  Message
    {
        public IList<string> success { get; set; }
    }

}
