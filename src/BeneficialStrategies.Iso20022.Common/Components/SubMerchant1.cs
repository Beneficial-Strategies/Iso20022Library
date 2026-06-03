// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant using the payment services of the card acceptor. The submerchant is not acting as the card acceptor.
/// </summary>
[IsoId("_FraPARTjEfC_aaedwHHlmw")]
[DisplayName("Sub Merchant1")]
public record SubMerchant1
{
    [IsoId("_FyXyoRTjEfC_aaedwHHlmw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    [IsoId("_FyXyoxTjEfC_aaedwHHlmw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax35Text? Assigner { get; init; }

    [IsoId("_FyXypRTjEfC_aaedwHHlmw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    [IsoId("_FyXyqxTjEfC_aaedwHHlmw")]
    [DisplayName("Foreign")]
    [IsoXmlTag("Frgn")]
    public IsoMax3Text? Foreign { get; init; }

    [IsoId("_FyXyrRTjEfC_aaedwHHlmw")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax140Text? BusinessName { get; init; }

    [IsoId("_FyXyrxTjEfC_aaedwHHlmw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    [IsoId("_FyXysRTjEfC_aaedwHHlmw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    [IsoId("_FyXyuxTjEfC_aaedwHHlmw")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public IsoGeographicPointInDecimalDegreesText? GeographicLocation { get; init; }

    [IsoId("_TvldUl6CEfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_TvldU16CEfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    [IsoId("_FyXyvxTjEfC_aaedwHHlmw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];
}
