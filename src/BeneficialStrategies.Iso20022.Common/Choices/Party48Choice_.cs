// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party48Choice.Organisation))]
    [KnownType(typeof(Party48Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party48Choice.Organisation),nameof(Party48Choice.Organisation))]
    [JsonDerivedType(typeof(Party48Choice.IndividualPerson),nameof(Party48Choice.IndividualPerson))]
    [IsoId("_nRhZ5ZQ_EemqYPWMBuVawg")]
    [DisplayName("Party 48 Choice")]
    public abstract partial record Party48Choice_
    {
    }
}
