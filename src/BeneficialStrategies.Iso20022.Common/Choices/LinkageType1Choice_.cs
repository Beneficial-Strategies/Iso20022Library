// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the linkage type.
    /// </summary>
    [KnownType(typeof(LinkageType1Choice.Code))]
    [KnownType(typeof(LinkageType1Choice.Proprietary))]
    [JsonDerivedType(typeof(LinkageType1Choice.Code), nameof(LinkageType1Choice.Code))]
    [JsonDerivedType(
        typeof(LinkageType1Choice.Proprietary),
        nameof(LinkageType1Choice.Proprietary)
    )]
    [IsoId("_QtyREdp-Ed-ak6NoX_4Aeg_-1874530301")]
    [DisplayName("Linkage Type 1 Choice")]
    public abstract record LinkageType1Choice_ { }
}
