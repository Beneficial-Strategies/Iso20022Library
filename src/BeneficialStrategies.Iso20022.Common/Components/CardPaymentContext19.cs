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
/// Context in which the transaction is performed (payment and sale).
/// </summary>
[IsoId("_ut6r0Y3PEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentContext19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_u5r28Y3PEeWjkqXgn_0Imw")]
    [DisplayName("Payment Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCntxt")]
    #endif
    [IsoXmlTag("PmtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentContext19? PaymentContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentContext19? PaymentContext { get; init; } 
    #else
    public PaymentContext19? PaymentContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_u5r2843PEeWjkqXgn_0Imw")]
    [DisplayName("Sale Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleCntxt")]
    #endif
    [IsoXmlTag("SaleCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleContext2? SaleContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleContext2? SaleContext { get; init; } 
    #else
    public SaleContext2? SaleContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
