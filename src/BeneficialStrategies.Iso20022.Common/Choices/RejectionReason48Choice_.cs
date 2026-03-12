// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason48Choice.Code))]
    [KnownType(typeof(RejectionReason48Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason48Choice.Code),nameof(RejectionReason48Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason48Choice.Proprietary),nameof(RejectionReason48Choice.Proprietary))]
    [IsoId("_ds03Tzi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Reason 48 Choice")]
    public abstract partial record RejectionReason48Choice_
    {
    }
}
