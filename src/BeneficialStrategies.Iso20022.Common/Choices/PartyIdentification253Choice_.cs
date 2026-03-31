// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Identification253Choice.
    /// </summary>
    [KnownType(typeof(PartyIdentification253Choice.BIC))]
    [KnownType(typeof(PartyIdentification253Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification253Choice.BIC),
        nameof(PartyIdentification253Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification253Choice.ProprietaryIdentification),
        nameof(PartyIdentification253Choice.ProprietaryIdentification)
    )]
    [IsoId("_eEwEoZIOEe-HRNGM304Vlw")]
    [DisplayName("Party Identification253Choice")]
    public abstract record PartyIdentification253Choice_ { }
}
