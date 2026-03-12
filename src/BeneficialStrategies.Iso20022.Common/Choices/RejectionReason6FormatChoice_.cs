// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of the notification advice.
    /// </summary>
    [KnownType(typeof(RejectionReason6FormatChoice.Code))]
    [KnownType(typeof(RejectionReason6FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason6FormatChoice.Code),nameof(RejectionReason6FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason6FormatChoice.Proprietary),nameof(RejectionReason6FormatChoice.Proprietary))]
    [IsoId("_Rofl1dp-Ed-ak6NoX_4Aeg_-484307759")]
    [DisplayName("Rejection Reason 6 Format Choice")]
    public abstract partial record RejectionReason6FormatChoice_
    {
    }
}
