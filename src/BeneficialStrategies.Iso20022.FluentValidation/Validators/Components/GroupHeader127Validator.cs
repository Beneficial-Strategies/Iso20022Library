// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader127"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _54NtYTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Set of characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — required (1..1); pattern enforced by struct constructor — no rule needed</description></item>
///   <item><term>SettlementInformation</term><description>SettlementInstruction15 — required (1..1)</description></item>
///   <item><term>Authorisation</term><description>Authorisation1Choice_ collection — optional, max 2 (0..2)</description></item>
///   <item><term>BatchBooking</term><description>BatchBookingIndicator — optional (0..1)</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1)</description></item>
///   <item><term>GroupReversal</term><description>TrueFalseIndicator — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InterbankSettlementDate</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>TotalReversedInterbankSettlementAmount</term><description>ActiveCurrencyAndAmount — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component itself (no "constraint" declaration rows
/// under its ISO dictionary entry) — the message-level constraints tying this component's fields
/// (<c>GroupReversal</c>, <c>InstructedAgent</c>, <c>InstructingAgent</c>,
/// <c>InterbankSettlementDate</c>, <c>NumberOfTransactions</c>,
/// <c>TotalReversedInterbankSettlementAmount</c>) to <c>TransactionInformation</c> are enforced in
/// <c>FIToFIPaymentReversalV14Validator</c>, since they depend on the message's own
/// <c>TransactionInformation</c> collection, not on anything local to this component.
///
/// Known model defect: <c>Authorisation</c> is <c>ValueList&lt;T&gt; = []</c>, which allows more
/// than 2 elements at the C# level even though the spec caps it at Max=2. Enforced here via an
/// explicit maximum-count rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// <c>TotalReversedInterbankSettlementAmount</c> is an <c>ActiveCurrencyAndAmount</c> (plain
/// record, not an <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and
/// <c>Amount</c> fields are validated inline here per the established convention (see
/// <c>PaymentTransaction137Validator</c> and <c>AmountAndDirection5Validator</c>): ISO 4217
/// three-letter currency pattern, amount greater than zero. Only checked when present (0..1).
///
/// Dependency injection: <c>SettlementInformation</c>, <c>Authorisation</c> (each item),
/// <c>InstructedAgent</c>, and <c>InstructingAgent</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class GroupHeader127Validator : AbstractValidator<GroupHeader127>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>SettlementInformation</c> building block, and every other optional
    /// building block — e.g. resolved from a DI container — instead of this type constructing its
    /// own.
    /// </summary>
    public GroupHeader127Validator(
        IValidator<SettlementInstruction15> settlementInformationValidator,
        IValidator<Authorisation1Choice_> authorisationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator
    )
    {
        RuleFor(x => x.SettlementInformation).SetValidator(settlementInformationValidator!);

        // MessageIdentification, CreationDateTime, NumberOfTransactions: required scalars,
        // format/length enforced by struct constructors — no rule needed.
        // BatchBooking, ControlSum, GroupReversal: optional scalars — no rule needed.

        RuleFor(x => x.Authorisation)
            .Must(list => list.Count <= 2)
            .WithMessage("GroupHeader127.Authorisation must not contain more than 2 element(s) (0..2).");
        RuleForEach(x => x.Authorisation).SetValidator(authorisationValidator!);

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(instructedAgentValidator!)
        );

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(instructingAgentValidator!)
        );

        When(
            x => x.TotalReversedInterbankSettlementAmount is not null,
            () =>
            {
                RuleFor(x => x.TotalReversedInterbankSettlementAmount!.Currency)
                    .NotEmpty()
                    .Matches(CurrencyRegex)
                    .WithMessage(
                        "GroupHeader127.TotalReversedInterbankSettlementAmount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
                    );

                RuleFor(x => x.TotalReversedInterbankSettlementAmount!.Amount)
                    .GreaterThan(0)
                    .WithMessage(
                        "GroupHeader127.TotalReversedInterbankSettlementAmount.Amount must be greater than zero."
                    );
            }
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public GroupHeader127Validator()
        : this(
            new SettlementInstruction15Validator(),
            new Authorisation1Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator()
        ) { }
}
