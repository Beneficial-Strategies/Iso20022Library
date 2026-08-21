// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="StructuredRegulatoryReporting5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _F6fyAXeKEfCdoODv2ypKfw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information needed due to regulatory and statutory requirements.
/// <list type="table">
///   <item><term>Type</term><description>RegulatoryReportingType1Choice_ — optional (0..1)</description></item>
///   <item><term>Date</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Country</term><description>CountryCode — optional (0..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="CountryCodeValidator"/></description></item>
///   <item><term>ReportingCode</term><description>Max10Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Amount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption (see <see cref="AmountType4Choice_Validator"/>'s own remarks)</description></item>
///   <item><term>Information</term><description>Max35Text collection — optional (0..n), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Type</c> and <c>Country</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
///
/// Known test-coverage gap (2026-08-21): the test suite's happy-path case uses the
/// <c>Proprietary</c> variant for <c>Type</c> (no failure mode) and checks <c>Country</c>
/// against the default permissive <see cref="IExternalCodeRegistry{TCode}"/>, which accepts any
/// value — so neither <c>SetValidator</c> call below is proven wired at this level. A future
/// pass should add a case with a populated registry to close this gap.
/// </remarks>
public class StructuredRegulatoryReporting5Validator : AbstractValidator<StructuredRegulatoryReporting5>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public StructuredRegulatoryReporting5Validator(
        IValidator<RegulatoryReportingType1Choice_> typeValidator,
        IValidator<CountryCode> countryValidator
    )
    {
        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
        When(
            x => x.Country is not null,
            () => RuleFor(x => x.Country!.Value).SetValidator(countryValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public StructuredRegulatoryReporting5Validator()
        : this(new RegulatoryReportingType1Choice_Validator(), new CountryCodeValidator()) { }
}
