// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Document15"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wy9ZETEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information about a document.
/// <list type="table">
///   <item><term>DigitalSignature</term><description>PartyAndSignature4 — optional (0..1)</description></item>
///   <item><term>Enclosure</term><description>Max10MbBinary — required (1..1), fully struct-enforced</description></item>
///   <item><term>FileName</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Format</term><description>DocumentFormat1Choice_ — required (1..1)</description></item>
///   <item><term>Identification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>IssueDate</term><description>DateAndDateTime2Choice_ — required (1..1)</description></item>
///   <item><term>LanguageCode</term><description>LanguageCode — optional (0..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="LanguageCodeValidator"/></description></item>
///   <item><term>Name</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Type</term><description>DocumentType1Choice_ — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>DigitalSignature</c>, <c>Format</c>, <c>IssueDate</c>,
/// <c>LanguageCode</c>, and <c>Type</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
///
/// Known test-coverage gap (2026-08-21): every one of this type's nested dependencies is
/// currently unproven by the test suite's happy-path case. <c>Format</c>/<c>Type</c> dispatch to
/// choice validators (<see cref="DocumentFormat1Choice_Validator"/>,
/// <see cref="DocumentType1Choice_Validator"/>) that have no rules at all (both variants are
/// closed-enum/struct enforced); <c>DigitalSignature</c> and <c>IssueDate</c> dispatch to
/// validators with the same gap documented on their own types
/// (<see cref="PartyAndSignature4Validator"/>, <see cref="DateAndDateTime2Choice_Validator"/>);
/// and <c>LanguageCode</c> is checked against the default permissive
/// <see cref="IExternalCodeRegistry{TCode}"/>, which accepts any value. None of the
/// <c>SetValidator</c> calls below are actually proven by the current tests — a future pass
/// should add a case that populates a populated registry to prove the <c>LanguageCode</c> wiring
/// at minimum, since that is the one dependency here capable of failing at all today.
/// </remarks>
public class Document15Validator : AbstractValidator<Document15>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public Document15Validator(
        IValidator<PartyAndSignature4> digitalSignatureValidator,
        IValidator<DocumentFormat1Choice_> formatValidator,
        IValidator<DateAndDateTime2Choice_> issueDateValidator,
        IValidator<LanguageCode> languageCodeValidator,
        IValidator<DocumentType1Choice_> typeValidator
    )
    {
        When(
            x => x.DigitalSignature is not null,
            () => RuleFor(x => x.DigitalSignature).SetValidator(digitalSignatureValidator!)
        );
        RuleFor(x => x.Format).SetValidator(formatValidator!);
        RuleFor(x => x.IssueDate).SetValidator(issueDateValidator!);
        When(
            x => x.LanguageCode is not null,
            () => RuleFor(x => x.LanguageCode!.Value).SetValidator(languageCodeValidator)
        );
        RuleFor(x => x.Type).SetValidator(typeValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public Document15Validator()
        : this(
            new PartyAndSignature4Validator(),
            new DocumentFormat1Choice_Validator(),
            new DateAndDateTime2Choice_Validator(),
            new LanguageCodeValidator(),
            new DocumentType1Choice_Validator()
        ) { }
}
