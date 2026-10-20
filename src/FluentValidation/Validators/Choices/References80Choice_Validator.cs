// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="IReferences80Choice"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _gLk2a4YdEe-Pv9KR9bv9IA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Choice of reference types for a securities-related allocation.
/// <list type="table">
///   <item><term><see cref="Choices.References80Choice.IAccountServicerTransactionIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.ICommonIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.ICounterpartyMarketInfrastructureTransactionIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.IIntraBalanceMovementIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.IIntraPositionMovementIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.IMarketInfrastructureTransactionIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.IOtherTransactionIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.IPoolIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.ISecuritiesSettlementTransactionIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.ITradeIdentification"/></term><description>Value: Max35Text</description></item>
///   <item><term><see cref="Choices.References80Choice.IUniqueTransactionIdentifier"/></term><description>Value: UTIIdentifier</description></item>
/// </list>
///
/// All eleven variants are fully enforced at the struct level already (every variant wraps an
/// <see cref="IIsoSimpleValue{T}"/> scalar with its own length/pattern constraint) — there is no
/// additional cross-field or business rule to add at the FluentValidation layer, so this
/// validator has no rules. It still exists as a first-class type so the coverage-scoping policy
/// (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed
/// rather than silently skipped.
/// </remarks>
public class References80Choice_Validator : AbstractValidator<IReferences80Choice> { }
