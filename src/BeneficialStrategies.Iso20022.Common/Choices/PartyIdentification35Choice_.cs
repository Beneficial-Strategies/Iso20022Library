// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification35Choice.BIC))]
    [KnownType(typeof(PartyIdentification35Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification35Choice.BIC),
        nameof(PartyIdentification35Choice.BIC)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification35Choice.ProprietaryIdentification),
        nameof(PartyIdentification35Choice.ProprietaryIdentification)
    )]
    [IsoId("_QPYd4dp-Ed-ak6NoX_4Aeg_-1523931735")]
    [DisplayName("Party Identification 35 Choice")]
    public abstract record PartyIdentification35Choice_ { }
}
