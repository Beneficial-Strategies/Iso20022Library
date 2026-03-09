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
[IsoId("_azKAMfo0EeCfbIXrKCjG0g")]
[DisplayName("Cash Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOption17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOption17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOption17( CreditDebitCode reqCreditDebitIndicator,CorporateActionDate23 reqDateDetails )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_azTxPfo0EeCfbIXrKCjG0g")]
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
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_azTxR_o0EeCfbIXrKCjG0g")]
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
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_bgm8Jfo0EeCfbIXrKCjG0g")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrOfferrTaxbltyInd")]
    #endif
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; init; } 
    #else
    public IssuerTaxability1Code? IssuerOfferorTaxabilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_azTxUfo0EeCfbIXrKCjG0g")]
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
    [IsoId("_azTxW_o0EeCfbIXrKCjG0g")]
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
    [IsoId("_azTxZfo0EeCfbIXrKCjG0g")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAmounts15? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAmounts15? AmountDetails { get; init; } 
    #else
    public CorporateActionAmounts15? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_azTxc_o0EeCfbIXrKCjG0g")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDate23 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDate23 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate23 DateDetails { get; init; } 
    #else
    public CorporateActionDate23 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_azTxffo0EeCfbIXrKCjG0g")]
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
    [IsoId("_azTxh_o0EeCfbIXrKCjG0g")]
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
    [IsoId("_azTxi_o0EeCfbIXrKCjG0g")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceDetails6? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceDetails6? PriceDetails { get; init; } 
    #else
    public PriceDetails6? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
