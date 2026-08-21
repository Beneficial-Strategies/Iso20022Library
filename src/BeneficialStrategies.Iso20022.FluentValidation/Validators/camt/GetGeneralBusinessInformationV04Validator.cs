// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="GetGeneralBusinessInformationV04"/> (camt.020.001.04) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _jwlbfxbvEeiyVv5j1vf1VQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The GetGeneralBusinessInformation message is sent by a member to the transaction
/// administrator. It is used to request information on a broadcast-type message previously sent
/// by the transaction administrator to all or some of the members, giving information related to
/// the processing business.
///
/// Usage
/// The transaction administrator can send general business information messages to the members,
/// which may request further action from them — either static data announcing foreseen events,
/// or dynamic data warning or notifying about unexpected events. Non-solicited reports are pushed
/// with a reference, a qualifier, and a subject line; this message is the "pull" counterpart,
/// used by a member to query for the full text/content of a report previously sent, based on its
/// reference, subject, priority/format, and details. This message is replied to by a
/// ReturnGeneralBusinessInformation message.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>GeneralBusinessInformationQueryDefinition</term><description>BusinessInformationQueryDefinition3 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, the optional
/// <c>GeneralBusinessInformationQueryDefinition</c> building block, and the optional
/// <c>SupplementaryData</c> building block are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class GetGeneralBusinessInformationV04Validator : AbstractValidator<GetGeneralBusinessInformationV04>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> building block and the optional
    /// <c>GeneralBusinessInformationQueryDefinition</c>/<c>SupplementaryData</c> building blocks —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="generalBusinessInformationQueryDefinitionValidator">
    /// Validator for the optional <c>GeneralBusinessInformationQueryDefinition</c> building block
    /// (BusinessInformationQueryDefinition3, 0..1) — only invoked when present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for the optional <c>SupplementaryData</c> building block (SupplementaryData1,
    /// 0..1) — only invoked when present.
    /// </param>
    public GetGeneralBusinessInformationV04Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<BusinessInformationQueryDefinition3> generalBusinessInformationQueryDefinitionValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);

        When(
            x => x.GeneralBusinessInformationQueryDefinition is not null,
            () =>
                RuleFor(x => x.GeneralBusinessInformationQueryDefinition)
                    .SetValidator(generalBusinessInformationQueryDefinitionValidator!)
        );
        When(
            x => x.SupplementaryData is not null,
            () => RuleFor(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>GeneralBusinessInformationQueryDefinition</c>, and <c>SupplementaryData</c> are each
    /// validated by their own default validator (<see cref="MessageHeader1Validator"/>,
    /// <see cref="BusinessInformationQueryDefinition3Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public GetGeneralBusinessInformationV04Validator()
        : this(
            new MessageHeader1Validator(),
            new BusinessInformationQueryDefinition3Validator(),
            new SupplementaryData1Validator()
        ) { }
}
