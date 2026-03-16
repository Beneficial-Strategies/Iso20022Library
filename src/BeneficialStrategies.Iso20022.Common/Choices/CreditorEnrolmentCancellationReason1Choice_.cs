// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(CreditorEnrolmentCancellationReason1Choice.Code))]
    [KnownType(typeof(CreditorEnrolmentCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CreditorEnrolmentCancellationReason1Choice.Code),
        nameof(CreditorEnrolmentCancellationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CreditorEnrolmentCancellationReason1Choice.Proprietary),
        nameof(CreditorEnrolmentCancellationReason1Choice.Proprietary)
    )]
    [IsoId("_pQ9SyfDBEemsS_0xy2XRug")]
    [DisplayName("Creditor Enrolment Cancellation Reason 1 Choice")]
    public abstract record CreditorEnrolmentCancellationReason1Choice_ { }
}
