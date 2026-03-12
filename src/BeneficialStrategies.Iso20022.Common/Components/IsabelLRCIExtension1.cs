// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the LRCI protocol extension details.
/// </summary>
[IsoId("_FMiK8M_cEeWjSMe6YTKHlQ")]
[DisplayName("Isabel LRCI Extension")]
public partial record IsabelLRCIExtension1
{
    #nullable enable
    
    /// <summary>
    /// Effective method for calculating the (cryptographic) hash value of each visual representation of a payment file.
    /// </summary>
    [IsoId("_ZZE8wM_cEeWjSMe6YTKHlQ")]
    [DisplayName("Image Hash Algorithm")]
    [IsoXmlTag("ImgHashAlgo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text ImageHashAlgorithm { get; init; } 
    
    /// <summary>
    /// Block of data on which the signature is calculated by the LRCI client.
    /// </summary>
    [IsoId("_o5QGEM_cEeWjSMe6YTKHlQ")]
    [DisplayName("Token Response")]
    [IsoXmlTag("TknRspn")]
    public required IsabelEpaymentTokenResponse1 TokenResponse { get; init; } 
    
    /// <summary>
    /// Index of the payment information element containing the hash of the visual representation and the hash of the payment file relevant for this signature.
    /// </summary>
    [IsoId("_4jCeYM_cEeWjSMe6YTKHlQ")]
    [DisplayName("Token Response Payment Information Index")]
    [IsoXmlTag("TknRspnPmtInfIndx")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber TokenResponsePaymentInformationIndex { get; init; } 
    
    
    #nullable disable
    
}
