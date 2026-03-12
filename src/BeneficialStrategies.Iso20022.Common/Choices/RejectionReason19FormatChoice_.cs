// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of a global movement authorisation request.
    /// </summary>
    [KnownType(typeof(RejectionReason19FormatChoice.Code))]
    [KnownType(typeof(RejectionReason19FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason19FormatChoice.Code),nameof(RejectionReason19FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason19FormatChoice.Proprietary),nameof(RejectionReason19FormatChoice.Proprietary))]
    [IsoId("_RoV01tp-Ed-ak6NoX_4Aeg_1504278545")]
    [DisplayName("Rejection Reason 19 Format Choice")]
    public abstract partial record RejectionReason19FormatChoice_
    {
    }
}
