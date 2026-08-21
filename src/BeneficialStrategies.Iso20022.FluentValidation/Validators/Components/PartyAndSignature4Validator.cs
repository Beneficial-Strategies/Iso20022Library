// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PartyAndSignature4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _w1V-sTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Entity involved in an activity.
/// <list type="table">
///   <item><term>Party</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>Signature</term><description>SkipPayload — required (1..1), an empty placeholder record (no properties) with nothing further to validate structurally</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Party</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
///
/// Known test-coverage gap (2026-08-21): <see cref="PartyIdentification272"/> has no required
/// fields, and the test suite's happy-path case supplies only a <c>Name</c> — nothing that would
/// trigger any of <see cref="PartyIdentification272Validator"/>'s conditional rules. That test
/// therefore produces zero validation errors whether or not the
/// <c>RuleFor(x => x.Party).SetValidator(...)</c> line below is actually present — it does not
/// prove this dependency is wired. A future pass should add a case that populates a nested field
/// (e.g. postal address country) with a value a populated <see cref="IExternalCodeRegistry{TCode}"/>
/// would reject, to close this gap.
/// </remarks>
public class PartyAndSignature4Validator : AbstractValidator<PartyAndSignature4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public PartyAndSignature4Validator(IValidator<PartyIdentification272> partyValidator)
    {
        RuleFor(x => x.Party).SetValidator(partyValidator!);
        // Signature: SkipPayload — nothing further to validate structurally.
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public PartyAndSignature4Validator()
        : this(new PartyIdentification272Validator()) { }
}
