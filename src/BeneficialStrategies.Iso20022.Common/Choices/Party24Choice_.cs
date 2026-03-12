// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party24Choice.Organisation))]
    [KnownType(typeof(Party24Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party24Choice.Organisation),nameof(Party24Choice.Organisation))]
    [JsonDerivedType(typeof(Party24Choice.IndividualPerson),nameof(Party24Choice.IndividualPerson))]
    [IsoId("_Zivv0WW8EeSHcOWXSsMhqw")]
    [DisplayName("Party 24 Choice")]
    public abstract partial record Party24Choice_
    {
    }
}
