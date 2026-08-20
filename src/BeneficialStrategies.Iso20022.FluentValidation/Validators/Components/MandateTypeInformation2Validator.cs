// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateTypeInformation2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _cm369kjwEeaVLL5QKJ4f-A
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of elements used to further detail the information related to the type of payment.
/// <list type="table">
///   <item><term>ServiceLevel</term><description>ServiceLevel8Choice_ — optional (0..1)</description></item>
///   <item><term>LocalInstrument</term><description>LocalInstrument2Choice_ — optional (0..1)</description></item>
///   <item><term>CategoryPurpose</term><description>CategoryPurpose1Choice_ — optional (0..1)</description></item>
///   <item><term>Classification</term><description>MandateClassification1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ServiceLevel</c>, <c>LocalInstrument</c>, <c>CategoryPurpose</c>, and
/// <c>Classification</c> are each validated by an injected <see cref="IValidator{T}"/> rather
/// than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class MandateTypeInformation2Validator : AbstractValidator<MandateTypeInformation2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>ServiceLevel</c>, <c>LocalInstrument</c>, <c>CategoryPurpose</c>, and
    /// <c>Classification</c> building blocks — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="serviceLevelValidator">
    /// Validator for the optional <c>ServiceLevel</c> building block (ServiceLevel8Choice_,
    /// 0..1) — only invoked when present.
    /// </param>
    /// <param name="localInstrumentValidator">
    /// Validator for the optional <c>LocalInstrument</c> building block (LocalInstrument2Choice_,
    /// 0..1) — only invoked when present.
    /// </param>
    /// <param name="categoryPurposeValidator">
    /// Validator for the optional <c>CategoryPurpose</c> building block (CategoryPurpose1Choice_,
    /// 0..1) — only invoked when present.
    /// </param>
    /// <param name="classificationValidator">
    /// Validator for the optional <c>Classification</c> building block
    /// (MandateClassification1Choice_, 0..1) — only invoked when present.
    /// </param>
    public MandateTypeInformation2Validator(
        IValidator<ServiceLevel8Choice_> serviceLevelValidator,
        IValidator<LocalInstrument2Choice_> localInstrumentValidator,
        IValidator<CategoryPurpose1Choice_> categoryPurposeValidator,
        IValidator<MandateClassification1Choice_> classificationValidator
    )
    {
        When(
            x => x.ServiceLevel is not null,
            () => RuleFor(x => x.ServiceLevel).SetValidator(serviceLevelValidator!)
        );

        When(
            x => x.LocalInstrument is not null,
            () => RuleFor(x => x.LocalInstrument).SetValidator(localInstrumentValidator!)
        );

        When(
            x => x.CategoryPurpose is not null,
            () => RuleFor(x => x.CategoryPurpose).SetValidator(categoryPurposeValidator!)
        );

        When(
            x => x.Classification is not null,
            () => RuleFor(x => x.Classification).SetValidator(classificationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>ServiceLevel</c>,
    /// <c>LocalInstrument</c>, <c>CategoryPurpose</c>, and <c>Classification</c> are each
    /// validated by their own default validator (<see cref="ServiceLevel8Choice_Validator"/>,
    /// <see cref="LocalInstrument2Choice_Validator"/>, <see cref="CategoryPurpose1Choice_Validator"/>,
    /// <see cref="MandateClassification1Choice_Validator"/>). Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public MandateTypeInformation2Validator()
        : this(
            new ServiceLevel8Choice_Validator(),
            new LocalInstrument2Choice_Validator(),
            new CategoryPurpose1Choice_Validator(),
            new MandateClassification1Choice_Validator()
        ) { }
}
