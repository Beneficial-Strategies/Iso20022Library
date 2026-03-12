// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason4Choice.Code))]
    [KnownType(typeof(RejectionReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason4Choice.Code),nameof(RejectionReason4Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason4Choice.Proprietary),nameof(RejectionReason4Choice.Proprietary))]
    [IsoId("_UYLfNtp-Ed-ak6NoX_4Aeg_-1933906704")]
    [DisplayName("Rejection Reason 4 Choice")]
    public abstract partial record RejectionReason4Choice_
    {
    }
}
