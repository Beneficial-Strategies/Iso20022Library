// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentInitiationSource1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _qBeboMQJEemsic1bQcEtLA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies the source used to initiate the payment (such as an application or a software).
/// <list type="table">
///   <item><term>Name</term><description>Max140Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>Provider</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Version</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// All fields are fully enforced at the struct level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class PaymentInitiationSource1Validator : AbstractValidator<PaymentInitiationSource1> { }
