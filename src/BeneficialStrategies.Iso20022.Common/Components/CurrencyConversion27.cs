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
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider.
/// </summary>
[IsoId("_a6LIoXDnEe2MCaKO5AtGsA")]
[DisplayName("Currency Conversion")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyConversion27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// True if the cardholder has accepted the currency conversion that the acquirer has proposed.
    /// </summary>
    [IsoId("_bA2_cXDnEe2MCaKO5AtGsA")]
    [DisplayName("Accepted By Cardholder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdByCrdhldr")]
    #endif
    [IsoXmlTag("AccptdByCrdhldr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AcceptedByCardholder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcceptedByCardholder { get; init; } 
    #else
    public System.String? AcceptedByCardholder { get; set; } 
    #endif
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a cardholder, provided by a dedicated service provider.
    /// </summary>
    [IsoId("_bA2_c3DnEe2MCaKO5AtGsA")]
    [DisplayName("Conversion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Convs")]
    #endif
    [IsoXmlTag("Convs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion26? Conversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion26? Conversion { get; init; } 
    #else
    public CurrencyConversion26? Conversion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
