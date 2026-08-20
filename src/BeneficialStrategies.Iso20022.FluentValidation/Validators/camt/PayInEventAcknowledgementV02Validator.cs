// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="PayInEventAcknowledgementV02"/> (camt.063.001.02) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _eii_URnXEeKKXqHkeUjBbw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// The PayInEventAcknowledgement message is sent by a participant of a central system to the
/// central system to confirm a PayInSchedule or a PayInCall has been received.
///
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>SettlementSessionIdentifier</term><description>Exact4AlphaNumericText — optional (0..1)</description></item>
///   <item><term>AcknowledgementDetails</term><description>AcknowledgementDetails1Choice_ — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>AcknowledgementDetails</c> and the optional <c>SupplementaryData</c>
/// building block are each validated by an injected <see cref="IValidator{T}"/> rather than a
/// hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class PayInEventAcknowledgementV02Validator : AbstractValidator<PayInEventAcknowledgementV02>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>AcknowledgementDetails</c> building block and the optional
    /// <c>SupplementaryData</c> building block — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="acknowledgementDetailsValidator">
    /// Validator for the required <c>AcknowledgementDetails</c> building block
    /// (AcknowledgementDetails1Choice_, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for the optional <c>SupplementaryData</c> building block (SupplementaryData1,
    /// 0..1) — only invoked when present.
    /// </param>
    public PayInEventAcknowledgementV02Validator(
        IValidator<AcknowledgementDetails1Choice_> acknowledgementDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        // MessageIdentification: required (1..1) and already a `required` C# property — format
        // enforced by the struct constructor.
        // SettlementSessionIdentifier: optional scalar, format enforced by the struct constructor
        // — no rule needed.

        RuleFor(x => x.AcknowledgementDetails).SetValidator(acknowledgementDetailsValidator);

        When(
            x => x.SupplementaryData is not null,
            () => RuleFor(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>AcknowledgementDetails</c> and
    /// <c>SupplementaryData</c> are each validated by their own default validator
    /// (<see cref="AcknowledgementDetails1Choice_Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public PayInEventAcknowledgementV02Validator()
        : this(new AcknowledgementDetails1Choice_Validator(), new SupplementaryData1Validator()) { }
}
