// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tax capacity information.
    /// </summary>
    [KnownType(typeof(TaxCapacityParty4Choice.Code))]
    [KnownType(typeof(TaxCapacityParty4Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxCapacityParty4Choice.Code),nameof(TaxCapacityParty4Choice.Code))]
    [JsonDerivedType(typeof(TaxCapacityParty4Choice.Proprietary),nameof(TaxCapacityParty4Choice.Proprietary))]
    [IsoId("_PeuuwTqHEeWVrPy0StzzSg")]
    [DisplayName("Tax Capacity Party 4 Choice")]
    public abstract partial record TaxCapacityParty4Choice_
    {
    }
}
