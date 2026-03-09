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
    [KnownType(typeof(PairedOrTurnedQuantity1Choice.PairedOffQuantity))]
    [KnownType(typeof(PairedOrTurnedQuantity1Choice.TurnedQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PairedOrTurnedQuantity1Choice.PairedOffQuantity),nameof(PairedOrTurnedQuantity1Choice.PairedOffQuantity))]
    [JsonDerivedType(typeof(PairedOrTurnedQuantity1Choice.TurnedQuantity),nameof(PairedOrTurnedQuantity1Choice.TurnedQuantity))]
    #endif
    [IsoId("_UdsRU9p-Ed-ak6NoX_4Aeg_259253644")]
    [DisplayName("Paired Or Turned Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PairedOrTurnedQuantity1Choice_
    #else
    public abstract partial class PairedOrTurnedQuantity1Choice_
    #endif
    {
    }
}
