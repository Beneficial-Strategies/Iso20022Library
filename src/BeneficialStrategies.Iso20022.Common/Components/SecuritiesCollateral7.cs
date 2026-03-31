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
[IsoId("_13SJ44FvEeWtPe6Crjmeug")]
[DisplayName("Securities Collateral")]
public record SecuritiesCollateral7
{
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    [IsoId("_2NKTIYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; }

    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    [IsoId("_2NKTI4FvEeWtPe6Crjmeug")]
    [DisplayName("Asset Number")]
    [IsoXmlTag("AsstNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssetNumber { get; init; }

    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_2NKTJYFvEeWtPe6Crjmeug")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification19 SecurityIdentification { get; init; }

    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    [IsoId("_2NKTJ4FvEeWtPe6Crjmeug")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public DateAndDateTimeChoice_? MaturityDate { get; init; }

    /// <summary>
    /// Indicates that the collateral posted in the clearing house covers the margin until a specific timeframe.
    /// </summary>
    [IsoId("_2NKTKYFvEeWtPe6Crjmeug")]
    [DisplayName("Limited Coverage Indicator")]
    [IsoXmlTag("LtdCvrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LimitedCoverageIndicator { get; init; }

    /// <summary>
    /// Quantity of securities collateral.
    /// </summary>
    [IsoId("_2NKTK4FvEeWtPe6Crjmeug")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; }

    /// <summary>
    /// Indicates the price of the security.
    /// </summary>
    [IsoId("_2NKTLYFvEeWtPe6Crjmeug")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public Price2? Price { get; init; }

    /// <summary>
    /// Value of the collateral based on current market prices.
    /// </summary>
    [IsoId("_2NKTL4FvEeWtPe6Crjmeug")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public ActiveCurrencyAndAmount? MarketValue { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_2NKTMYFvEeWtPe6Crjmeug")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; }

    /// <summary>
    /// Value of the collateral after taking into account the haircut.
    /// </summary>
    [IsoId("_2NKTM4FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Value")]
    [IsoXmlTag("CollVal")]
    public ActiveCurrencyAndAmount? CollateralValue { get; init; }

    /// <summary>
    /// Valuation date of the securities taken as collateral.
    /// </summary>
    [IsoId("_2NKTNYFvEeWtPe6Crjmeug")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_2NKTN4FvEeWtPe6Crjmeug")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_2NKTOYFvEeWtPe6Crjmeug")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public required SafekeepingPlaceFormat10Choice_ SafekeepingPlace { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_2NKTO4FvEeWtPe6Crjmeug")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails102? SettlementParameters { get; init; }
}
