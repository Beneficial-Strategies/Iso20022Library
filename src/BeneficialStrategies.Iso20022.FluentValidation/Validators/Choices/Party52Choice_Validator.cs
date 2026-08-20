// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="Party52Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _bHNcUTFIEe651u5xu3f5iw
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the identification of a person or an organisation.
/// <list type="table">
///   <item><term><see cref="Party52Choice.OrganisationIdentification"/></term><description>Unique and unambiguous way to identify an organisation — Value: OrganisationIdentification39</description></item>
///   <item><term><see cref="Party52Choice.PrivateIdentification"/></term><description>Unique and unambiguous identification of a person, for example a passport — Value: PersonIdentification18</description></item>
/// </list>
///
/// Neither <c>OrganisationIdentification39</c> nor <c>PersonIdentification18</c> has a validator
/// yet in this project — deep-validating either variant is out of scope for this pass; see the
/// coverage-scoping policy in the FluentValidation project's own <c>CLAUDE.md</c> for how this
/// gets picked up in a future pass. This validator has no rules of its own today.
/// </remarks>
public class Party52Choice_Validator : AbstractValidator<Party52Choice_> { }
