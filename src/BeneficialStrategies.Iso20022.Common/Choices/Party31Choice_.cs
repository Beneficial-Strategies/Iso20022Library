// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party31Choice.Organisation))]
    [KnownType(typeof(Party31Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party31Choice.Organisation), nameof(Party31Choice.Organisation))]
    [JsonDerivedType(
        typeof(Party31Choice.IndividualPerson),
        nameof(Party31Choice.IndividualPerson)
    )]
    [IsoId("_HQ4TwSCBEeWhHbfCMWc1cw")]
    [DisplayName("Party 31 Choice")]
    public abstract record Party31Choice_ { }
}
