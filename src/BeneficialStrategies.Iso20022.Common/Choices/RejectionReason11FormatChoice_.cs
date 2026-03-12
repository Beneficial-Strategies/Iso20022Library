// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of the notification cancellation request.
    /// </summary>
    [KnownType(typeof(RejectionReason11FormatChoice.Code))]
    [KnownType(typeof(RejectionReason11FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason11FormatChoice.Code),nameof(RejectionReason11FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason11FormatChoice.Proprietary),nameof(RejectionReason11FormatChoice.Proprietary))]
    [IsoId("_RoC55Np-Ed-ak6NoX_4Aeg_-672049189")]
    [DisplayName("Rejection Reason 11 Format Choice")]
    public abstract partial record RejectionReason11FormatChoice_
    {
    }
}
