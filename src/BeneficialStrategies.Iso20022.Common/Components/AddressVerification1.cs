// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric characters of the cardholder&apos;s address for verification.
/// </summary>
[IsoId("_SqbqxgEcEeCQm6a_G2yO_w_1267025270")]
[DisplayName("Address Verification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AddressVerification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Numeric characters from the cardholder&apos;s address excluding the postal code (that is street number).
    /// </summary>
    [IsoId("_SqbqxwEcEeCQm6a_G2yO_w_-502786467")]
    [DisplayName("Address Digits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrDgts")]
    #endif
    [IsoXmlTag("AdrDgts")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? AddressDigits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AddressDigits { get; init; } 
    #else
    public System.String? AddressDigits { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric characters from the cardholder&apos;s postal code.
    /// </summary>
    [IsoId("_SqbqyAEcEeCQm6a_G2yO_w_-1460020434")]
    [DisplayName("Postal Code Digits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlCdDgts")]
    #endif
    [IsoXmlTag("PstlCdDgts")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? PostalCodeDigits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostalCodeDigits { get; init; } 
    #else
    public System.String? PostalCodeDigits { get; set; } 
    #endif
    
    
    #nullable disable
    
}
