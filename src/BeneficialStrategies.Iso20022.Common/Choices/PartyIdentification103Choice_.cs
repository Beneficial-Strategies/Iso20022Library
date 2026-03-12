// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification103Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification103Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification103Choice.AnyBIC),nameof(PartyIdentification103Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification103Choice.ProprietaryIdentification),nameof(PartyIdentification103Choice.ProprietaryIdentification))]
    [IsoId("_cdRpP5KQEeWHWpTQn1FFVg")]
    [DisplayName("Party Identification 103 Choice")]
    public abstract partial record PartyIdentification103Choice_
    {
    }
}
