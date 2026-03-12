// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tax capacity information.
    /// </summary>
    [KnownType(typeof(TaxCapacityParty3Choice.Code))]
    [KnownType(typeof(TaxCapacityParty3Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxCapacityParty3Choice.Code),nameof(TaxCapacityParty3Choice.Code))]
    [JsonDerivedType(typeof(TaxCapacityParty3Choice.Proprietary),nameof(TaxCapacityParty3Choice.Proprietary))]
    [IsoId("_AZHgFNokEeC60axPepSq7g_1368960852")]
    [DisplayName("Tax Capacity Party 3 Choice")]
    public abstract partial record TaxCapacityParty3Choice_
    {
    }
}
