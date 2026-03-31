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
[IsoId("_eg72LSqUEeyR9JrVGfaMKw")]
[DisplayName("Other Collateral")]
public record OtherCollateral10
{
    /// <summary>
    /// Register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_fSaWUSqUEeyR9JrVGfaMKw")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; }

    /// <summary>
    /// Unique identification of the letter of credit.
    /// </summary>
    [IsoId("_fSaWUyqUEeyR9JrVGfaMKw")]
    [DisplayName("Letter Of Credit Identification")]
    [IsoXmlTag("LttrOfCdtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterOfCreditIdentification { get; init; }

    /// <summary>
    /// Amount of the letter/documentary credit.
    /// </summary>
    [IsoId("_fSaWVSqUEeyR9JrVGfaMKw")]
    [DisplayName("Letter Of Credit Amount")]
    [IsoXmlTag("LttrOfCdtAmt")]
    public ActiveCurrencyAndAmount? LetterOfCreditAmount { get; init; }

    /// <summary>
    /// Amount of the bank guarantee.
    /// </summary>
    [IsoId("_fSaWVyqUEeyR9JrVGfaMKw")]
    [DisplayName("Guarantee Amount")]
    [IsoXmlTag("GrntAmt")]
    public ActiveCurrencyAndAmount? GuaranteeAmount { get; init; }

    /// <summary>
    /// Description of the collateral and the amount.
    /// </summary>
    [IsoId("_fSaWWSqUEeyR9JrVGfaMKw")]
    [DisplayName("Other Type Of Collateral")]
    [IsoXmlTag("OthrTpOfColl")]
    public OtherTypeOfCollateral3? OtherTypeOfCollateral { get; init; }

    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    [IsoId("_fSaWWyqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public CollateralOwnership3? CollateralOwnership { get; init; }

    /// <summary>
    /// Date on which the collateral was issued.
    /// </summary>
    [IsoId("_fSaWXSqUEeyR9JrVGfaMKw")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public DateFormat14Choice_? IssueDate { get; init; }

    /// <summary>
    /// Date on which the collateral expires.
    /// </summary>
    [IsoId("_fSaWXyqUEeyR9JrVGfaMKw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateFormat14Choice_? ExpiryDate { get; init; }

    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_fSaWYSqUEeyR9JrVGfaMKw")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; }

    /// <summary>
    /// Party that issues the bank guarantee or letter of / documentary credit.
    /// </summary>
    [IsoId("_fSaWYyqUEeyR9JrVGfaMKw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification178Choice_? Issuer { get; init; }

    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason (for example for judicial reasons). In this case, the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_fSaWZSqUEeyR9JrVGfaMKw")]
    [DisplayName("Blocked Quantity")]
    [IsoXmlTag("BlckdQty")]
    public FinancialInstrumentQuantity33Choice_? BlockedQuantity { get; init; }

    /// <summary>
    /// Valuation date of the collateral when it was taken as collateral.
    /// </summary>
    [IsoId("_fSaWZyqUEeyR9JrVGfaMKw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Exchange rate.
    /// </summary>
    [IsoId("_fSaWaSqUEeyR9JrVGfaMKw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_fSaWayqUEeyR9JrVGfaMKw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_fSaWbSqUEeyR9JrVGfaMKw")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut, if any.
    /// </summary>
    [IsoId("_fSaWbyqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public required ActiveCurrencyAndAmount CollateralValue { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_fSaWcSqUEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat29Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_fSaWcyqUEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_PEAGoyqXEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
