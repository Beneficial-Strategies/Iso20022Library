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
[IsoId("_cfsEl5KQEeWHWpTQn1FFVg")]
[DisplayName("Proprietary Quantity")]
public partial record ProprietaryQuantity10
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_cfsEmZKQEeWHWpTQn1FFVg")]
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public ShortLong1Code? ShortLongPosition { get; init; } 
    
    /// <summary>
    /// Provides the proprietary quantity with a decimal number.
    /// </summary>
    [IsoId("_cfsEm5KQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
    
    /// <summary>
    /// Identifies the type of proprietary quantity reported.
    /// </summary>
    [IsoId("_cfsEnZKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity Type")]
    [IsoXmlTag("QtyTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public required IsoExact4AlphaNumericText QuantityType { get; init; } 
    
    /// <summary>
    /// Provides information related to issuer in free format.
    /// </summary>
    [IsoId("_cfsEn5KQEeWHWpTQn1FFVg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText Issuer { get; init; } 
    
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_cfsEp5KQEeWHWpTQn1FFVg")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4AlphaNumericText? SchemeName { get; init; } 
    
    
    #nullable disable
    
}
