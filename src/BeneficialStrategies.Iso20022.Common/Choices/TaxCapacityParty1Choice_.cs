// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tax capacity information.
    /// </summary>
    [KnownType(typeof(TaxCapacityParty1Choice.Code))]
    [KnownType(typeof(TaxCapacityParty1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxCapacityParty1Choice.Code), nameof(TaxCapacityParty1Choice.Code))]
    [JsonDerivedType(
        typeof(TaxCapacityParty1Choice.Proprietary),
        nameof(TaxCapacityParty1Choice.Proprietary)
    )]
    [IsoId("_Qv3UtNp-Ed-ak6NoX_4Aeg_948349513")]
    [DisplayName("Tax Capacity Party 1 Choice")]
    public abstract record TaxCapacityParty1Choice_ { }
}
