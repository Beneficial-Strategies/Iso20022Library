// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric characters of the cardholder&apos;s address for verification.
/// </summary>
[IsoId("_SqbqxgEcEeCQm6a_G2yO_w_1267025270")]
[DisplayName("Address Verification")]
public partial record AddressVerification1
{
    #nullable enable
    
    /// <summary>
    /// Numeric characters from the cardholder&apos;s address excluding the postal code (that is street number).
    /// </summary>
    [IsoId("_SqbqxwEcEeCQm6a_G2yO_w_-502786467")]
    [DisplayName("Address Digits")]
    [IsoXmlTag("AdrDgts")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? AddressDigits { get; init; } 
    
    /// <summary>
    /// Numeric characters from the cardholder&apos;s postal code.
    /// </summary>
    [IsoId("_SqbqyAEcEeCQm6a_G2yO_w_-1460020434")]
    [DisplayName("Postal Code Digits")]
    [IsoXmlTag("PstlCdDgts")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    public IsoMax5NumericText? PostalCodeDigits { get; init; } 
    
    
    #nullable disable
    
}
