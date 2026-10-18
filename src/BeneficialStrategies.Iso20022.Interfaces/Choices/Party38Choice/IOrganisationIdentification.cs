// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party38Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_6VWvQ248EeiU9cctagi5ow")]
public interface IOrganisationIdentification : IParty38Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Business identification code of the organisation.
    /// </summary>
    [IsoId("_6emK0248EeiU9cctagi5ow")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    IsoAnyBICDec2014Identifier? AnyBIC { get; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_XzdQ4XRwEeiH1ZOt2UD8vQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    IsoLEIIdentifier? LEI { get; }

    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_6emK1W48EeiU9cctagi5ow")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericOrganisationIdentification1? Other { get; }
}
