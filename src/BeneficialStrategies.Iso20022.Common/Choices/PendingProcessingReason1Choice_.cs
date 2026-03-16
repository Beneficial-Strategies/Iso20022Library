// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason1Choice.Code))]
    [KnownType(typeof(PendingProcessingReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason1Choice.Code),
        nameof(PendingProcessingReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason1Choice.Proprietary),
        nameof(PendingProcessingReason1Choice.Proprietary)
    )]
    [IsoId("_UZOBB9p-Ed-ak6NoX_4Aeg_-1812988057")]
    [DisplayName("Pending Processing Reason 1 Choice")]
    public abstract record PendingProcessingReason1Choice_ { }
}
