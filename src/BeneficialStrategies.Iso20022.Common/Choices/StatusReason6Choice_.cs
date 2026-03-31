// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(StatusReason6Choice.Code))]
    [KnownType(typeof(StatusReason6Choice.Proprietary))]
    [JsonDerivedType(typeof(StatusReason6Choice.Code), nameof(StatusReason6Choice.Code))]
    [JsonDerivedType(
        typeof(StatusReason6Choice.Proprietary),
        nameof(StatusReason6Choice.Proprietary)
    )]
    [IsoId("_TRGiZtp-Ed-ak6NoX_4Aeg_-1877638998")]
    [DisplayName("Status Reason 6 Choice")]
    public abstract record StatusReason6Choice_ { }
}
