// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason13Choice.Code))]
    [KnownType(typeof(PendingReason13Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason13Choice.Code), nameof(PendingReason13Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason13Choice.Proprietary),
        nameof(PendingReason13Choice.Proprietary)
    )]
    [IsoId("_Bsv4f_40EeClUvPNHKL9Zw")]
    [DisplayName("Pending Reason 13 Choice")]
    public abstract record PendingReason13Choice_ { }
}
