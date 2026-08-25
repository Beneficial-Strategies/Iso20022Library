// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OriginalGroupInformation33"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: cbf73edd-b654-4c5f-88c4-856c0c41d474
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Unique and unambiguous identifier of the group of transactions as assigned by the original
/// instructing party.
/// <list type="table">
///   <item><term>OriginalMessageIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalMessageNameIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>OriginalCreationDateTime</term><description>ISODateTime — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry). Every field is already fully enforced at its own struct level —
/// nothing left for FluentValidation to add. Empty shell exists as a first-class type per the
/// coverage-scoping policy ("reviewed and confirmed to need nothing"), same convention as
/// <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class OriginalGroupInformation33Validator : AbstractValidator<OriginalGroupInformation33> { }
