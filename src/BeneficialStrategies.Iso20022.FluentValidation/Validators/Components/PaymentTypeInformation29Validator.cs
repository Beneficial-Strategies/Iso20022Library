// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentTypeInformation29"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _gXVWIe10Eei2O5Op8j5zpA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Provides further details of the type of payment.
/// <list type="table">
///   <item><term>InstructionPriority</term><description>Priority2Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>ServiceLevel</term><description>ServiceLevel8Choice_ collection — optional (0..n)</description></item>
///   <item><term>LocalInstrument</term><description>LocalInstrument2Choice_ — optional (0..1)</description></item>
///   <item><term>SequenceType</term><description>SequenceType3Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>CategoryPurpose</term><description>CategoryPurpose1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ServiceLevel</c>, <c>LocalInstrument</c>, and <c>CategoryPurpose</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
///
/// Note (2026-08-21): unlike the test-coverage gaps documented on several sibling validators,
/// this one isn't closable by better test data today — <see cref="ServiceLevel8Choice_Validator"/>,
/// <see cref="LocalInstrument2Choice_Validator"/>, and <see cref="CategoryPurpose1Choice_Validator"/>
/// are themselves permanently rule-less (every variant they dispatch to is fully struct/enum
/// enforced), so no input currently exists that would make them fail. If any of those three ever
/// grow a real rule, revisit this validator's tests to confirm the <c>SetValidator</c>/
/// <c>RuleForEach</c> wiring here actually surfaces it.
/// </remarks>
public class PaymentTypeInformation29Validator : AbstractValidator<PaymentTypeInformation29>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PaymentTypeInformation29Validator(
        IValidator<ServiceLevel8Choice_> serviceLevelValidator,
        IValidator<LocalInstrument2Choice_> localInstrumentValidator,
        IValidator<CategoryPurpose1Choice_> categoryPurposeValidator
    )
    {
        RuleForEach(x => x.ServiceLevel).SetValidator(serviceLevelValidator!);
        When(
            x => x.LocalInstrument is not null,
            () => RuleFor(x => x.LocalInstrument).SetValidator(localInstrumentValidator!)
        );
        When(
            x => x.CategoryPurpose is not null,
            () => RuleFor(x => x.CategoryPurpose).SetValidator(categoryPurposeValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PaymentTypeInformation29Validator()
        : this(
            new ServiceLevel8Choice_Validator(),
            new LocalInstrument2Choice_Validator(),
            new CategoryPurpose1Choice_Validator()
        ) { }
}
