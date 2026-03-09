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
[IsoId("_L6ZvITQJEe2o-K1dwNg8Gg")]
[DisplayName("Cash Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOption83
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOption83 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOption83( CreditDebitCode reqCreditDebitIndicator,CorporateActionDate84 reqDateDetails )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        DateDetails = reqDateDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_MRNFnTQJEe2o-K1dwNg8Gg")]
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
    /// Specifies exceptions to contractual payment service.
    /// </summary>
    [IsoId("_MRNFpTQJEe2o-K1dwNg8Gg")]
    [DisplayName("Contractual Payment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctlPmtInd")]
    #endif
    [IsoXmlTag("CtrctlPmtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Payment2Code? ContractualPaymentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Payment2Code? ContractualPaymentIndicator { get; init; } 
    #else
    public Payment2Code? ContractualPaymentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_MRNFpzQJEe2o-K1dwNg8Gg")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonElgblPrcdsInd")]
    #endif
    [IsoXmlTag("NonElgblPrcdsInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; } 
    #else
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_MRNFrzQJEe2o-K1dwNg8Gg")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrOfferrTaxbltyInd")]
    #endif
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; } 
    #else
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of income.
    /// </summary>
    [IsoId("_MRNFsTQJEe2o-K1dwNg8Gg")]
    [DisplayName("Income Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmTp")]
    #endif
    [IsoXmlTag("IncmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? IncomeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? IncomeType { get; init; } 
    #else
    public GenericIdentification30? IncomeType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of income to be used under another tax regime.
    /// </summary>
    [IsoId("_MRNFuTQJEe2o-K1dwNg8Gg")]
    [DisplayName("Other Income Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrIncmTp")]
    #endif
    [IsoXmlTag("OthrIncmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? OtherIncomeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? OtherIncomeType { get; init; } 
    #else
    public GenericIdentification30? OtherIncomeType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_MRNFuzQJEe2o-K1dwNg8Gg")]
    [DisplayName("Exemption Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnTp")]
    #endif
    [IsoXmlTag("XmptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? ExemptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? ExemptionType { get; init; } 
    #else
    public GenericIdentification30? ExemptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_MRNFvTQJEe2o-K1dwNg8Gg")]
    [DisplayName("Country Of Income Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfIncmSrc")]
    #endif
    [IsoXmlTag("CtryOfIncmSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfIncomeSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfIncomeSource { get; init; } 
    #else
    public string? CountryOfIncomeSource { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_MRNFvzQJEe2o-K1dwNg8Gg")]
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
    [IsoId("_MRNFxzQJEe2o-K1dwNg8Gg")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAmounts54? AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAmounts54? AmountDetails { get; init; } 
    #else
    public CorporateActionAmounts54? AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_MRNFzzQJEe2o-K1dwNg8Gg")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDate84 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDate84 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate84 DateDetails { get; init; } 
    #else
    public CorporateActionDate84 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_MRNF1zQJEe2o-K1dwNg8Gg")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_MRNF3zQJEe2o-K1dwNg8Gg")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate36? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate36? RateAndAmountDetails { get; init; } 
    #else
    public Rate36? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_MRNF4TQJEe2o-K1dwNg8Gg")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceDetails31? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceDetails31? PriceDetails { get; init; } 
    #else
    public PriceDetails31? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
