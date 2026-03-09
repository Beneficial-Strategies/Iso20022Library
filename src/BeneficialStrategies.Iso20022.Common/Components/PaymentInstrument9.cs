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
[IsoId("_SBq61dp-Ed-ak6NoX_4Aeg_473679007")]
[DisplayName("Payment Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstrument9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstrument9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstrument9( string reqSettlementCurrency,Cheque4 reqChequeDetails,Cheque4 reqBankersDraftDetails )
    {
        SettlementCurrency = reqSettlementCurrency;
        ChequeDetails = reqChequeDetails;
        BankersDraftDetails = reqBankersDraftDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_SBq61tp-Ed-ak6NoX_4Aeg_473679025")]
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
    /// Cash account to credit for the payment of the dividends or of the redeemed investments funds.
    /// </summary>
    [IsoId("_SBq619p-Ed-ak6NoX_4Aeg_473679501")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctDtls")]
    #endif
    [IsoXmlTag("CshAcctDtls")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<CashAccount4> CashAccountDetails { get; init; } = new ValueList<CashAccount4>(){};
    
    /// <summary>
    /// Settlement instructions for a payment by cheque.
    /// </summary>
    [IsoId("_SBq62Np-Ed-ak6NoX_4Aeg_473679595")]
    [DisplayName("Cheque Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqDtls")]
    #endif
    [IsoXmlTag("ChqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cheque4 ChequeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Cheque4 ChequeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cheque4 ChequeDetails { get; init; } 
    #else
    public Cheque4 ChequeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement instructions for a payment by draft.
    /// </summary>
    [IsoId("_SB0r0Np-Ed-ak6NoX_4Aeg_530938893")]
    [DisplayName("Bankers Draft Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkrsDrftDtls")]
    #endif
    [IsoXmlTag("BkrsDrftDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cheque4 BankersDraftDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Cheque4 BankersDraftDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cheque4 BankersDraftDetails { get; init; } 
    #else
    public Cheque4 BankersDraftDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
