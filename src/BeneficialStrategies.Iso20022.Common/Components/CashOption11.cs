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
[IsoId("_6EAzMeGhEd-1Ktb5rVaajw")]
[DisplayName("Cash Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOption11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOption11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOption11( CreditDebitCode reqCreditDebitIndicator,CorporateActionDate17 reqDateDetails )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_6EAzM-GhEd-1Ktb5rVaajw")]
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
    [IsoId("_6EAzNeGhEd-1Ktb5rVaajw")]
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
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_6EAzN-GhEd-1Ktb5rVaajw")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonElgblPrcdsInd")]
    #endif
    [IsoXmlTag("NonElgblPrcdsInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; } 
    #else
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_6EAzOeGhEd-1Ktb5rVaajw")]
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
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_6EAzO-GhEd-1Ktb5rVaajw")]
    [DisplayName("Cash Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcctId")]
    #endif
    [IsoXmlTag("CshAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_6EAzPeGhEd-1Ktb5rVaajw")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAmounts9? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAmounts9? AmountDetails { get; init; } 
    #else
    public CorporateActionAmounts9? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_6EAzP-GhEd-1Ktb5rVaajw")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDate17 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDate17 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate17 DateDetails { get; init; } 
    #else
    public CorporateActionDate17 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_6EAzQeGhEd-1Ktb5rVaajw")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_7bwPkOsgEd-b_I-JAnHTUQ")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateDetails3? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateDetails3? RateAndAmountDetails { get; init; } 
    #else
    public RateDetails3? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_5aLIm-zaEd-Z2q4-Bbm3ZA")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceDetails3? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceDetails3? PriceDetails { get; init; } 
    #else
    public PriceDetails3? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
