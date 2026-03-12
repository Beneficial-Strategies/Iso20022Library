// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary quantity format.
/// </summary>
[IsoId("_Qzl-KNp-Ed-ak6NoX_4Aeg_547321741")]
[DisplayName("Proprietary Quantity")]
public partial record ProprietaryQuantity3
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_Qzl-Kdp-Ed-ak6NoX_4Aeg_-1992680484")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public ShortLong1Code? ShortLongPosition { get; init; } 
    
    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    [IsoId("_Qzl-Ktp-Ed-ak6NoX_4Aeg_547321801")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Quantity { get; init; } 
    
    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    [IsoId("_QzvvINp-Ed-ak6NoX_4Aeg_547322144")]
    [DisplayName("Quantity Type")]
    [IsoXmlTag("QtyTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText QuantityType { get; init; } 
    
    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    [IsoId("_QzvvIdp-Ed-ak6NoX_4Aeg_547322179")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Issuer { get; init; } 
    
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_QzvvItp-Ed-ak6NoX_4Aeg_547322281")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SchemeName { get; init; } 
    
    
    #nullable disable
    
}
