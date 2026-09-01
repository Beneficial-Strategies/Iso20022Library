// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ExecutionType1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _75qQhqMgEeCJ6YNENx4h-w_354040007
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the type of execution to be performed in the request.
/// <list type="table">
///   <item><term><see cref="Choices.ExecutionType1Choice.Time"/></term><description>Value: ISOTime (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.ExecutionType1Choice.Event"/></term><description>Execution type is executed based on an event driven trigger — carries no properties at all, nothing to validate</description></item>
/// </list>
///
/// Both variants are fully enforced already — there is no additional cross-field or business
/// rule to add at the FluentValidation layer, so this validator has no rules. It still exists as
/// a first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class ExecutionType1Choice_Validator : AbstractValidator<ExecutionType1Choice_> { }
