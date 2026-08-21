// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="InstructionForCreditorAgent3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _PRQQx8QAEemsic1bQcEtLA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Further information related to the processing of the payment instruction that may need to be
/// acted upon by the creditor's agent. The instruction may relate to a level of service, or may
/// be an instruction that has to be executed by the creditor's agent, or may be information
/// required by the creditor's agent.
/// <list type="table">
///   <item><term>Code</term><description>ExternalCreditorAgentInstruction1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>InstructionInformation</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// Both fields are fully enforced at the struct/enum level already — there is no additional
/// cross-field or business rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class InstructionForCreditorAgent3Validator : AbstractValidator<InstructionForCreditorAgent3> { }
