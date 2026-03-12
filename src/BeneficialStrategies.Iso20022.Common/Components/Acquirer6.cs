// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer of the card transaction.
/// </summary>
[IsoId("_WJDmUXroEeSz_of_1TY14A")]
[DisplayName("Acquirer")]
public partial record Acquirer6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer. 
    /// It correspond to the ISO 8583 field number 32.
    /// </summary>
    [IsoId("_tj2c0HroEeSz_of_1TY14A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Identification of the entity assigning the acquirer identification.
    /// </summary>
    [IsoId("_17RawHroEeSz_of_1TY14A")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; } 
    
    /// <summary>
    /// Country of the acquirer. 
    /// It correspond to the ISO 8583 field number 19.
    /// </summary>
    [IsoId("_8ujFYHroEeSz_of_1TY14A")]
    [DisplayName("Country Code")]
    [IsoXmlTag("CtryCd")]
    public ISO3NumericCountryCode? CountryCode { get; init; } 
    
    
    #nullable disable
    
}
