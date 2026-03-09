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
    [KnownType(typeof(PendingReason53Choice.Code))]
    [KnownType(typeof(PendingReason53Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason53Choice.Code),nameof(PendingReason53Choice.Code))]
    [JsonDerivedType(typeof(PendingReason53Choice.Proprietary),nameof(PendingReason53Choice.Proprietary))]
    #endif
    [IsoId("_kTWzM-XzEemEj48jhmlA0Q")]
    [DisplayName("Pending Reason 53 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason53Choice_
    #else
    public abstract partial class PendingReason53Choice_
    #endif
    {
    }
}
