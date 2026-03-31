// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the letter of credit or bank guarantee, or other collateral, posted as collateral.
/// </summary>
[IsoId("_Yy_0kV9_EeSMgPeFpRHeJw")]
[DisplayName("Other Collateral")]
public record OtherCollateral2
{
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_dSzFAG8HEeSo8eobdW7kLw")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; }

    /// <summary>
    /// Provides the unique identification of the letter of credit.
    /// </summary>
    [IsoId("_Z1A_wGtHEeSbWPR2J8BFBg")]
    [DisplayName("Letter Of Credit Identification")]
    [IsoXmlTag("LttrOfCdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterOfCreditIdentification { get; init; }

    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    [IsoId("_ZO008V9_EeSMgPeFpRHeJw")]
    [DisplayName("Letter Of Credit Amount")]
    [IsoXmlTag("LttrOfCdtAmt")]
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; }

    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    [IsoId("_ZO00819_EeSMgPeFpRHeJw")]
    [DisplayName("Guarantee Amount")]
    [IsoXmlTag("GrntAmt")]
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; }

    /// <summary>
    /// Provides a description and an amount of another type of collateral.
    /// </summary>
    [IsoId("_ZO009V9_EeSMgPeFpRHeJw")]
    [DisplayName("Other Type Of Collateral")]
    [IsoXmlTag("OthrTpOfColl")]
    public OtherTypeOfCollateral2? OtherTypeOfCollateral { get; init; }

    /// <summary>
    /// Date on which the other collateral was issued.
    /// </summary>
    [IsoId("_ZO00919_EeSMgPeFpRHeJw")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public DateFormat14Choice_? IssueDate { get; init; }

    /// <summary>
    /// Date on which the other collateral expires.
    /// </summary>
    [IsoId("_ZO00-V9_EeSMgPeFpRHeJw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat14Choice_? ExpiryDate { get; init; }

    /// <summary>
    /// Indicates that the collateral deposited in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_SrSO4GtFEeSbWPR2J8BFBg")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; }

    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    [IsoId("_ZO00-19_EeSMgPeFpRHeJw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification33Choice_? Issuer { get; init; }

    /// <summary>
    /// Valuation date of the other collateral when it was taken as collateral.
    /// </summary>
    [IsoId("_ZO00_V9_EeSMgPeFpRHeJw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_ZO00_19_EeSMgPeFpRHeJw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_ZO01AV9_EeSMgPeFpRHeJw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_ZO01A19_EeSMgPeFpRHeJw")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    [IsoId("_ZO01BV9_EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_Bfb6UGA2EeSMf75YyPqG7w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_VW3XwGA2EeSMf75YyPqG7w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }
}
