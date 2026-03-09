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
/// Card transaction details.
/// </summary>
[IsoId("_bafQEdcZEeqRFcf2R4bPBw")]
[DisplayName("Card Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransaction18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
    /// </summary>
    [IsoId("_bb0FwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Card")]
    #endif
    [IsoXmlTag("Card")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCard4? Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard4? Card { get; init; } 
    #else
    public PaymentCard4? Card { get; set; } 
    #endif
    
    /// <summary>
    /// Physical or logical card payment terminal containing software and hardware components.
    /// </summary>
    [IsoId("_bb0Fw9cZEeqRFcf2R4bPBw")]
    [DisplayName("POI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POI")]
    #endif
    [IsoXmlTag("POI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction1? POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction1? POI { get; init; } 
    #else
    public PointOfInteraction1? POI { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction details, which can be either globalised by the acquirer or individual transaction.
    /// </summary>
    [IsoId("_bb0FxdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardTransaction3Choice_? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransaction3Choice_? Transaction { get; init; } 
    #else
    public CardTransaction3Choice_? Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Prepaid account for the transfer or loading of an amount of money.
    /// </summary>
    [IsoId("_bb0Fx9cZEeqRFcf2R4bPBw")]
    [DisplayName("Pre Paid Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrePdAcct")]
    #endif
    [IsoXmlTag("PrePdAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? PrePaidAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? PrePaidAccount { get; init; } 
    #else
    public CashAccount40? PrePaidAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
