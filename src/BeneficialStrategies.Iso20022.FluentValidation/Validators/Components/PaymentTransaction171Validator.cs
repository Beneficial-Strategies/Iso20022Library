// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTransaction171"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 8f5f6e58-5f38-4c81-985e-27a4edf16d5a
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further details on the original transactions, to which the status report message
/// refers.
/// <list type="table">
///   <item><term>StatusRequestIdentification</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalGroupInformation</term><description>OriginalGroupInformation33 — optional (0..1)</description></item>
///   <item><term>OriginalInstructionIdentification</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalEndToEndIdentification</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalTransactionIdentification</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalUETR</term><description>UUIDv4Identifier — optional (0..1); pattern enforced by struct constructor — no rule needed</description></item>
///   <item><term>AcceptanceDateTime</term><description>ISODateTime — optional (0..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>ClearingSystemReference</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>OriginalTransactionReference</term><description>OriginalTransactionReference47 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// No cross-field constraints found for this component itself (no "constraint" declaration rows
/// under its ISO dictionary entry) — the message-level rules governing when
/// <c>OriginalGroupInformation</c> must/must not be present here are enforced in
/// <c>FIToFIPaymentStatusRequestV07Validator</c>, since they depend on the message's own
/// <c>OriginalGroupInformation</c> collection, not on anything local to this component.
///
/// Dependency injection: <c>OriginalGroupInformation</c>, <c>InstructingAgent</c>,
/// <c>InstructedAgent</c>, <c>OriginalTransactionReference</c>, and <c>SupplementaryData</c> are
/// each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> —
/// see the two constructors below.
/// </remarks>
public class PaymentTransaction171Validator : AbstractValidator<PaymentTransaction171>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for every optional building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    public PaymentTransaction171Validator(
        IValidator<OriginalGroupInformation33> originalGroupInformationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator,
        IValidator<OriginalTransactionReference47> originalTransactionReferenceValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        // StatusRequestIdentification, OriginalInstructionIdentification,
        // OriginalEndToEndIdentification, OriginalTransactionIdentification,
        // ClearingSystemReference: Max35Text, optional — length enforced by struct constructor,
        // no rule needed.
        // OriginalUETR: UUIDv4Identifier, optional — pattern enforced by struct constructor, no rule needed.
        // AcceptanceDateTime: ISODateTime, optional — lexical form enforced by struct constructor, no rule needed.

        When(
            x => x.OriginalGroupInformation is not null,
            () => RuleFor(x => x.OriginalGroupInformation).SetValidator(originalGroupInformationValidator!)
        );

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(instructingAgentValidator!)
        );

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(instructedAgentValidator!)
        );

        When(
            x => x.OriginalTransactionReference is not null,
            () => RuleFor(x => x.OriginalTransactionReference).SetValidator(originalTransactionReferenceValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentTransaction171Validator()
        : this(
            new OriginalGroupInformation33Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new OriginalTransactionReference47Validator(),
            new SupplementaryData1Validator()
        ) { }
}
