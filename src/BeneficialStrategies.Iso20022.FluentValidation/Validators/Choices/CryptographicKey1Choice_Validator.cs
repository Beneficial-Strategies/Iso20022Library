// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="CryptographicKey1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: __lk0wD6wEe-QZYT2pcGFZw
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Choice of cryptographic key representations.
/// <list type="table">
///   <item><term><see cref="Choices.CryptographicKey1Choice.ILPV4"/></term><description>Value: HexBinaryText</description></item>
///   <item><term><see cref="Choices.CryptographicKey1Choice.Signature"/></term><description>Value: SHA256SignatureText</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (both wrap
/// <see cref="IIsoSimpleValue{T}"/> binary/text types with their own format constraints) — there
/// is no additional cross-field or business rule to add at the FluentValidation layer, so this
/// validator has no rules. It still exists as a first-class type so the coverage-scoping policy
/// (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed
/// rather than silently skipped.
/// </remarks>
public class CryptographicKey1Choice_Validator : AbstractValidator<CryptographicKey1Choice_> { }
