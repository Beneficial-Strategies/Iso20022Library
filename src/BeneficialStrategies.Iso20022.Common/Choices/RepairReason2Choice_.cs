// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason2Choice.Code))]
    [KnownType(typeof(RepairReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason2Choice.Code), nameof(RepairReason2Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason2Choice.Proprietary),
        nameof(RepairReason2Choice.Proprietary)
    )]
    [IsoId("_UWigcdp-Ed-ak6NoX_4Aeg_-1033470085")]
    [DisplayName("Repair Reason 2 Choice")]
    public abstract record RepairReason2Choice_ { }
}
