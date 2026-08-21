// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentIdentification6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _xnoxwXrgEeidVZmeoasaWQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Provides further means of referencing a payment transaction.
/// <list type="table">
///   <item><term>InstructionIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>EndToEndIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>UETR</term><description>UUIDv4Identifier — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// All fields are fully enforced at the struct level already — there is no additional cross-field
/// or business rule to add at the FluentValidation layer, so this validator has no rules. It
/// still exists as a first-class type so the coverage-scoping policy (see the FluentValidation
/// project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class PaymentIdentification6Validator : AbstractValidator<PaymentIdentification6> { }
