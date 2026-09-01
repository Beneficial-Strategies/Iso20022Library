// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="RequestType4Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _ivV-XZIhEeect698_YsnIA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the type of action to be performed in the request.
/// <list type="table">
///   <item><term><see cref="Choices.RequestType4Choice.PaymentControl"/></term><description>Value: ExternalPaymentControlRequestType1Code (closed enum, fully enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.RequestType4Choice.Enquiry"/></term><description>Value: ExternalEnquiryRequestType1Code (closed enum, fully enforced, no further rule needed)</description></item>
///   <item><term><see cref="Choices.RequestType4Choice.Proprietary"/></term><description>Identification, SchemeName, Issuer — all Max35Text, fully struct-enforced, no further rule needed</description></item>
/// </list>
///
/// All three variants are fully enforced at the struct/enum level already — there is no
/// additional cross-field or business rule to add at the FluentValidation layer, so this
/// validator has no rules. It still exists as a first-class type so the coverage-scoping policy
/// (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed
/// rather than silently skipped.
/// </remarks>
public class RequestType4Choice_Validator : AbstractValidator<RequestType4Choice_> { }
