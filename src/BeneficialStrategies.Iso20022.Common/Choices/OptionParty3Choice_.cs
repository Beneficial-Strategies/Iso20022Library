// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for option party.
    /// </summary>
    [KnownType(typeof(OptionParty3Choice.Code))]
    [KnownType(typeof(OptionParty3Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionParty3Choice.Code), nameof(OptionParty3Choice.Code))]
    [JsonDerivedType(
        typeof(OptionParty3Choice.Proprietary),
        nameof(OptionParty3Choice.Proprietary)
    )]
    [IsoId("_mzO2kWp7EemmaZLSPtWX5A")]
    [DisplayName("Option Party 3 Choice")]
    public abstract record OptionParty3Choice_ { }
}
