// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party16Choice.Organisation))]
    [KnownType(typeof(Party16Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party16Choice.Organisation),nameof(Party16Choice.Organisation))]
    [JsonDerivedType(typeof(Party16Choice.IndividualPerson),nameof(Party16Choice.IndividualPerson))]
    [IsoId("_ll6wwRRkEeOKWo1NF21OVw")]
    [DisplayName("Party 16 Choice")]
    public abstract partial record Party16Choice_
    {
    }
}
