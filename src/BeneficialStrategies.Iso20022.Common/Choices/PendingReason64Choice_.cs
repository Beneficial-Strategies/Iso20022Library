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
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason64Choice.Code))]
    [KnownType(typeof(PendingReason64Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason64Choice.Code),nameof(PendingReason64Choice.Code))]
    [JsonDerivedType(typeof(PendingReason64Choice.Proprietary),nameof(PendingReason64Choice.Proprietary))]
    #endif
    [IsoId("_piJUPzi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Reason 64 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason64Choice_
    #else
    public abstract partial class PendingReason64Choice_
    #endif
    {
    }
}
