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
    /// Choice between a turnaround and pair-off quantity for instructing a one to many and many to many (partial) pair-off or turnaround.
    /// </summary>
    [KnownType(typeof(PairedOrTurnedQuantity5Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity5Choice.TurnedQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PairedOrTurnedQuantity5Choice.PairedOffQuantity),nameof(PairedOrTurnedQuantity5Choice.PairedOffQuantity))]
    [JsonDerivedType(typeof(PairedOrTurnedQuantity5Choice.TurnedQuantity),nameof(PairedOrTurnedQuantity5Choice.TurnedQuantity))]
    #endif
    [IsoId("_YE22YSqHEeyR9JrVGfaMKw")]
    [DisplayName("Paired Or Turned Quantity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PairedOrTurnedQuantity5Choice_
    #else
    public abstract partial class PairedOrTurnedQuantity5Choice_
    #endif
    {
    }
}
