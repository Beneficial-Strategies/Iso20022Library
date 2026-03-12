// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the letter of credit or bank guarantee, or other collateral, posted as collateral.
/// </summary>
[IsoId("_010s3YFvEeWtPe6Crjmeug")]
[DisplayName("Other Collateral")]
public partial record OtherCollateral6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_1LjFIYFvEeWtPe6Crjmeug")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; } 
    
    /// <summary>
    /// Provides the unique identification of the letter of credit.
    /// </summary>
    [IsoId("_1LjFI4FvEeWtPe6Crjmeug")]
    [DisplayName("Letter Of Credit Identification")]
    [IsoXmlTag("LttrOfCdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LetterOfCreditIdentification { get; init; } 
    
    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    [IsoId("_1LjFJYFvEeWtPe6Crjmeug")]
    [DisplayName("Letter Of Credit Amount")]
    [IsoXmlTag("LttrOfCdtAmt")]
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    
    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    [IsoId("_1LjFJ4FvEeWtPe6Crjmeug")]
    [DisplayName("Guarantee Amount")]
    [IsoXmlTag("GrntAmt")]
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    
    /// <summary>
    /// Provides a description and an amount of another type of collateral.
    /// </summary>
    [IsoId("_1LjFKYFvEeWtPe6Crjmeug")]
    [DisplayName("Other Type Of Collateral")]
    [IsoXmlTag("OthrTpOfColl")]
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    [IsoId("_1LjFK4FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public CollateralOwnership2? CollateralOwnership { get; init; } 
    
    /// <summary>
    /// Date on which the other collateral was issued.
    /// </summary>
    [IsoId("_1LjFLYFvEeWtPe6Crjmeug")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public DateFormat14Choice_? IssueDate { get; init; } 
    
    /// <summary>
    /// Date on which the other collateral expires.
    /// </summary>
    [IsoId("_1LjFL4FvEeWtPe6Crjmeug")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_1LjFMYFvEeWtPe6Crjmeug")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    
    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    [IsoId("_1LjFM4FvEeWtPe6Crjmeug")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification100Choice_? Issuer { get; init; } 
    
    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_1LjFNYFvEeWtPe6Crjmeug")]
    [DisplayName("Blocked Quantity")]
    [IsoXmlTag("BlckdQty")]
    public FinancialInstrumentQuantity1Choice_? BlockedQuantity { get; init; } 
    
    /// <summary>
    /// Valuation date of the other collateral when it was taken as collateral.
    /// </summary>
    [IsoId("_1LjFN4FvEeWtPe6Crjmeug")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_1LjFOYFvEeWtPe6Crjmeug")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_1LjFO4FvEeWtPe6Crjmeug")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_1LjFPYFvEeWtPe6Crjmeug")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    [IsoId("_1LjFP4FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_1LjFQYFvEeWtPe6Crjmeug")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_1LjFQ4FvEeWtPe6Crjmeug")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    
    #nullable disable
    
}
