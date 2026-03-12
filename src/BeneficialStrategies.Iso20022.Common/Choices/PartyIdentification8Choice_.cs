// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a party by a choice between a BIC or a name and address.
    /// </summary>
    [KnownType(typeof(PartyIdentification8Choice.NameAndAddress))]
    [KnownType(typeof(PartyIdentification8Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification8Choice.NameAndAddress),nameof(PartyIdentification8Choice.NameAndAddress))]
    [JsonDerivedType(typeof(PartyIdentification8Choice.BICOrBEI),nameof(PartyIdentification8Choice.BICOrBEI))]
    [IsoId("_Q7fV6dp-Ed-ak6NoX_4Aeg_1364552938")]
    [DisplayName("Party Identification 8 Choice")]
    public abstract partial record PartyIdentification8Choice_
    {
    }
}
