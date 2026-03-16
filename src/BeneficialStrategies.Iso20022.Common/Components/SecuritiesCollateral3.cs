// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the securities posted as collateral.
/// </summary>
[IsoId("_aRPIQWQhEeSTN56gbbyx2g")]
[DisplayName("Securities Collateral")]
public record SecuritiesCollateral3
{
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_PqtUIG8GEeSo8eobdW7kLw")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; }

    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_ausgUWQhEeSTN56gbbyx2g")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_ausgU2QhEeSTN56gbbyx2g")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateAndDateTimeChoice_? MaturityDate { get; init; }

    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_HBEDcGtFEeSbWPR2J8BFBg")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; }

    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    [IsoId("_ausgVWQhEeSTN56gbbyx2g")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Indicates the price of the security.
    /// </summary>
    [IsoId("_ausgV2QhEeSTN56gbbyx2g")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price2? Price { get; init; }

    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_ausgWWQhEeSTN56gbbyx2g")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_ausgW2QhEeSTN56gbbyx2g")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_ausgXWQhEeSTN56gbbyx2g")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public ActiveCurrencyAndAmount? CollateralValue { get; init; }

    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    [IsoId("_ausgX2QhEeSTN56gbbyx2g")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ausgYWQhEeSTN56gbbyx2g")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_ausgY2QhEeSTN56gbbyx2g")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormat7Choice_ SafekeepingPlace { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_jlPDMGQhEeSTN56gbbyx2g")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails88? SettlementParameters { get; init; }
}
