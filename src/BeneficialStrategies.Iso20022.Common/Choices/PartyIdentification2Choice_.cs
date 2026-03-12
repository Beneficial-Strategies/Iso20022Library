// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party.
    /// </summary>
    [KnownType(typeof(PartyIdentification2Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification2Choice.ProprietaryIdentification))]
    [KnownType(typeof(PartyIdentification2Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification2Choice.BICOrBEI),nameof(PartyIdentification2Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification2Choice.ProprietaryIdentification),nameof(PartyIdentification2Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification2Choice.NameAndAddress),nameof(PartyIdentification2Choice.NameAndAddress))]
    [IsoId("_QRBcl9p-Ed-ak6NoX_4Aeg_-1721645359")]
    [DisplayName("Party Identification 2 Choice")]
    public abstract partial record PartyIdentification2Choice_
    {
    }
}
