// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of capital gain.
    /// </summary>
    [KnownType(typeof(CapitalGainFormat1Choice.Code))]
    [KnownType(typeof(CapitalGainFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(CapitalGainFormat1Choice.Code), nameof(CapitalGainFormat1Choice.Code))]
    [JsonDerivedType(
        typeof(CapitalGainFormat1Choice.Proprietary),
        nameof(CapitalGainFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3K2mNp-Ed-ak6NoX_4Aeg_1034483400")]
    [DisplayName("Capital Gain Format 1 Choice")]
    public abstract record CapitalGainFormat1Choice_ { }
}
