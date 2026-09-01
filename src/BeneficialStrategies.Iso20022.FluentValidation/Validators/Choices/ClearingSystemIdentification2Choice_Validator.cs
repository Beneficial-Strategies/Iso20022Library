// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ClearingSystemIdentification2Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _TMoSENp-Ed-ak6NoX_4Aeg_-1410917193
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Choice of a clearing system identifier.
/// <list type="table">
///   <item><term><see cref="Choices.ClearingSystemIdentification2Choice.Code"/></term><description>Identification of a clearing system, in a coded form as published in an external list — Value: ExternalClearingSystemIdentification1Code</description></item>
///   <item><term><see cref="Choices.ClearingSystemIdentification2Choice.Proprietary"/></term><description>Identification code for a clearing system not yet identified in the external list — Value: Max35Text</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (an <c>IIsoExternalCode</c>
/// pattern-constrained wrapper / a length-constrained <c>IIsoSimpleValue&lt;string&gt;</c>) —
/// there is no additional cross-field or business rule to add at the FluentValidation layer, so
/// this validator has no rules. It still exists as a first-class type so the coverage-scoping
/// policy (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as
/// reviewed rather than silently skipped.
/// </remarks>
public class ClearingSystemIdentification2Choice_Validator
    : AbstractValidator<ClearingSystemIdentification2Choice_> { }
