// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the linkage type.
    /// </summary>
    [KnownType(typeof(LinkageType4Choice.Code))]
    [KnownType(typeof(LinkageType4Choice.Proprietary))]
    [JsonDerivedType(typeof(LinkageType4Choice.Code), nameof(LinkageType4Choice.Code))]
    [JsonDerivedType(
        typeof(LinkageType4Choice.Proprietary),
        nameof(LinkageType4Choice.Proprietary)
    )]
    [IsoId("_6GVvb5NLEeWGlc8L7oPDIg")]
    [DisplayName("Linkage Type 4 Choice")]
    public abstract record LinkageType4Choice_ { }
}
