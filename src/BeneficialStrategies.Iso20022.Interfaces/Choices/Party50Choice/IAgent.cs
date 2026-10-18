// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party50Choice;

/// <summary>
/// Agent.
/// </summary>
public interface IAgent : IParty50Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("Agt")]
    IBranchAndFinancialInstitutionIdentification8 Value { get; }
}
