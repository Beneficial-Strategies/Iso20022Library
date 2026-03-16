// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party14Choice.Organisation))]
    [KnownType(typeof(Party14Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party14Choice.Organisation), nameof(Party14Choice.Organisation))]
    [JsonDerivedType(
        typeof(Party14Choice.IndividualPerson),
        nameof(Party14Choice.IndividualPerson)
    )]
    [IsoId("_e1f64xdCEeK5g-3oYI0_9Q")]
    [DisplayName("Party 14 Choice")]
    public abstract record Party14Choice_ { }
}
