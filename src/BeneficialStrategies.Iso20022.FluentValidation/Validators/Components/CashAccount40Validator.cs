// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CashAccount40"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _avXPcdcZEeqRFcf2R4bPBw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Provides the details to identify an account.
/// <list type="table">
///   <item><term>Identification</term><description>AccountIdentification4Choice_ — optional (0..1)</description></item>
///   <item><term>Type</term><description>CashAccountType2Choice_ — optional (0..1)</description></item>
///   <item><term>Currency</term><description>ActiveOrHistoricCurrencyCode — optional (0..1)</description></item>
///   <item><term>Name</term><description>Max70Text — optional (0..1)</description></item>
///   <item><term>Proxy</term><description>ProxyAccountIdentification1 — optional (0..1)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>IdentificationOrProxyPresenceRule</term>
///     <description>Identification must be present or Proxy must be present. Both may be present.</description>
///   </item>
///   <item>
///     <term>IdentificationAndProxyGuideline</term>
///     <description>
///       If the account identification is not defined through a conventional identification such
///       as an email address or a mobile number, then the proxy element should be used for the
///       identification of the account. Not independently enforceable by this library — this is
///       subjective guidance about which conventional-vs-proxy form to prefer, not a structural
///       rule; no C#-model signal distinguishes "conventional" from "proxy-worthy" identification
///       content.
///     </description>
///   </item>
/// </list>
///
/// Dependency injection: <c>Identification</c>, <c>Type</c>, and <c>Proxy</c> are each validated
/// by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c>; <c>Currency</c>
/// — an ISO 4217 <see cref="ActiveOrHistoricCurrencyCode"/> — is checked against an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> (via <see cref="ActiveOrHistoricCurrencyCodeValidator"/>)
/// — see the two constructors below.
/// </remarks>
public class CashAccount40Validator : AbstractValidator<CashAccount40>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Identification</c>, <c>Type</c>, <c>Proxy</c>, and <c>Currency</c>
    /// building blocks — e.g. resolved from a DI container — instead of this type constructing
    /// its own.
    /// </summary>
    /// <param name="identificationValidator">
    /// Validator for the optional <c>Identification</c> building block
    /// (AccountIdentification4Choice_, 0..1) — only invoked when present.
    /// </param>
    /// <param name="typeValidator">
    /// Validator for the optional <c>Type</c> building block (CashAccountType2Choice_, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="proxyValidator">
    /// Validator for the optional <c>Proxy</c> building block (ProxyAccountIdentification1, 0..1)
    /// — only invoked when present.
    /// </param>
    /// <param name="currencyValidator">
    /// Validator for the optional <c>Currency</c> (ActiveOrHistoricCurrencyCode, 0..1) — only
    /// invoked when present.
    /// </param>
    public CashAccount40Validator(
        IValidator<AccountIdentification4Choice_> identificationValidator,
        IValidator<CashAccountType2Choice_> typeValidator,
        IValidator<ProxyAccountIdentification1> proxyValidator,
        IValidator<ActiveOrHistoricCurrencyCode> currencyValidator
    )
    {
        // ── IdentificationOrProxyPresenceRule ────────────────────────────────────
        RuleFor(x => x)
            .Must(x => x.Identification is not null || x.Proxy is not null)
            .WithName("IdentificationOrProxyPresenceRule")
            .WithMessage(
                "CashAccount40: Identification must be present or Proxy must be present. Both "
                    + "may be present (IdentificationOrProxyPresenceRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────
        // Name: optional scalar, length enforced by struct constructor — no rule needed.

        When(
            x => x.Identification is not null,
            () => RuleFor(x => x.Identification).SetValidator(identificationValidator!)
        );

        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));

        When(x => x.Proxy is not null, () => RuleFor(x => x.Proxy).SetValidator(proxyValidator!));

        When(
            x => x.Currency is not null,
            () => RuleFor(x => x.Currency!.Value).SetValidator(currencyValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Identification</c>, <c>Type</c>,
    /// <c>Proxy</c>, and <c>Currency</c> are each validated by their own default validator
    /// (<see cref="AccountIdentification4Choice_Validator"/>, <see cref="CashAccountType2Choice_Validator"/>,
    /// <see cref="ProxyAccountIdentification1Validator"/>, <see cref="ActiveOrHistoricCurrencyCodeValidator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public CashAccount40Validator()
        : this(
            new AccountIdentification4Choice_Validator(),
            new CashAccountType2Choice_Validator(),
            new ProxyAccountIdentification1Validator(),
            new ActiveOrHistoricCurrencyCodeValidator()
        ) { }
}
