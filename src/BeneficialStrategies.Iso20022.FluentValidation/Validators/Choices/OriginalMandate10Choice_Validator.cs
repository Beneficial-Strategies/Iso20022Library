// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="OriginalMandate10Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yNcaETEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the mandate that is being accepted.
/// <list type="table">
///   <item><term><see cref="OriginalMandate10Choice.OriginalMandateIdentification"/></term><description>Unique identification, as assigned by the responsible party or agent, to unambiguously identify the original mandate — Value: Max35Text</description></item>
///   <item><term><see cref="OriginalMandate10Choice.OriginalMandate"/></term><description>Provides the original mandate data — Value: Mandate20</description></item>
/// </list>
///
/// <c>OriginalMandateIdentification</c>'s <c>Value</c> is fully enforced at the struct level
/// already (a length-constrained <c>IIsoSimpleValue&lt;string&gt;</c>). <c>Mandate20</c> has no
/// validator yet in this project — deep-validating the <c>OriginalMandate</c> variant is
/// out of scope for this pass; see the coverage-scoping policy in the FluentValidation project's
/// own <c>CLAUDE.md</c> for how this gets picked up in a future pass. This validator has no rules
/// of its own today for either variant.
/// </remarks>
public class OriginalMandate10Choice_Validator : AbstractValidator<OriginalMandate10Choice_> { }
