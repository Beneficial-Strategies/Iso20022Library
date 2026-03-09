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
[IsoId("_SNt2MXDkEe2MCaKO5AtGsA")]
[DisplayName("Card Payment Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentContext30
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
    [IsoId("_SU0jwXDkEe2MCaKO5AtGsA")]
    [DisplayName("Payment Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCntxt")]
    #endif
    [IsoXmlTag("PmtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentContext29? PaymentContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentContext29? PaymentContext { get; init; } 
    #else
    public PaymentContext29? PaymentContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_SU0jw3DkEe2MCaKO5AtGsA")]
    [DisplayName("Sale Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleCntxt")]
    #endif
    [IsoXmlTag("SaleCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleContext4? SaleContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleContext4? SaleContext { get; init; } 
    #else
    public SaleContext4? SaleContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the direct debit transaction.
    /// </summary>
    [IsoId("_SU0jxXDkEe2MCaKO5AtGsA")]
    [DisplayName("Direct Debit Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtCntxt")]
    #endif
    [IsoXmlTag("DrctDbtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDirectDebit2? DirectDebitContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDirectDebit2? DirectDebitContext { get; init; } 
    #else
    public CardDirectDebit2? DirectDebitContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
