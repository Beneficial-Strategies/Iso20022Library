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
    [KnownType(typeof(RepoCallRequestStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus7Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepoCallRequestStatus7Choice.AcknowledgedAccepted),nameof(RepoCallRequestStatus7Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(RepoCallRequestStatus7Choice.Denied),nameof(RepoCallRequestStatus7Choice.Denied))]
    [JsonDerivedType(typeof(RepoCallRequestStatus7Choice.Proprietary),nameof(RepoCallRequestStatus7Choice.Proprietary))]
    #endif
    [IsoId("_3eDsYTp4EeWVrPy0StzzSg")]
    [DisplayName("Repo Call Request Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepoCallRequestStatus7Choice_
    #else
    public abstract partial class RepoCallRequestStatus7Choice_
    #endif
    {
    }
}
