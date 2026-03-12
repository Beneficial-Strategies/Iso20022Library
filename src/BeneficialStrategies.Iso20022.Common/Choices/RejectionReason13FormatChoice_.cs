// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of a movement.
    /// </summary>
    [KnownType(typeof(RejectionReason13FormatChoice.Code))]
    [KnownType(typeof(RejectionReason13FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason13FormatChoice.Code),nameof(RejectionReason13FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason13FormatChoice.Proprietary),nameof(RejectionReason13FormatChoice.Proprietary))]
    [IsoId("_RoMq4tp-Ed-ak6NoX_4Aeg_-549911598")]
    [DisplayName("Rejection Reason 13 Format Choice")]
    public abstract partial record RejectionReason13FormatChoice_
    {
    }
}
