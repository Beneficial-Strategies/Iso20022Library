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
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
[IsoId("_SB0r1Np-Ed-ak6NoX_4Aeg_-865361430")]
[DisplayName("Payment Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstrument8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstrument8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstrument8( string reqSettlementCurrency,PaymentCard2 reqPaymentCardDetails,DirectDebitMandate4 reqDirectDebitDetails,System.String reqCheque,System.String reqBankersDraft )
    {
        SettlementCurrency = reqSettlementCurrency;
        PaymentCardDetails = reqPaymentCardDetails;
        DirectDebitDetails = reqDirectDebitDetails;
        Cheque = reqCheque;
        BankersDraft = reqBankersDraft;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_SB0r1dp-Ed-ak6NoX_4Aeg_-865361290")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SettlementCurrency { get; init; } 
    #else
    public string SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Cash account to debit for the payment of a subscription or of a savings plan to an investment fund.
    /// </summary>
    [IsoId("_SB0r1tp-Ed-ak6NoX_4Aeg_-865360952")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctDtls")]
    #endif
    [IsoXmlTag("CshAcctDtls")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CashAccount4> CashAccountDetails { get; init; } = new ValueList<CashAccount4>(){};
    
    /// <summary>
    /// Settlement instructions for a payment by card.
    /// </summary>
    [IsoId("_SB0r19p-Ed-ak6NoX_4Aeg_-864440809")]
    [DisplayName("Payment Card Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCardDtls")]
    #endif
    [IsoXmlTag("PmtCardDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard2 PaymentCardDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentCard2 PaymentCardDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard2 PaymentCardDetails { get; init; } 
    #else
    public PaymentCard2 PaymentCardDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement instructions for a payment by direct debit.
    /// </summary>
    [IsoId("_SB0r2Np-Ed-ak6NoX_4Aeg_-865360858")]
    [DisplayName("Direct Debit Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtDtls")]
    #endif
    [IsoXmlTag("DrctDbtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DirectDebitMandate4 DirectDebitDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DirectDebitMandate4 DirectDebitDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DirectDebitMandate4 DirectDebitDetails { get; init; } 
    #else
    public DirectDebitMandate4 DirectDebitDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment is done via cheque.
    /// </summary>
    [IsoId("_SB0r2dp-Ed-ak6NoX_4Aeg_-865361256")]
    [DisplayName("Cheque")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chq")]
    #endif
    [IsoXmlTag("Chq")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Cheque { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Cheque { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Cheque { get; init; } 
    #else
    public System.String Cheque { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment is done via draft.
    /// </summary>
    [IsoId("_SB0r2tp-Ed-ak6NoX_4Aeg_-816417172")]
    [DisplayName("Bankers Draft")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkrsDrft")]
    #endif
    [IsoXmlTag("BkrsDrft")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator BankersDraft { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BankersDraft { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BankersDraft { get; init; } 
    #else
    public System.String BankersDraft { get; set; } 
    #endif
    
    
    #nullable disable
    
}
