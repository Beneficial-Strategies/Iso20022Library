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
[IsoId("_fQqXcW_ZEeSG8OIyyRDduA")]
[DisplayName("Other Collateral")]
public partial record OtherCollateral4
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_frvw82_ZEeSG8OIyyRDduA")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_iaZvkW_ZEeSG8OIyyRDduA")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; } 
    
    /// <summary>
    /// Provides the unique identification of the letter of credit.
    /// </summary>
    [IsoId("_frvw8W_ZEeSG8OIyyRDduA")]
    [DisplayName("Letter Of Credit Identification")]
    [IsoXmlTag("LttrOfCdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LetterOfCreditIdentification { get; init; } 
    
    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    [IsoId("_frvw9W_ZEeSG8OIyyRDduA")]
    [DisplayName("Letter Of Credit Amount")]
    [IsoXmlTag("LttrOfCdtAmt")]
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; } 
    
    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    [IsoId("_frvw92_ZEeSG8OIyyRDduA")]
    [DisplayName("Guarantee Amount")]
    [IsoXmlTag("GrntAmt")]
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; } 
    
    /// <summary>
    /// Provides a description and an amount of another type of collateral.
    /// </summary>
    [IsoId("_frvw-W_ZEeSG8OIyyRDduA")]
    [DisplayName("Other Type Of Collateral")]
    [IsoXmlTag("OthrTpOfColl")]
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; init; } 
    
    /// <summary>
    /// Date on which the other collateral was issued.
    /// </summary>
    [IsoId("_frvw-2_ZEeSG8OIyyRDduA")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public DateFormat14Choice_? IssueDate { get; init; } 
    
    /// <summary>
    /// Date on which the other collateral expires.
    /// </summary>
    [IsoId("_frvw_W_ZEeSG8OIyyRDduA")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat14Choice_? ExpiryDate { get; init; } 
    
    /// <summary>
    /// Indicates that the collateral deposited in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_frvw_2_ZEeSG8OIyyRDduA")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; } 
    
    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    [IsoId("_frvxAW_ZEeSG8OIyyRDduA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification33Choice_? Issuer { get; init; } 
    
    /// <summary>
    /// Valuation date of the other collateral when it was taken as collateral.
    /// </summary>
    [IsoId("_frvxA2_ZEeSG8OIyyRDduA")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; } 
    
    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_frvxBW_ZEeSG8OIyyRDduA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_frvxB2_ZEeSG8OIyyRDduA")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_frvxCW_ZEeSG8OIyyRDduA")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    [IsoId("_frvxC2_ZEeSG8OIyyRDduA")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; } 
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_frvxDW_ZEeSG8OIyyRDduA")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_frvxD2_ZEeSG8OIyyRDduA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    
    
    #nullable disable
    
}
