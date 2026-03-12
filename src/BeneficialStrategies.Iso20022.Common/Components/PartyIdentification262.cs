// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_2bH-AR1REey8XKHwKquEQw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification262
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_2ibf4R1REey8XKHwKquEQw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    [IsoId("_2ibf4x1REey8XKHwKquEQw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; } 
    
    /// <summary>
    /// Country of the party.
    /// </summary>
    [IsoId("_2ibf5R1REey8XKHwKquEQw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 
    
    /// <summary>
    /// Short name of the party.
    /// </summary>
    [IsoId("_2ibf5x1REey8XKHwKquEQw")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Additional identification of the party.
    /// </summary>
    [IsoId("_2ibf6R1REey8XKHwKquEQw")]
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    
    /// <summary>
    /// Identify when the sponsored merchant is not located in the same country as the marketplace or sponsor.
    /// </summary>
    [IsoId("_ep0PgB1SEey8XKHwKquEQw")]
    [DisplayName("Foreign Merchant")]
    [IsoXmlTag("FrgnMrchnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ForeignMerchant { get; init; } 
    
    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_2ibf6x1REey8XKHwKquEQw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData1? LocalData { get; init; } 
    
    
    #nullable disable
    
}
