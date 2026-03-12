// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the EU capital gain.
    /// </summary>
    [KnownType(typeof(EUCapitalGain3Choice.Code))]
    [KnownType(typeof(EUCapitalGain3Choice.Proprietary))]
    [JsonDerivedType(typeof(EUCapitalGain3Choice.Code),nameof(EUCapitalGain3Choice.Code))]
    [JsonDerivedType(typeof(EUCapitalGain3Choice.Proprietary),nameof(EUCapitalGain3Choice.Proprietary))]
    [IsoId("_6TX4YTh7EeaH-93K5JKmzw")]
    [DisplayName("EU Capital Gain 3 Choice")]
    public abstract partial record EUCapitalGain3Choice_
    {
    }
}
