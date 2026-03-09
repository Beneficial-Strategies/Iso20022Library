// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus2Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepoCallRequestStatus2Choice.AcknowledgedAccepted),nameof(RepoCallRequestStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(RepoCallRequestStatus2Choice.Denied),nameof(RepoCallRequestStatus2Choice.Denied))]
    [JsonDerivedType(typeof(RepoCallRequestStatus2Choice.Proprietary),nameof(RepoCallRequestStatus2Choice.Proprietary))]
    #endif
    [IsoId("_UWYvc9p-Ed-ak6NoX_4Aeg_-1943927387")]
    [DisplayName("Repo Call Request Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepoCallRequestStatus2Choice_
    #else
    public abstract partial class RepoCallRequestStatus2Choice_
    #endif
    {
    }
}
