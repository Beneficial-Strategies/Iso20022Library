// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a currency.
/// </summary>
[IsoId("_Ycu9YGkGEeS7zPBpvm732w")]
[DisplayName("Currency Details")]
public partial record CurrencyDetails1
{
    #nullable enable
    
    /// <summary>
    /// Alpha currency code (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_izPeMGkGEeS7zPBpvm732w")]
    [DisplayName("Alpha Code")]
    [IsoXmlTag("AlphaCd")]
    public required CurrencyCode AlphaCode { get; init; } 
    
    /// <summary>
    /// Numeric currency code (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_qeujMGkGEeS7zPBpvm732w")]
    [DisplayName("Numeric Code")]
    [IsoXmlTag("NmrcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText NumericCode { get; init; } 
    
    /// <summary>
    /// Maximal number of digits after the decimal separator for the currency.
    /// </summary>
    [IsoId("_3mVSoGkGEeS7zPBpvm732w")]
    [DisplayName("Decimal")]
    [IsoXmlTag("Dcml")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Decimal { get; init; } 
    
    /// <summary>
    /// Full name of the currency.
    /// </summary>
    [IsoId("_8Ry8MGkGEeS7zPBpvm732w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    
    #nullable disable
    
}
