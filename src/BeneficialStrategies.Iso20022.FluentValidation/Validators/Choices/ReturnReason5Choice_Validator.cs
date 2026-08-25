// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ReturnReason5Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _TP6Pkdp-Ed-ak6NoX_4Aeg_-1676326037
/// Spec source: queried via ISO 20022 MCP server (2026-08-26).
///
/// Specifies the reason for the return of the transaction.
/// <list type="table">
///   <item><term>Code</term><description>ExternalReturnReason1Code — self-validating IIsoExternalCode struct, no rule needed</description></item>
///   <item><term>Proprietary</term><description>Max35Text — self-validating IIsoSimpleValue struct, no rule needed</description></item>
/// </list>
///
/// Both variants wrap a single scalar value already fully enforced at the struct level — nothing
/// left for FluentValidation to add, per the empty-validator convention (see
/// <c>AddressType3Choice_Validator</c>).
/// </remarks>
public class ReturnReason5Choice_Validator : AbstractValidator<ReturnReason5Choice_> { }
