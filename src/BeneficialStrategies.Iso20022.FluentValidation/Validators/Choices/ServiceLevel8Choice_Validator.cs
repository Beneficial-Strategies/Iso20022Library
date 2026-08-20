// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ServiceLevel8Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QJa_zNp-Ed-ak6NoX_4Aeg_1912716963
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the service level of the transaction.
/// <list type="table">
///   <item><term><see cref="ServiceLevel8Choice.Code"/></term><description>Specifies a pre-agreed service or level of service between the parties, as published in an external service level code list — Value: ExternalServiceLevel1Code</description></item>
///   <item><term><see cref="ServiceLevel8Choice.Proprietary"/></term><description>Specifies a character string with a maximum length of 35 characters — Value: Max35Text</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (a closed codeset enum / an
/// <c>IIsoExternalCode</c> pattern-constrained wrapper, or a length-constrained
/// <c>IIsoSimpleValue&lt;string&gt;</c>) — there is no additional cross-field or business rule to
/// add at the FluentValidation layer, so this validator has no rules. It still exists as a
/// first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class ServiceLevel8Choice_Validator : AbstractValidator<ServiceLevel8Choice_> { }
