// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party23Choice.Organisation))]
    [KnownType(typeof(Party23Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party23Choice.Organisation),nameof(Party23Choice.Organisation))]
    [JsonDerivedType(typeof(Party23Choice.IndividualPerson),nameof(Party23Choice.IndividualPerson))]
    [IsoId("_BJftAWW8EeSHcOWXSsMhqw")]
    [DisplayName("Party 23 Choice")]
    public abstract partial record Party23Choice_
    {
    }
}
