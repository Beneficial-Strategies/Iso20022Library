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
    [KnownType(typeof(RepoCallRequestStatus8Choice.Code))]
    [KnownType(typeof(RepoCallRequestStatus8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepoCallRequestStatus8Choice.Code),nameof(RepoCallRequestStatus8Choice.Code))]
    [JsonDerivedType(typeof(RepoCallRequestStatus8Choice.Proprietary),nameof(RepoCallRequestStatus8Choice.Proprietary))]
    #endif
    [IsoId("_Hx5RATqqEeWyoP0PbocV1Q")]
    [DisplayName("Repo Call Request Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepoCallRequestStatus8Choice_
    #else
    public abstract partial class RepoCallRequestStatus8Choice_
    #endif
    {
    }
}
