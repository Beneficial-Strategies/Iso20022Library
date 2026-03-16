// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason2Choice.Code))]
    [KnownType(typeof(DeniedReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason2Choice.Code), nameof(DeniedReason2Choice.Code))]
    [JsonDerivedType(
        typeof(DeniedReason2Choice.Proprietary),
        nameof(DeniedReason2Choice.Proprietary)
    )]
    [IsoId("_UW_MaNp-Ed-ak6NoX_4Aeg_1175171251")]
    [DisplayName("Denied Reason 2 Choice")]
    public abstract record DeniedReason2Choice_ { }
}
