// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party33Choice.Organisation))]
    [KnownType(typeof(Party33Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party33Choice.Organisation),nameof(Party33Choice.Organisation))]
    [JsonDerivedType(typeof(Party33Choice.IndividualPerson),nameof(Party33Choice.IndividualPerson))]
    [IsoId("_5dylEUzQEea8fovz_9xSTQ")]
    [DisplayName("Party 33 Choice")]
    public abstract partial record Party33Choice_
    {
    }
}
