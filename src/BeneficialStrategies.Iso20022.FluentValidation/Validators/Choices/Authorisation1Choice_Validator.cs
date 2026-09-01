// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="Authorisation1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _RD1Zltp-Ed-ak6NoX_4Aeg_-955120203
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Provides the details on the user identification or any user key that allows to check if the
/// initiating party is allowed to issue the transaction.
/// <list type="table">
///   <item><term><see cref="Choices.Authorisation1Choice.Code"/></term><description>Specifies the authorisation, in a coded form — Value: Authorisation1Code</description></item>
///   <item><term><see cref="Choices.Authorisation1Choice.Proprietary"/></term><description>Specifies the authorisation, in a free text form — Value: Max128Text</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (closed codeset enum / a
/// pattern-and-length-constrained <c>IIsoSimpleValue&lt;string&gt;</c>) — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class Authorisation1Choice_Validator : AbstractValidator<Authorisation1Choice_> { }
