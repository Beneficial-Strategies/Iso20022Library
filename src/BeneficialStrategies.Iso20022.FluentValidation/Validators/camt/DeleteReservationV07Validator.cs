// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="DeleteReservationV07"/> (camt.049.001.07) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3IjczEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The DeleteReservation message is used to request the deletion of one particular reservation
/// by the member and managed by the transaction administrator.
///
/// Usage
/// The deletion of a reservation in the system will not only reset the reserved liquidity to
/// zero, but also delete the reservation itself from the system — only the default reservation
/// for the current business day remains in the system.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>CurrentReservation</term><description>ReservationIdentification4 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, the optional <c>CurrentReservation</c> building
/// block, and the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class DeleteReservationV07Validator : AbstractValidator<DeleteReservationV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> building block, the optional
    /// <c>CurrentReservation</c> building block, and the <c>SupplementaryData</c> collection's
    /// item type — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="currentReservationValidator">
    /// Validator for the optional <c>CurrentReservation</c> building block
    /// (ReservationIdentification4, 0..1) — only invoked when present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public DeleteReservationV07Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<ReservationIdentification4> currentReservationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);

        When(
            x => x.CurrentReservation is not null,
            () => RuleFor(x => x.CurrentReservation).SetValidator(currentReservationValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>CurrentReservation</c>, and the <c>SupplementaryData</c> collection are each validated
    /// by their own default validator (<see cref="MessageHeader1Validator"/>,
    /// <see cref="ReservationIdentification4Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public DeleteReservationV07Validator()
        : this(
            new MessageHeader1Validator(),
            new ReservationIdentification4Validator(),
            new SupplementaryData1Validator()
        ) { }
}
