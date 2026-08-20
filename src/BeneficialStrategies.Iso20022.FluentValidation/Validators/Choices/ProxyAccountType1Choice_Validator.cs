// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ProxyAccountType1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _dyock3h3EeidzqjNEfehPg
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the scheme used for the identification of an account alias.
/// <list type="table">
///   <item><term><see cref="ProxyAccountType1Choice.Code"/></term><description>Specifies the proxy account type, as published in an external proxy account type code list — Value: ExternalProxyAccountType1Code</description></item>
///   <item><term><see cref="ProxyAccountType1Choice.Proprietary"/></term><description>Specifies a character string with a maximum length of 35 characters — Value: Max35Text</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (a closed codeset enum / an
/// <c>IIsoExternalCode</c> pattern-constrained wrapper, or a length-constrained
/// <c>IIsoSimpleValue&lt;string&gt;</c>) — there is no additional cross-field or business rule to
/// add at the FluentValidation layer, so this validator has no rules. It still exists as a
/// first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class ProxyAccountType1Choice_Validator : AbstractValidator<ProxyAccountType1Choice_> { }
