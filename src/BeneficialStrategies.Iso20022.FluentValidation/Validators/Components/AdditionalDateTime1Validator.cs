// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AdditionalDateTime1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _e2UX0G9ZEe-Mlpx0N5T4gg
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Series of additional dates related to the payment.
/// <list type="table">
///   <item><term>AcceptanceDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>ExpiryDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>PoolingAdjustmentDate</term><description>ISODate — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry — no ordering rule between the three dates is specified). All fields
/// are already fully enforced at their own struct level (lexical form parsing) — nothing left for
/// FluentValidation to add. Empty shell exists as a first-class type per the coverage-scoping
/// policy ("reviewed and confirmed to need nothing"), same convention as
/// <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class AdditionalDateTime1Validator : AbstractValidator<AdditionalDateTime1> { }
