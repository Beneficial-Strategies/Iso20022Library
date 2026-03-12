// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason15Choice.Code))]
    [KnownType(typeof(RejectionReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason15Choice.Code),nameof(RejectionReason15Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason15Choice.Proprietary),nameof(RejectionReason15Choice.Proprietary))]
    [IsoId("_agCBsSwvEeOEV5XHD-BKpw")]
    [DisplayName("Rejection Reason 15 Choice")]
    public abstract partial record RejectionReason15Choice_
    {
    }
}
