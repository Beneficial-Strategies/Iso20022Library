// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="ModifyReservationV07"/> (camt.048.001.07) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3QfUTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The ModifyReservation message is used to request modifications in the details of one
/// particular reservation set by the member and managed by the transaction administrator.
///
/// Usage
/// After receiving a ModifyReservation message, the transaction administrator checks whether the
/// amount of liquidity on the member account is sufficient to set the reservation. If there is
/// enough liquidity available, the requested amount will be reserved; if the requested amount
/// exceeds available liquidity, only the available liquidity will be reserved (the difference is
/// not blocked later, even if the balance subsequently reaches the level of the initial
/// reservation request). Directly through the member, the reservation can be reset to zero,
/// changed with immediate effect during the day, or a default amount can be input for the
/// following day(s), valid until a new reservation amount is requested.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>ReservationIdentification</term><description>CurrentOrDefaultReservation4Choice_ — required (1..1)</description></item>
///   <item><term>NewReservationValueSet</term><description>Reservation4 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, <c>ReservationIdentification</c>,
/// <c>NewReservationValueSet</c>, and the <c>SupplementaryData</c> collection are each validated
/// by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class ModifyReservationV07Validator : AbstractValidator<ModifyReservationV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every required building block and for the <c>SupplementaryData</c> collection's item
    /// type — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="reservationIdentificationValidator">
    /// Validator for the required <c>ReservationIdentification</c> building block
    /// (CurrentOrDefaultReservation4Choice_, 1..1).
    /// </param>
    /// <param name="newReservationValueSetValidator">
    /// Validator for the required <c>NewReservationValueSet</c> building block (Reservation4, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public ModifyReservationV07Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<CurrentOrDefaultReservation4Choice_> reservationIdentificationValidator,
        IValidator<Reservation4> newReservationValueSetValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleFor(x => x.ReservationIdentification).SetValidator(reservationIdentificationValidator);
        RuleFor(x => x.NewReservationValueSet).SetValidator(newReservationValueSetValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every required building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="MessageHeader1Validator"/>, <see cref="CurrentOrDefaultReservation4Choice_Validator"/>,
    /// <see cref="Reservation4Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public ModifyReservationV07Validator()
        : this(
            new MessageHeader1Validator(),
            new CurrentOrDefaultReservation4Choice_Validator(),
            new Reservation4Validator(),
            new SupplementaryData1Validator()
        ) { }
}
