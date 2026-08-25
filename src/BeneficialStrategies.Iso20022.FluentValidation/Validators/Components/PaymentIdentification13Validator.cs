// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentIdentification13"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _uwh3MRUHEequmIwg9GMA4Q
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Provides further means of referencing a payment transaction.
/// <list type="table">
///   <item><term>InstructionIdentification</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>EndToEndIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>TransactionIdentification</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>UETR</term><description>UUIDv4Identifier — optional (0..1); pattern enforced by struct constructor — no rule needed</description></item>
///   <item><term>ClearingSystemReference</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry). Every field is already fully enforced at its own struct level —
/// nothing left for FluentValidation to add. Empty shell exists as a first-class type per the
/// coverage-scoping policy ("reviewed and confirmed to need nothing"), same convention as
/// <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class PaymentIdentification13Validator : AbstractValidator<PaymentIdentification13> { }
