// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification23Choice.BICOrBEI))]
    [KnownType(typeof(PartyIdentification23Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(PartyIdentification23Choice.BICOrBEI),
        nameof(PartyIdentification23Choice.BICOrBEI)
    )]
    [JsonDerivedType(
        typeof(PartyIdentification23Choice.ProprietaryIdentification),
        nameof(PartyIdentification23Choice.ProprietaryIdentification)
    )]
    [IsoId("_QReIgdp-Ed-ak6NoX_4Aeg_-1086683076")]
    [DisplayName("Party Identification 23 Choice")]
    public abstract record PartyIdentification23Choice_ { }
}
