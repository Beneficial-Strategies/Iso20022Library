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
    [KnownType(typeof(PendingReason51Choice.Code))]
    [KnownType(typeof(PendingReason51Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason51Choice.Code),nameof(PendingReason51Choice.Code))]
    [JsonDerivedType(typeof(PendingReason51Choice.Proprietary),nameof(PendingReason51Choice.Proprietary))]
    #endif
    [IsoId("_e4Mr0bLLEemDyeh7tbvg1w")]
    [DisplayName("Pending Reason 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason51Choice_
    #else
    public abstract partial class PendingReason51Choice_
    #endif
    {
    }
}
