// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification272.
/// </summary>
[IsoId("_vtFWJTEyEe6g-ffJsqGiSA")]
public interface IPartyIdentification272 : IIsoComponent
{
    /// <summary>
    /// Contact Details.
    /// </summary>
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    IContact13? ContactDetails { get; }

    /// <summary>
    /// Country Of Residence.
    /// </summary>
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    CountryCode? CountryOfResidence { get; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IParty52Choice? Identification { get; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress27? PostalAddress { get; }
}
