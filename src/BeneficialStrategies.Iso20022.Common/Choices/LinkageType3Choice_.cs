// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the linkage type.
    /// </summary>
    [KnownType(typeof(LinkageType3Choice.Code))]
    [KnownType(typeof(LinkageType3Choice.Proprietary))]
    [JsonDerivedType(typeof(LinkageType3Choice.Code),nameof(LinkageType3Choice.Code))]
    [JsonDerivedType(typeof(LinkageType3Choice.Proprietary),nameof(LinkageType3Choice.Proprietary))]
    [IsoId("_LBo-4Tt4EeW638lNyHKv7A")]
    [DisplayName("Linkage Type 3 Choice")]
    public abstract partial record LinkageType3Choice_
    {
    }
}
