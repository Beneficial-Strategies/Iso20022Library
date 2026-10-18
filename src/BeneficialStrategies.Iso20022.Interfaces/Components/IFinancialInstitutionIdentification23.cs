// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Institution Identification23.
/// </summary>
[IsoId("_v2tzSTEyEe6g-ffJsqGiSA")]
public interface IFinancialInstitutionIdentification23 : IIsoComponent
{
    /// <summary>
    /// BICFI.
    /// </summary>
    [DisplayName("BICFI")]
    [IsoXmlTag("BICFI")]
    IsoBICFIDec2014Identifier? BICFI { get; }

    /// <summary>
    /// Clearing System Member Identification.
    /// </summary>
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    IClearingSystemMemberIdentification2? ClearingSystemMemberIdentification { get; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    IsoLEIIdentifier? LEI { get; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    IsoMax140Text? Name { get; }

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    IGenericFinancialIdentification1? Other { get; }

    /// <summary>
    /// Postal Address.
    /// </summary>
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    IPostalAddress27? PostalAddress { get; }
}
