// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request of a creditor enrolment.
    /// </summary>
    [KnownType(typeof(DebtorActivationCancellationReason1Choice.Code))]
    [KnownType(typeof(DebtorActivationCancellationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DebtorActivationCancellationReason1Choice.Code),
        nameof(DebtorActivationCancellationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DebtorActivationCancellationReason1Choice.Proprietary),
        nameof(DebtorActivationCancellationReason1Choice.Proprietary)
    )]
    [IsoId("_bjMUfPGAEemQ7oqCO5NTQw")]
    [DisplayName("Debtor Activation Cancellation Reason 1 Choice")]
    public abstract record DebtorActivationCancellationReason1Choice_ { }
}
