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
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason4Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionReversalReason4Choice.Code),nameof(CorporateActionReversalReason4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionReversalReason4Choice.Proprietary),nameof(CorporateActionReversalReason4Choice.Proprietary))]
    #endif
    [IsoId("_ctOKM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Reversal Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionReversalReason4Choice_
    #else
    public abstract partial class CorporateActionReversalReason4Choice_
    #endif
    {
    }
}
