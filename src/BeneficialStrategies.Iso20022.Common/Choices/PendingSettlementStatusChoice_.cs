// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the pending settlement status.
    /// </summary>
    [KnownType(typeof(PendingSettlementStatusChoice.Reason))]
    [KnownType(typeof(PendingSettlementStatusChoice.DataSourceScheme))]
    [KnownType(typeof(PendingSettlementStatusChoice.NoReason))]
    [JsonDerivedType(typeof(PendingSettlementStatusChoice.Reason),nameof(PendingSettlementStatusChoice.Reason))]
    [JsonDerivedType(typeof(PendingSettlementStatusChoice.DataSourceScheme),nameof(PendingSettlementStatusChoice.DataSourceScheme))]
    [JsonDerivedType(typeof(PendingSettlementStatusChoice.NoReason),nameof(PendingSettlementStatusChoice.NoReason))]
    [IsoId("_U1POpdp-Ed-ak6NoX_4Aeg_-1501368338")]
    [DisplayName("Pending Settlement Status Choice")]
    public abstract partial record PendingSettlementStatusChoice_
    {
    }
}
