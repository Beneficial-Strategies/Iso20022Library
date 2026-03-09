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
/// Provides information about the cash option.
/// </summary>
[IsoId("_UCaqltp-Ed-ak6NoX_4Aeg_-753938616")]
[DisplayName("Cash Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOption2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOption2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOption2( CreditDebitCode reqCreditDebitIndicator,CorporateActionAmounts2 reqAmountDetails,CorporateActionDate7 reqDateDetails )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        AmountDetails = reqAmountDetails;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_UCaql9p-Ed-ak6NoX_4Aeg_668542775")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    [IsoId("_UCaqmNp-Ed-ak6NoX_4Aeg_-753938307")]
    [DisplayName("Contractual Payment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctlPmtInd")]
    #endif
    [IsoXmlTag("CtrctlPmtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Payment1Code? ContractualPaymentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Payment1Code? ContractualPaymentIndicator { get; init; } 
    #else
    public Payment1Code? ContractualPaymentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_UCaqmdp-Ed-ak6NoX_4Aeg_1200049447")]
    [DisplayName("Income Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmTp")]
    #endif
    [IsoXmlTag("IncmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification20? IncomeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification20? IncomeType { get; init; } 
    #else
    public GenericIdentification20? IncomeType { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_UCaqmtp-Ed-ak6NoX_4Aeg_878844322")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account8Choice_? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account8Choice_? Account { get; init; } 
    #else
    public Account8Choice_? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about cash parties.
    /// </summary>
    [IsoId("_UCkbkNp-Ed-ak6NoX_4Aeg_-1750644328")]
    [DisplayName("Cash Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPties")]
    #endif
    [IsoXmlTag("CshPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashParties2? CashParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashParties2? CashParties { get; init; } 
    #else
    public CashParties2? CashParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_UCkbkdp-Ed-ak6NoX_4Aeg_-753937874")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionAmounts2 AmountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionAmounts2 AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAmounts2 AmountDetails { get; init; } 
    #else
    public CorporateActionAmounts2 AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_UCkbktp-Ed-ak6NoX_4Aeg_-1547777412")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDate7 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDate7 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate7 DateDetails { get; init; } 
    #else
    public CorporateActionDate7 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_UCkbk9p-Ed-ak6NoX_4Aeg_-753937844")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms11? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_UCkblNp-Ed-ak6NoX_4Aeg_1726824396")]
    [DisplayName("Generic Cash Price Received Per Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GncCshPricRcvdPerPdct")]
    #endif
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat7Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat7Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    #else
    public PriceFormat7Choice_? GenericCashPriceReceivedPerProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the tax voucher related to a cash movement.
    /// </summary>
    [IsoId("_UCkbldp-Ed-ak6NoX_4Aeg_555685721")]
    [DisplayName("Tax Voucher Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxVchrDtls")]
    #endif
    [IsoXmlTag("TaxVchrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxVoucher2? TaxVoucherDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxVoucher2? TaxVoucherDetails { get; init; } 
    #else
    public TaxVoucher2? TaxVoucherDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
