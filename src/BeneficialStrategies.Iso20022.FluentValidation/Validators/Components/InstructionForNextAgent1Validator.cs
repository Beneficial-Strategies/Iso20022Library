// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="InstructionForNextAgent1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _TOHf0dp-Ed-ak6NoX_4Aeg_1118639475
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Further information related to the processing of the payment instruction that may need to be
/// acted upon by an other agent. The instruction may relate to a level of service, or may be an
/// instruction that has to be executed by the creditor's agent, or may be information required by
/// the other agent.
/// <list type="table">
///   <item><term>Code</term><description>Instruction4Code — optional (0..1); closed enum, no rule needed</description></item>
///   <item><term>InstructionInformation</term><description>Max140Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry). Every field is already fully enforced at its own struct/enum level —
/// nothing left for FluentValidation to add. Empty shell exists as a first-class type per the
/// coverage-scoping policy ("reviewed and confirmed to need nothing"), same convention as
/// <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class InstructionForNextAgent1Validator : AbstractValidator<InstructionForNextAgent1> { }
