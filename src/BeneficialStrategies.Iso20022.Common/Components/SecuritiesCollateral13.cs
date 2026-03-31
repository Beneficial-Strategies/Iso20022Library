// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a security posted as collateral.
/// </summary>
[IsoId("_M3VawSqXEeyR9JrVGfaMKw")]
[DisplayName("Securities Collateral")]
public record SecuritiesCollateral13
{
    /// <summary>
    /// Register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_NnK8QSqXEeyR9JrVGfaMKw")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; }

    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_NnK8QyqXEeyR9JrVGfaMKw")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification19 SecurityIdentification { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_NnK8RSqXEeyR9JrVGfaMKw")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateAndDateTime2Choice_? MaturityDate { get; init; }

    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    [IsoId("_NnK8RyqXEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public CollateralOwnership3? CollateralOwnership { get; init; }

    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_NnK8SSqXEeyR9JrVGfaMKw")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; }

    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    [IsoId("_NnK8SyqXEeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; }

    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_NnK8TSqXEeyR9JrVGfaMKw")]
    [DisplayName("Blocked Quantity")]
    [IsoXmlTag("BlckdQty")]
    public FinancialInstrumentQuantity33Choice_? BlockedQuantity { get; init; }

    /// <summary>
    /// Price of the security.
    /// </summary>
    [IsoId("_NnK8TyqXEeyR9JrVGfaMKw")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price7? Price { get; init; }

    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_NnK8USqXEeyR9JrVGfaMKw")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_NnK8UyqXEeyR9JrVGfaMKw")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_NnK8VSqXEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public ActiveCurrencyAndAmount? CollateralValue { get; init; }

    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    [IsoId("_NnK8VyqXEeyR9JrVGfaMKw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_NnK8WSqXEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_LlFIsyqXEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_NnK8WyqXEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormat29Choice_ SafekeepingPlace { get; init; }
}
