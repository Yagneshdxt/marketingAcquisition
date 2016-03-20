using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace marketingAcquisition
{
    class CommonClasses
    {
    }

    public class LoginDetails
    {
        public Int32 userId { get; set; }
        public String userName { get; set; }
        public String userLName { get; set; }
        public String ContactInfo { get; set; }
        public String Address { get; set; }
        public String Role { get; set; }
    }

    public class ContactDetails
    {
        public Int64 ContactId { get; set; }
        public Int64 OrganizationId { get; set; }
        public String CntName { get; set; }
        public Int64 PositionId { get; set; }
        public String EmailId { get; set; }
        public String ContNumber { get; set; }
        public Boolean InAction { get; set; }
    }

    public class OrganaizationDetails
    {
        public Int64 OrganizationId { get; set; }
        public String OrgName { get; set; }
        public String OrgState { get; set; }
        public String OrgCity { get; set; }
        public String OrgAddress { get; set; }
        public Int64 DomainId { get; set; }
        public String DomainName { get; set; }
        public String userId { get; set; }
        public String userName { get; set; }
        public String nextCall { get; set; }
        public Int64 CallStatusId { get; set; }
        public String CallStatusName { get; set; }
    }

    public class DomainMaster
    {
        public Int64 DomainId { get; set; }
        public String DomainName { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class PostionMaster
    {
        public Int64 PositionId { get; set; }
        public String PositionName { get; set; }
        public Boolean IsActive { get; set; }
    }

    public class ChatHistory
    {
        public Int64 ContactId { get; set; }
        public String TalkedOn { get; set; }
        public String FeedBack { get; set; }

    }

    public class comboboxItems
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class CallStatusMaster
    {
        public Int64 CallStatusId { get; set; }
        public String CallStatusName { get; set; }
    }

    public class Page
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}
