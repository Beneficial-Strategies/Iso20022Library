// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the units used to quantify an energy.
    /// </summary>
    [KnownType(typeof(EnergyQuantityUnit1Choice.Code))]
    [KnownType(typeof(EnergyQuantityUnit1Choice.Proprietary))]
    [JsonDerivedType(typeof(EnergyQuantityUnit1Choice.Code),nameof(EnergyQuantityUnit1Choice.Code))]
    [JsonDerivedType(typeof(EnergyQuantityUnit1Choice.Proprietary),nameof(EnergyQuantityUnit1Choice.Proprietary))]
    [IsoId("_GCAHUKfwEeW_OId9wS8dsQ")]
    [DisplayName("Energy Quantity Unit 1 Choice")]
    public abstract partial record EnergyQuantityUnit1Choice_
    {
    }
}
