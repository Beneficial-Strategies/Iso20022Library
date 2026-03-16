// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by providing a BIC or a MIC.
    /// </summary>
    [KnownType(typeof(PartyIdentification24Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification24Choice.MIC))]
    [JsonDerivedType(
        typeof(PartyIdentification24Choice.BICOrBEI),
        nameof(PartyIdentification24Choice.BICOrBEI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification24Choice.MIC),
        nameof(PartyIdentification24Choice.MIC)
    )]
    [IsoId("_QReIhNp-Ed-ak6NoX_4Aeg_-550871246")]
    [DisplayName("Party Identification 24 Choice")]
    public abstract record PartyIdentification24Choice_ { }
}
