// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party32Choice.Organisation))]
    [KnownType(typeof(Party32Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party32Choice.Organisation),nameof(Party32Choice.Organisation))]
    [JsonDerivedType(typeof(Party32Choice.IndividualPerson),nameof(Party32Choice.IndividualPerson))]
    [IsoId("_v6xi2UNMEeamLdeYEZm56w")]
    [DisplayName("Party 32 Choice")]
    public abstract partial record Party32Choice_
    {
    }
}
