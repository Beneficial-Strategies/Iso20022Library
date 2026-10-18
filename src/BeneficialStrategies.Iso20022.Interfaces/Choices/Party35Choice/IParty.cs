// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.Party35Choice;

/// <summary>
/// Identification of a person or an organisation.
/// </summary>
[IsoId("_mm7Z07TREeeyuKckOGlwuA")]
public interface IParty : IParty35Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_jzRC069UEeeJJK1oRb-jTw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    Max140Text? Name { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_jzRp4a9UEeeJJK1oRb-jTw")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress6? PostalAddress { get; }

    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_jzRp469UEeeJJK1oRb-jTw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IParty34Choice? Identification { get; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_jzRp5a9UEeeJJK1oRb-jTw")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    CountryCode? CountryOfResidence { get; }

    /// <summary>
    /// Set of elements used to indicate how to contact the party.
    /// </summary>
    [IsoId("_jzRp569UEeeJJK1oRb-jTw")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    IContactDetails2? ContactDetails { get; }
}
