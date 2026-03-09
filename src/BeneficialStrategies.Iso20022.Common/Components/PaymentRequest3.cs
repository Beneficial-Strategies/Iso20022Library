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
/// Data required to request a Payment.
/// </summary>
[IsoId("_7cH0MS83Eeu125Ip9zFcsQ")]
[DisplayName("Payment Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_7oeOIS83Eeu125Ip9zFcsQ")]
    [DisplayName("Payment Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTx")]
    #endif
    [IsoXmlTag("PmtTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction110? PaymentTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction110? PaymentTransaction { get; init; } 
    #else
    public CardPaymentTransaction110? PaymentTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_7oeOIy83Eeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyData")]
    #endif
    [IsoXmlTag("LltyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyRequestData2? LoyaltyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyRequestData2? LoyaltyData { get; init; } 
    #else
    public LoyaltyRequestData2? LoyaltyData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
