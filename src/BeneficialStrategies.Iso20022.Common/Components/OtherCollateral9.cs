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
/// Provides details about the letter of credit or bank guarantee, or other collateral, posted as collateral.
/// </summary>
[IsoId("_fNt5ASqTEeyR9JrVGfaMKw")]
[DisplayName("Other Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherCollateral9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherCollateral9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherCollateral9( ActiveCurrencyAndAmount reqCollateralValue )
    {
        CollateralValue = reqCollateralValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_f6RdASqTEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollId")]
    #endif
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralIdentification { get; init; } 
    #else
    public System.String? CollateralIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the unique identification of the letter of credit.
    /// </summary>
    [IsoId("_f6RdAyqTEeyR9JrVGfaMKw")]
    [DisplayName("Letter Of Credit Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfCdtId")]
    #endif
    [IsoXmlTag("LttrOfCdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LetterOfCreditIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LetterOfCreditIdentification { get; init; } 
    #else
    public System.String? LetterOfCreditIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    [IsoId("_f6RdBSqTEeyR9JrVGfaMKw")]
    [DisplayName("Letter Of Credit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LttrOfCdtAmt")]
    #endif
    [IsoXmlTag("LttrOfCdtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    [IsoId("_f6RdByqTEeyR9JrVGfaMKw")]
    [DisplayName("Guarantee Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrntAmt")]
    #endif
    [IsoXmlTag("GrntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a description and an amount of another type of collateral.
    /// </summary>
    [IsoId("_f6RdCSqTEeyR9JrVGfaMKw")]
    [DisplayName("Other Type Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTpOfColl")]
    #endif
    [IsoXmlTag("OthrTpOfColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherTypeOfCollateral3? OtherTypeOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherTypeOfCollateral3? OtherTypeOfCollateral { get; init; } 
    #else
    public OtherTypeOfCollateral3? OtherTypeOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the other collateral was issued.
    /// </summary>
    [IsoId("_f6RdCyqTEeyR9JrVGfaMKw")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat14Choice_? IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat14Choice_? IssueDate { get; init; } 
    #else
    public DateFormat14Choice_? IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the other collateral expires.
    /// </summary>
    [IsoId("_f6RdDSqTEeyR9JrVGfaMKw")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    #else
    public DateFormat14Choice_? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the collateral deposited in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_f6RdDyqTEeyR9JrVGfaMKw")]
    [DisplayName("Limited Coverage Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdCvrgInd")]
    #endif
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedCoverageIndicator { get; init; } 
    #else
    public System.String? LimitedCoverageIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    [IsoId("_f6RdESqTEeyR9JrVGfaMKw")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification178Choice_? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification178Choice_? Issuer { get; init; } 
    #else
    public PartyIdentification178Choice_? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation date of the other collateral when it was taken as collateral.
    /// </summary>
    [IsoId("_f6RdEyqTEeyR9JrVGfaMKw")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_f6RdFSqTEeyR9JrVGfaMKw")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_f6RdFyqTEeyR9JrVGfaMKw")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_f6RdGSqTEeyR9JrVGfaMKw")]
    [DisplayName("Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hrcut")]
    #endif
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Haircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Haircut { get; init; } 
    #else
    public System.Decimal? Haircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    [IsoId("_f6RdGyqTEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollVal")]
    #endif
    [IsoXmlTag("CollVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount CollateralValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount CollateralValue { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_f6RdHSqTEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_f6RdHyqTEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_g4G-QyqTEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckChainAdrOrWllt")]
    #endif
    [IsoXmlTag("BlckChainAdrOrWllt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; } 
    #else
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
