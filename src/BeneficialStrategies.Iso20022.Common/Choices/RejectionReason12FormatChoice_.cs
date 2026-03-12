// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of a deactivation instruction.
    /// </summary>
    [KnownType(typeof(RejectionReason12FormatChoice.Code))]
    [KnownType(typeof(RejectionReason12FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason12FormatChoice.Code),nameof(RejectionReason12FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason12FormatChoice.Proprietary),nameof(RejectionReason12FormatChoice.Proprietary))]
    [IsoId("_RoC559p-Ed-ak6NoX_4Aeg_-1828809794")]
    [DisplayName("Rejection Reason 12 Format Choice")]
    public abstract partial record RejectionReason12FormatChoice_
    {
    }
}
