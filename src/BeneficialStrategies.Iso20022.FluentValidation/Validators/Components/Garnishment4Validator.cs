// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Garnishment4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _v9i0ETEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides remittance information about a payment for garnishment-related purposes.
/// <list type="table">
///   <item><term>Date</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>EmployeeTerminationIndicator</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>FamilyMedicalInsuranceIndicator</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Garnishee</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>GarnishmentAdministrator</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>ReferenceNumber</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RemittedAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>Type</term><description>GarnishmentType1 — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Garnishee</c>/<c>GarnishmentAdministrator</c> and <c>Type</c> are
/// each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c>
/// — the same <see cref="PartyIdentification272"/> validator instance is reused across
/// <c>Garnishee</c> and <c>GarnishmentAdministrator</c> — see the two constructors below.
/// </remarks>
public class Garnishment4Validator : AbstractValidator<Garnishment4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public Garnishment4Validator(
        IValidator<PartyIdentification272> partyValidator,
        IValidator<GarnishmentType1> typeValidator
    )
    {
        When(x => x.Garnishee is not null, () => RuleFor(x => x.Garnishee).SetValidator(partyValidator!));
        When(
            x => x.GarnishmentAdministrator is not null,
            () => RuleFor(x => x.GarnishmentAdministrator).SetValidator(partyValidator!)
        );
        RuleFor(x => x.Type).SetValidator(typeValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public Garnishment4Validator()
        : this(new PartyIdentification272Validator(), new GarnishmentType1Validator()) { }
}
