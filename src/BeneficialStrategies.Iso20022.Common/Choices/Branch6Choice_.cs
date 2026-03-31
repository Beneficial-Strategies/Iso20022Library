// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the data used to identify the branch of a reporting counterparty.
    /// </summary>
    [KnownType(typeof(Branch6Choice.Identification))]
    [KnownType(typeof(Branch6Choice.Country))]
    [JsonDerivedType(typeof(Branch6Choice.Identification), nameof(Branch6Choice.Identification))]
    [JsonDerivedType(typeof(Branch6Choice.Country), nameof(Branch6Choice.Country))]
    [IsoId("_qgIYwcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Branch 6 Choice")]
    public abstract record Branch6Choice_ { }
}
