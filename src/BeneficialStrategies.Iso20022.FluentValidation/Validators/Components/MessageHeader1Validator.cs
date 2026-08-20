// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MessageHeader1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _75DzkaMgEeCJ6YNENx4h-w_-613853819
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of characteristics, such as the identification or the creation date and time, specific to
/// the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. Both fields are already fully
/// enforced at the struct level — there is no additional cross-field or business rule to add at
/// the FluentValidation layer, so this validator has no rules. It still exists as a first-class
/// type so the coverage-scoping policy (see the FluentValidation project's own <c>CLAUDE.md</c>)
/// can record this type as reviewed rather than silently skipped.
/// </remarks>
public class MessageHeader1Validator : AbstractValidator<MessageHeader1> { }
