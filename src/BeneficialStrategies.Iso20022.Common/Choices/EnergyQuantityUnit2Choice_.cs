// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the units used to quantify an energy.
    /// </summary>
    [KnownType(typeof(EnergyQuantityUnit2Choice.Code))]
    [KnownType(typeof(EnergyQuantityUnit2Choice.Proprietary))]
    [JsonDerivedType(typeof(EnergyQuantityUnit2Choice.Code),nameof(EnergyQuantityUnit2Choice.Code))]
    [JsonDerivedType(typeof(EnergyQuantityUnit2Choice.Proprietary),nameof(EnergyQuantityUnit2Choice.Proprietary))]
    [IsoId("_r9qqoSi_EeuKKc2MztSwPw")]
    [DisplayName("Energy Quantity Unit 2 Choice")]
    public abstract partial record EnergyQuantityUnit2Choice_
    {
    }
}
