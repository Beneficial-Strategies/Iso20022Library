// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="NumberOfTransactionsPerStatus5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _-qEw2ZRuEeazAtAtDSg0Nw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Set of elements used to provide detailed information on the number of transactions that are
/// reported with a specific transaction status.
/// <list type="table">
///   <item><term>DetailedNumberOfTransactions</term><description>Max15NumericText — required (1..1), fully struct-enforced</description></item>
///   <item><term>DetailedStatus</term><description>ExternalPaymentTransactionStatus1Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>DetailedControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// All fields are fully enforced at the struct/enum level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class NumberOfTransactionsPerStatus5Validator : AbstractValidator<NumberOfTransactionsPerStatus5> { }
