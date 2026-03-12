// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code for specifying the reason of a settlement failure.
    /// </summary>
    [KnownType(typeof(FailedSettlementReason1FormatChoice.Code))]
    [KnownType(typeof(FailedSettlementReason1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(FailedSettlementReason1FormatChoice.Code),nameof(FailedSettlementReason1FormatChoice.Code))]
    [JsonDerivedType(typeof(FailedSettlementReason1FormatChoice.Proprietary),nameof(FailedSettlementReason1FormatChoice.Proprietary))]
    [IsoId("_RmjsItp-Ed-ak6NoX_4Aeg_220367712")]
    [DisplayName("Failed Settlement Reason 1 Format Choice")]
    public abstract partial record FailedSettlementReason1FormatChoice_
    {
    }
}
