// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="AccountIdentification4Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Pdwzodp-Ed-ak6NoX_4Aeg_-1833658219
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the unique identification of an account as assigned by the account servicer.
/// <list type="table">
///   <item><term><see cref="AccountIdentification4Choice.IBAN"/></term><description>International Bank Account Number — Value: IBAN2007Identifier (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="AccountIdentification4Choice.Other"/></term><description>Unique identification of an account, as assigned by the account servicer, using an identification scheme — Identification: Max34Text (required), SchemeName: AccountSchemeName1Choice_ (optional), Issuer: Max35Text (optional)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: the <c>Other</c> variant's <c>SchemeName</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class AccountIdentification4Choice_Validator : AbstractValidator<AccountIdentification4Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Other</c> variant's <c>SchemeName</c> — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="otherSchemeNameValidator">
    /// Validator for <see cref="AccountIdentification4Choice.Other"/>'s optional <c>SchemeName</c>
    /// (AccountSchemeName1Choice_, 0..1) — only invoked when present.
    /// </param>
    public AccountIdentification4Choice_Validator(
        IValidator<AccountSchemeName1Choice_> otherSchemeNameValidator
    )
    {
        // IBAN variant: Value is fully struct-enforced (IBAN2007Identifier) — no rules needed,
        // so no InlineValidator is registered for it; SetInheritanceValidator leaves an
        // unregistered variant type as always-valid by design (see Party50Choice_Validator's own
        // remarks for the general pattern).

        var otherVariantValidator = new InlineValidator<Choices.AccountIdentification4Choice.Other>();
        // Identification, Issuer: struct-enforced scalars — no rule needed.
        otherVariantValidator
            .When(
                x => x.SchemeName is not null,
                () => otherVariantValidator.RuleFor(x => x.SchemeName).SetValidator(otherSchemeNameValidator!)
            );

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(otherVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Other</c> variant's
    /// <c>SchemeName</c> is validated by its own default validator
    /// (<see cref="AccountSchemeName1Choice_Validator"/>). Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public AccountIdentification4Choice_Validator()
        : this(new AccountSchemeName1Choice_Validator()) { }
}
