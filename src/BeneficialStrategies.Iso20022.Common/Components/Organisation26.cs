// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Merchant performing the transaction.
/// </summary>
[IsoId("__V4_MY0VEeWRYffwL7E13A")]
[DisplayName("Organisation")]
public partial record Organisation26
{
    #nullable enable
    
    /// <summary>
    /// Name of the merchant.
    /// </summary>
    [IsoId("__hDtY40VEeWRYffwL7E13A")]
    [DisplayName("Common Name")]
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text CommonName { get; init; } 
    
    /// <summary>
    /// Location of the merchant.
    /// </summary>
    [IsoId("_o5JP4I0WEeWRYffwL7E13A")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Address { get; init; } 
    
    /// <summary>
    /// Country of the merchant.
    /// </summary>
    [IsoId("_sv7UMI0WEeWRYffwL7E13A")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public required ISO3NumericCountryCode CountryCode { get; init; } 
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_xl7Z0I0WEeWRYffwL7E13A")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    
    /// <summary>
    /// Identifier of the sponsored merchant assigned by the payment facilitator of their acquirer.
    /// </summary>
    [IsoId("_1yBm0I0WEeWRYffwL7E13A")]
    [DisplayName("Registered Identifier")]
    [IsoXmlTag("RegdIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RegisteredIdentifier { get; init; } 
    
    
    #nullable disable
    
}
