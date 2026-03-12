// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
    /// </summary>
    [KnownType(typeof(PartyIdentification72Choice.AnyBIC))]
    [KnownType(typeof(PartyIdentification72Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(PartyIdentification72Choice.AnyBIC),nameof(PartyIdentification72Choice.AnyBIC))]
    [JsonDerivedType(typeof(PartyIdentification72Choice.ProprietaryIdentification),nameof(PartyIdentification72Choice.ProprietaryIdentification))]
    [IsoId("_3JsB7nHeEeG8t-w1mFnmhg_-1626691800")]
    [DisplayName("Party Identification 72 Choice")]
    public abstract partial record PartyIdentification72Choice_
    {
    }
}
