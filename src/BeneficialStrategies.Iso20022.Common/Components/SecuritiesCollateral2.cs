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
[IsoId("_H9e0cWA5EeSMf75YyPqG7w")]
[DisplayName("Securities Collateral")]
public record SecuritiesCollateral2
{
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_r8auEG85EeSYoqRdI5bS5Q")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; }

    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_Ib-uUWA5EeSMf75YyPqG7w")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_Ib-uU2A5EeSMf75YyPqG7w")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateAndDateTimeChoice_? MaturityDate { get; init; }

    /// <summary>
    /// Indicates whether the collateral is proprietarily owned or client owned.
    /// </summary>
    [IsoId("_I3aVAG7-EeSo8eobdW7kLw")]
    [DisplayName("Collateral Ownership")]
    [IsoXmlTag("CollOwnrsh")]
    public CollateralOwnership1? CollateralOwnership { get; init; }

    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_iduCUGtEEeSbWPR2J8BFBg")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; }

    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    [IsoId("_Ib-uVWA5EeSMf75YyPqG7w")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Quantity blocked by the central counterparty for any reasonable reason ( for example for judicial reasons). In this case the investor can not withdraw or distribute this collateral.
    /// </summary>
    [IsoId("_Rii9AGQlEeSTN56gbbyx2g")]
    [DisplayName("Blocked Quantity")]
    [IsoXmlTag("BlckdQty")]
    public FinancialInstrumentQuantity1Choice_? BlockedQuantity { get; init; }

    /// <summary>
    /// Indicates the price of the security.
    /// </summary>
    [IsoId("_Ib-uV2A5EeSMf75YyPqG7w")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price2? Price { get; init; }

    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_Ib-uWWA5EeSMf75YyPqG7w")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_Ib-uW2A5EeSMf75YyPqG7w")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_Ib-uXWA5EeSMf75YyPqG7w")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public ActiveCurrencyAndAmount? CollateralValue { get; init; }

    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    [IsoId("_Ib-uX2A5EeSMf75YyPqG7w")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_piElcGA5EeSMf75YyPqG7w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_scV-MGA5EeSMf75YyPqG7w")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormat7Choice_ SafekeepingPlace { get; init; }
}
