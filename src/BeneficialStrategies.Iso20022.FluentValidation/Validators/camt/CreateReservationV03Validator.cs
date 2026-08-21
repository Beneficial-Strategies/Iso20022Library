// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="CreateReservationV03"/> (camt.103.001.03) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3GuUzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The CreateReservation message is used to request the creation of one particular reservation
/// by the member and managed by the transaction administrator.
///
/// Usage
/// Based on the criteria defined in the CreateReservation message, the transaction administrator
/// will execute or reject the requested creation and respond with a Receipt message as a reply to
/// the request.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>ReservationIdentification</term><description>ReservationIdentification4 — required (1..1)</description></item>
///   <item><term>ValueSet</term><description>Reservation4 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, <c>ReservationIdentification</c>, <c>ValueSet</c>,
/// and the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class CreateReservationV03Validator : AbstractValidator<CreateReservationV03>
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
    /// (ReservationIdentification4, 1..1).
    /// </param>
    /// <param name="valueSetValidator">
    /// Validator for the required <c>ValueSet</c> building block (Reservation4, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public CreateReservationV03Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<ReservationIdentification4> reservationIdentificationValidator,
        IValidator<Reservation4> valueSetValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleFor(x => x.ReservationIdentification).SetValidator(reservationIdentificationValidator);
        RuleFor(x => x.ValueSet).SetValidator(valueSetValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every required building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="MessageHeader1Validator"/>, <see cref="ReservationIdentification4Validator"/>,
    /// <see cref="Reservation4Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public CreateReservationV03Validator()
        : this(
            new MessageHeader1Validator(),
            new ReservationIdentification4Validator(),
            new Reservation4Validator(),
            new SupplementaryData1Validator()
        ) { }
}
