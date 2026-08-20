// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader110"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _xWwCoTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Set of characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1)</description></item>
///   <item><term>Authorisation</term><description>Authorisation1Choice_ — optional (0..2 per XSD; not enforceable via <c>ValueList&lt;T&gt;</c>, no compile-time bound)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Authorisation</c> collection, <c>InitiatingParty</c>, and both
/// agent building blocks are each validated by an injected <see cref="IValidator{T}"/> rather
/// than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class GroupHeader110Validator : AbstractValidator<GroupHeader110>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Authorisation</c> collection's item type, the optional <c>InitiatingParty</c>
    /// building block, and the optional <c>InstructingAgent</c>/<c>InstructedAgent</c> building
    /// blocks — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="authorisationValidator">
    /// Validator for each item of the <c>Authorisation</c> collection (Authorisation1Choice_, 0..∞).
    /// </param>
    /// <param name="initiatingPartyValidator">
    /// Validator for the optional <c>InitiatingParty</c> building block (PartyIdentification272,
    /// 0..1) — only invoked when present.
    /// </param>
    /// <param name="agentValidator">
    /// Validator for the optional <c>InstructingAgent</c> and <c>InstructedAgent</c> building
    /// blocks (both BranchAndFinancialInstitutionIdentification8, 0..1) — only invoked when
    /// present. Both properties share the same validated type, so one injected validator serves
    /// both.
    /// </param>
    public GroupHeader110Validator(
        IValidator<Authorisation1Choice_> authorisationValidator,
        IValidator<PartyIdentification272> initiatingPartyValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator
    )
    {
        // MessageIdentification, CreationDateTime: required (1..1) and already `required` C#
        // properties — length/format enforced by struct constructors.

        RuleForEach(x => x.Authorisation).SetValidator(authorisationValidator);

        When(
            x => x.InitiatingParty is not null,
            () => RuleFor(x => x.InitiatingParty).SetValidator(initiatingPartyValidator!)
        );

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(agentValidator!)
        );

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(agentValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Authorisation</c>
    /// collection, <c>InitiatingParty</c>, and both agent building blocks are each validated by
    /// their own default validator (<see cref="Authorisation1Choice_Validator"/>,
    /// <see cref="PartyIdentification272Validator"/>,
    /// <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public GroupHeader110Validator()
        : this(
            new Authorisation1Choice_Validator(),
            new PartyIdentification272Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator()
        ) { }
}
