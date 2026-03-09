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
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason30Choice.Code))]
    [KnownType(typeof(PendingReason30Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason30Choice.Code),nameof(PendingReason30Choice.Code))]
    [JsonDerivedType(typeof(PendingReason30Choice.Proprietary),nameof(PendingReason30Choice.Proprietary))]
    #endif
    [IsoId("_kFQGETq3EeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason30Choice_
    #else
    public abstract partial class PendingReason30Choice_
    #endif
    {
    }
}
