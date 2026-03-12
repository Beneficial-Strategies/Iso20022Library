// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the reason of a rejection of an election advice.
    /// </summary>
    [KnownType(typeof(RejectionReason18FormatChoice.Code))]
    [KnownType(typeof(RejectionReason18FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason18FormatChoice.Code),nameof(RejectionReason18FormatChoice.Code))]
    [JsonDerivedType(typeof(RejectionReason18FormatChoice.Proprietary),nameof(RejectionReason18FormatChoice.Proprietary))]
    [IsoId("_RoV009p-Ed-ak6NoX_4Aeg_-1965302584")]
    [DisplayName("Rejection Reason 18 Format Choice")]
    public abstract partial record RejectionReason18FormatChoice_
    {
    }
}
