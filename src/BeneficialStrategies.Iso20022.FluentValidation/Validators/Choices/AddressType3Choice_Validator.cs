// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="AddressType3Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _CneugRb-EeiyVv5j1vf1VQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Choice of formats for the type of address.
/// <list type="table">
///   <item><term><see cref="Choices.AddressType3Choice.Code"/></term><description>Type of address expressed as a code — Value: AddressType2Code</description></item>
///   <item><term><see cref="Choices.AddressType3Choice.Proprietary"/></term><description>Type of address expressed as a proprietary code — Identification (Exact4AlphaNumericText, required), Issuer (Max35Text, required), SchemeName (Max35Text, optional)</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (the <c>Code</c> variant's
/// <c>Value</c> is a closed codeset enum; the <c>Proprietary</c> variant's fields are all
/// pattern/length-constrained <c>IIsoSimpleValue&lt;string&gt;</c> wrappers) — there is no
/// additional cross-field or business rule to add at the FluentValidation layer, so this
/// validator has no rules. It still exists as a first-class type so the coverage-scoping policy
/// (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed
/// rather than silently skipped.
/// </remarks>
public class AddressType3Choice_Validator : AbstractValidator<AddressType3Choice_> { }
