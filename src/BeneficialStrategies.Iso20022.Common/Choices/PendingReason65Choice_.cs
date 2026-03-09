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
    [KnownType(typeof(PendingReason65Choice.Code))]
    [KnownType(typeof(PendingReason65Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason65Choice.Code),nameof(PendingReason65Choice.Code))]
    [JsonDerivedType(typeof(PendingReason65Choice.Proprietary),nameof(PendingReason65Choice.Proprietary))]
    #endif
    [IsoId("_f99MPTi8Eeydid5dcNPKvg")]
    [DisplayName("Pending Reason 65 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason65Choice_
    #else
    public abstract partial class PendingReason65Choice_
    #endif
    {
    }
}
