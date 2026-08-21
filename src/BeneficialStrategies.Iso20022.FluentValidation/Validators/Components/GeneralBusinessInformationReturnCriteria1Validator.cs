// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GeneralBusinessInformationReturnCriteria1"/> per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _1mEoCZlZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the criteria used to report on business information.
/// <list type="table">
///   <item><term>QualifierIndicator</term><description>RequestedIndicator — optional (0..1)</description></item>
///   <item><term>SubjectIndicator</term><description>RequestedIndicator — optional (0..1)</description></item>
///   <item><term>SubjectDetailsIndicator</term><description>RequestedIndicator — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. All three fields are boolean
/// indicators, already fully enforced at the struct level — there is no additional cross-field or
/// business rule to add at the FluentValidation layer, so this validator has no rules. It still
/// exists as a first-class type so the coverage-scoping policy (see the FluentValidation
/// project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class GeneralBusinessInformationReturnCriteria1Validator
    : AbstractValidator<GeneralBusinessInformationReturnCriteria1> { }
