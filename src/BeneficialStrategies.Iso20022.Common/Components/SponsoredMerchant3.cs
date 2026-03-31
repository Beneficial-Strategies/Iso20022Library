// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sponsored Merchant3.
/// </summary>
[IsoId("_XjS0kW6cEe6DxcrvCrq6hQ")]
[DisplayName("Sponsored Merchant3")]
public record SponsoredMerchant3
{
    /// <summary>
    /// Additional Address.
    /// </summary>
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public IsoMax256Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<AdditionalData1> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Common Name.
    /// </summary>
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    public IsoMax140Text? CommonName { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Foreign.
    /// </summary>
    [DisplayName("Foreign")]
    [IsoXmlTag("Frgn")]
    public IsoTrueFalseIndicator? Foreign { get; init; }

    /// <summary>
    /// Geographic Location.
    /// </summary>
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Legal Corporate Name.
    /// </summary>
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData12> LocalData { get; init; } = [];

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }
}
