// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for warrant style.
    /// </summary>
    [KnownType(typeof(WarrantStyle3Choice.Code))]
    [KnownType(typeof(WarrantStyle3Choice.Proprietary))]
    [JsonDerivedType(typeof(WarrantStyle3Choice.Code), nameof(WarrantStyle3Choice.Code))]
    [JsonDerivedType(
        typeof(WarrantStyle3Choice.Proprietary),
        nameof(WarrantStyle3Choice.Proprietary)
    )]
    [IsoId("_qwaaSeLbEeWFtOV72FbX9w")]
    [DisplayName("Warrant Style 3 Choice")]
    public abstract record WarrantStyle3Choice_ { }
}
