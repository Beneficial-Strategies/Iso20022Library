// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party52Choice;

/// <summary>
/// Organisation Identification.
/// </summary>
public interface IOrganisationIdentification : IParty52Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// </summary>
    [IsoXmlTag("OrgId")]
    IOrganisationIdentification39 Value { get; }
}
