using LegacyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LegacyService
{
    [ServiceContract]
    public interface IService1
    {
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_religion> getReligions();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_gender> getGenders();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_politic> getPolitics();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_country> getCountries();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_user_types> getUserTypes();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_messagetypes> getMessageTypes();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_hobby> getHobbies();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_school> getSchools();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_job> getJobs();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_state> getStates();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_address> getAddresses();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_message> getMessages();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_user_job> getUserJobs();

        [OperationContract]
        List<DTO_user_address> getUserAddress();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_user_hobby> getUserHobby();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_user_school> getUserSchool();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_associate> getAssociate();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_admin_associates> getAdminAssociate();

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_user> getUser(DTO_user user);

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedResponse)]
        [return: MessageParameter(Name = "Data")]
        [OperationContract]
        List<DTO_user> newLogin(DTO_login user);

    }


    
}
