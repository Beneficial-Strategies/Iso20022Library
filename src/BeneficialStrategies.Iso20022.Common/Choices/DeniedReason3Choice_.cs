// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason3Choice.Code))]
    [KnownType(typeof(DeniedReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason3Choice.Code),nameof(DeniedReason3Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason3Choice.Proprietary),nameof(DeniedReason3Choice.Proprietary))]
    [IsoId("_UW_MZdp-Ed-ak6NoX_4Aeg_660464543")]
    [DisplayName("Denied Reason 3 Choice")]
    public abstract partial record DeniedReason3Choice_
    {
    }
}
