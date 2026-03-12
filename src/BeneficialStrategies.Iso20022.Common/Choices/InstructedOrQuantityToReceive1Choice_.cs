// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an instructed quantity or a quantity to receive.
    /// </summary>
    [KnownType(typeof(InstructedOrQuantityToReceive1Choice.InstructedQuantity))]
    [KnownType(typeof(InstructedOrQuantityToReceive1Choice.QuantityToReceive))]
    [JsonDerivedType(typeof(InstructedOrQuantityToReceive1Choice.InstructedQuantity),nameof(InstructedOrQuantityToReceive1Choice.InstructedQuantity))]
    [JsonDerivedType(typeof(InstructedOrQuantityToReceive1Choice.QuantityToReceive),nameof(InstructedOrQuantityToReceive1Choice.QuantityToReceive))]
    [IsoId("_UHCr6dp-Ed-ak6NoX_4Aeg_-1969996831")]
    [DisplayName("Instructed Or Quantity To Receive 1 Choice")]
    public abstract partial record InstructedOrQuantityToReceive1Choice_
    {
    }
}
