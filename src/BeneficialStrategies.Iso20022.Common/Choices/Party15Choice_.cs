// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party15Choice.Organisation))]
    [KnownType(typeof(Party15Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party15Choice.Organisation),nameof(Party15Choice.Organisation))]
    [JsonDerivedType(typeof(Party15Choice.IndividualPerson),nameof(Party15Choice.IndividualPerson))]
    [IsoId("_Wf_qkRRQEeOKWo1NF21OVw")]
    [DisplayName("Party 15 Choice")]
    public abstract partial record Party15Choice_
    {
    }
}
