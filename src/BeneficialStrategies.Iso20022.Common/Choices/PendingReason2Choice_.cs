// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason2Choice.Code))]
    [KnownType(typeof(PendingReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason2Choice.Code),nameof(PendingReason2Choice.Code))]
    [JsonDerivedType(typeof(PendingReason2Choice.Proprietary),nameof(PendingReason2Choice.Proprietary))]
    [IsoId("_UYeaJdp-Ed-ak6NoX_4Aeg_-2106070769")]
    [DisplayName("Pending Reason 2 Choice")]
    public abstract partial record PendingReason2Choice_
    {
    }
}
