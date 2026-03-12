// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a person, an organisation or a financial institution.
    /// </summary>
    [KnownType(typeof(Party28Choice.Party))]
    [KnownType(typeof(Party28Choice.Agent))]
    [JsonDerivedType(typeof(Party28Choice.Party),nameof(Party28Choice.Party))]
    [JsonDerivedType(typeof(Party28Choice.Agent),nameof(Party28Choice.Agent))]
    [IsoId("_b_UWEdnSEeS--7IJLPC9lw")]
    [DisplayName("Party 28 Choice")]
    public abstract partial record Party28Choice_
    {
    }
}
