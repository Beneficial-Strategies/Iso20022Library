// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification195Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification195Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification195Choice.LEI))]
    [JsonDerivedType(typeof(PartyIdentification195Choice.AnyBIC),nameof(PartyIdentification195Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification195Choice.ProprietaryIdentification),nameof(PartyIdentification195Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification195Choice.LEI),nameof(PartyIdentification195Choice.LEI))]
    [IsoId("_4aFsxjqdEemL_ewJY9QP1g")]
    [DisplayName("Party Identification 195 Choice")]
    public abstract partial record PartyIdentification195Choice_
    {
    }
}
