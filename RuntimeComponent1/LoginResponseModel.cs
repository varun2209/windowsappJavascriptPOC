using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeComponent1
{
    public sealed class  LoginResponseModel
    {

        //private delegate void modelObjectReceived(dynamic obj);
        //private event modelObjectReceived ModelDataLoadComplete;

        private static event EventHandler ModelReceiveAction;

        //public static EventHandler<dynamic> ModelReceivedEventHandler;
        public bool success { get; set; }
        private Datum _data = new Datum();//{ get; set; }
        public Datum data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        public Datum datatype
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        private Message _message = new Message();
        public Message message {
            get {
                return _message;
            }
            set {
                _message = value;
            }
        }

        //public void addTodata(dynamic dataObj)
        //{

        //}

        public static void GetModelEvent(dynamic methodObj)
        {
           ModelReceiveAction += methodObj;
        }

        public void setModel(Object obj)
        {

        }

        public void assignTempObjResult()
        {
            ModelReceiveAction(this, EventArgs.Empty);
        }
    }

    public sealed class  SegmentCollection
    {
        public dynamic discount_score { get; set; }
        public dynamic frequency { get; set; }
        public dynamic mvp_score { get; set; }
        public dynamic recency { get; set; }
        public dynamic segment { get; set; }
    }

    public sealed class  User
    {
        public dynamic created_at { get; set; }
        public dynamic email { get; set; }
        public dynamic email_encrypted { get; set; }
        public dynamic first_name { get; set; }
        public dynamic last_name { get; set; }
        public dynamic gender { get; set; }
        public dynamic giftcard_credits_available { get; set; }
        public dynamic id_customer { get; set; }
        public dynamic id_customer_encrypted { get; set; }
        public dynamic is_confirmed { get; set; }
        public dynamic order_count { get; set; }
        public dynamic phone { get; set; }
        public dynamic store_credits_available { get; set; }
        public dynamic total_store_credits { get; set; }
        public dynamic reward_type { get; set; }
        private SegmentCollection _segment_collection = new SegmentCollection();
        public SegmentCollection segment_collection {
            get {
                return _segment_collection;
            }
            set {
                _segment_collection = value;
            }
        }
    }

    public sealed class  Datum
    {
        private User _user = new User();
        public User user {
            get {
                return _user;
            }
            set {
                _user = value;
            }
        }
    }

    public sealed class  Message
    {
        private List<string> _success;
        public dynamic successtype { get; set; }
        public IList<string> success {
            get{
                return _success;
            }
            set{
               _success = (List<string>)value;
            }
        }
        public void addTosuccess(dynamic item)
        {
            if(_success == null)
            {
                _success = new List<string>();
            }
            _success.Add(item);
        }
    }

}
