// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason14Choice.Code))]
    [KnownType(typeof(DeniedReason14Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason14Choice.Code),nameof(DeniedReason14Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason14Choice.Proprietary),nameof(DeniedReason14Choice.Proprietary))]
    [IsoId("_11uswTqxEeWyoP0PbocV1Q")]
    [DisplayName("Denied Reason 14 Choice")]
    public abstract partial record DeniedReason14Choice_
    {
    }
}
