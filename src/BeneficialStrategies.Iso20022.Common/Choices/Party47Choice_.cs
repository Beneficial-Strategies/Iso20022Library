// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party47Choice.Organisation))]
    [KnownType(typeof(Party47Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party47Choice.Organisation), nameof(Party47Choice.Organisation))]
    [JsonDerivedType(
        typeof(Party47Choice.IndividualPerson),
        nameof(Party47Choice.IndividualPerson)
    )]
    [IsoId("_lvVOY5Q_EemqYPWMBuVawg")]
    [DisplayName("Party 47 Choice")]
    public abstract record Party47Choice_ { }
}
