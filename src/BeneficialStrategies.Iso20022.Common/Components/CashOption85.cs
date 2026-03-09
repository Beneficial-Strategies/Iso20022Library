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
[IsoId("_qRi3QTQKEe2o-K1dwNg8Gg")]
[DisplayName("Cash Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOption85
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOption85 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOption85( CreditDebitCode reqCreditDebitIndicator,CorporateActionAmounts56 reqAmountDetails,CorporateActionDate87 reqDateDetails )
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
    [IsoId("_qpF0mzQKEe2o-K1dwNg8Gg")]
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
    [IsoId("_qpF0ozQKEe2o-K1dwNg8Gg")]
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
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_qpF0qzQKEe2o-K1dwNg8Gg")]
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
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_qpF0rTQKEe2o-K1dwNg8Gg")]
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
    [IsoId("_qpF0tTQKEe2o-K1dwNg8Gg")]
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
    [IsoId("_qpF0tzQKEe2o-K1dwNg8Gg")]
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
    [IsoId("_qpF0uTQKEe2o-K1dwNg8Gg")]
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
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_qpF0uzQKEe2o-K1dwNg8Gg")]
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
    [IsoId("_qpF0wzQKEe2o-K1dwNg8Gg")]
    [DisplayName("Cash Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshPties")]
    #endif
    [IsoXmlTag("CshPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashParties34? CashParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashParties34? CashParties { get; init; } 
    #else
    public CashParties34? CashParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_qpF0yzQKEe2o-K1dwNg8Gg")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionAmounts56 AmountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionAmounts56 AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAmounts56 AmountDetails { get; init; } 
    #else
    public CorporateActionAmounts56 AmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_qpF00zQKEe2o-K1dwNg8Gg")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionDate87 DateDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionDate87 DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate87 DateDetails { get; init; } 
    #else
    public CorporateActionDate87 DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_qpF02zQKEe2o-K1dwNg8Gg")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; } 
    #else
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the tax voucher related to a cash movement.
    /// </summary>
    [IsoId("_qpF04zQKEe2o-K1dwNg8Gg")]
    [DisplayName("Tax Voucher Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxVchrDtls")]
    #endif
    [IsoXmlTag("TaxVchrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxVoucher4? TaxVoucherDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxVoucher4? TaxVoucherDetails { get; init; } 
    #else
    public TaxVoucher4? TaxVoucherDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_qpF06zQKEe2o-K1dwNg8Gg")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate35? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate35? RateAndAmountDetails { get; init; } 
    #else
    public Rate35? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_qpF07TQKEe2o-K1dwNg8Gg")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceDetails32? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceDetails32? PriceDetails { get; init; } 
    #else
    public PriceDetails32? PriceDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
