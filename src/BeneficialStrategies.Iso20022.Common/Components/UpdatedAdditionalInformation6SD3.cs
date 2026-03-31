// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for additional information.
/// </summary>
[IsoId("_FWA4v2CUEeK8P92abE6HIA")]
[DisplayName("Updated Additional Information 6 SD")]
public record UpdatedAdditionalInformation6SD3
{
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance.
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_FWA4y2CUEeK8P92abE6HIA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Specifies the securities account to be credited.
    /// 会社法制の見直し要綱の、22ページ第３－１－①をご参照ください。.
    /// </summary>
    [IsoId("_lYWXUGCVEeK8P92abE6HIA")]
    [DisplayName("Securities Credit Account Identification")]
    [IsoXmlTag("SctiesCdtAcctId")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? SecuritiesCreditAccountIdentification { get; init; }

    /// <summary>
    /// ISIN of Offeror&apos;s share when the corporate action event type code is TEND.
    /// </summary>
    [IsoId("_48yLQGxREeK_SqccejsxHw")]
    [DisplayName("Offeror Share")]
    [IsoXmlTag("OfferrShr")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public IsoISINIdentifier? OfferorShare { get; init; }

    /// <summary>
    /// Local code of Offeror&apos;s share when the corporate action event type code is TEND.
    /// 買付者 銘柄コード.
    /// </summary>
    [IsoId("_48yLQ2xREeK_SqccejsxHw")]
    [DisplayName("Offeror Share Local Code")]
    [IsoXmlTag("OfferrShrLclCd")]
    [IsoSimpleType(IsoSimpleType.Max5AlphaNumericText)]
    [StringLength(maximumLength: 5, MinimumLength = 1)]
    public IsoMax5AlphaNumericText? OfferorShareLocalCode { get; init; }

    /// <summary>
    /// Name in the local language by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_48yLRmxREeK_SqccejsxHw")]
    [DisplayName("Local Language Name")]
    [IsoXmlTag("LclLangNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240, MinimumLength = 1)]
    public IsoMax240Text? LocalLanguageName { get; init; }
}
