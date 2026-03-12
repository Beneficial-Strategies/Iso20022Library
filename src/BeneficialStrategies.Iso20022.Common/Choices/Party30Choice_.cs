// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the party.
    /// </summary>
    [KnownType(typeof(Party30Choice.Organisation))]
    [KnownType(typeof(Party30Choice.IndividualPerson))]
    [JsonDerivedType(typeof(Party30Choice.Organisation),nameof(Party30Choice.Organisation))]
    [JsonDerivedType(typeof(Party30Choice.IndividualPerson),nameof(Party30Choice.IndividualPerson))]
    [IsoId("_uYUIcUKSEeWuG5hmkcJWSQ")]
    [DisplayName("Party 30 Choice")]
    public abstract partial record Party30Choice_
    {
    }
}
