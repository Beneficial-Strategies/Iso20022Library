// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the data used to identify the branch of a reporting counterparty.
    /// </summary>
    [KnownType(typeof(Branch5Choice.Identification))]
    [KnownType(typeof(Branch5Choice.Country))]
    [JsonDerivedType(typeof(Branch5Choice.Identification),nameof(Branch5Choice.Identification))]
    [JsonDerivedType(typeof(Branch5Choice.Country),nameof(Branch5Choice.Country))]
    [IsoId("_BpDRkMg4Eeu4ecZgAYuz5w")]
    [DisplayName("Branch 5 Choice")]
    public abstract partial record Branch5Choice_
    {
    }
}
