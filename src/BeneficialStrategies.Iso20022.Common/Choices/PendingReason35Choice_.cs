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
    [KnownType(typeof(PendingReason35Choice.Code))]
    [KnownType(typeof(PendingReason35Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason35Choice.Code),nameof(PendingReason35Choice.Code))]
    [JsonDerivedType(typeof(PendingReason35Choice.Proprietary),nameof(PendingReason35Choice.Proprietary))]
    #endif
    [IsoId("_cgn4v5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Reason 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason35Choice_
    #else
    public abstract partial class PendingReason35Choice_
    #endif
    {
    }
}
