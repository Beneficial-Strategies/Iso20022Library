// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by providing a BIC or a MIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification11Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification11Choice.CentralCounterparty))]
    [KnownType(typeof(PartyIdentification11Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification11Choice.BICOrBEI),nameof(PartyIdentification11Choice.BICOrBEI))]
    [JsonDerivedType(typeof(PartyIdentification11Choice.CentralCounterparty),nameof(PartyIdentification11Choice.CentralCounterparty))]
    [JsonDerivedType(typeof(PartyIdentification11Choice.ProprietaryIdentification),nameof(PartyIdentification11Choice.ProprietaryIdentification))]
    [IsoId("_QReIh9p-Ed-ak6NoX_4Aeg_-60481643")]
    [DisplayName("Party Identification 11 Choice")]
    public abstract partial record PartyIdentification11Choice_
    {
    }
}
