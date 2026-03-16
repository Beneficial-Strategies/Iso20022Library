// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_6HnzQe34Eeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption180
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_6vMwp-34Eeqc-LCjwLsUVg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_6vMwr-34Eeqc-LCjwLsUVg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption40Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_6vMwt-34Eeqc-LCjwLsUVg")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_6vMwue34Eeqc-LCjwLsUVg")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType28Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_6vMwwe34Eeqc-LCjwLsUVg")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat6Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Indicates that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_6vMwye34Eeqc-LCjwLsUVg")]
    [DisplayName("Eligible For Collateral Indicator")]
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; }

    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    [IsoId("_eXg2AO5_Eeqc-LCjwLsUVg")]
    [DisplayName("Solicitation Dealer Fee Indicator")]
    [IsoXmlTag("SlctnDealrFeeInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_6vMw0e34Eeqc-LCjwLsUVg")]
    [DisplayName("Currency To Buy")]
    [IsoXmlTag("CcyToBuy")]
    public ActiveCurrencyCode? CurrencyToBuy { get; init; }

    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_6vMw2e34Eeqc-LCjwLsUVg")]
    [DisplayName("Currency To Sell")]
    [IsoXmlTag("CcyToSell")]
    public ActiveCurrencyCode? CurrencyToSell { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_6vMw4e34Eeqc-LCjwLsUVg")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_6vMw6e34Eeqc-LCjwLsUVg")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification19? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_6vMw8e34Eeqc-LCjwLsUVg")]
    [DisplayName("Securities Quantity Or Instructed Amount")]
    [IsoXmlTag("SctiesQtyOrInstdAmt")]
    public required SecuritiesQuantityOrAmount4Choice_ SecuritiesQuantityOrInstructedAmount { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_6vMw-e34Eeqc-LCjwLsUVg")]
    [DisplayName("Execution Requested Date Time")]
    [IsoXmlTag("ExctnReqdDtTm")]
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_6vMxAe34Eeqc-LCjwLsUVg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate71? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_6vMxCe34Eeqc-LCjwLsUVg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice60? PriceDetails { get; init; }

    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_6vMxEe34Eeqc-LCjwLsUVg")]
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25, MinimumLength = 1)]
    public IsoMax25Text? ShareholderNumber { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_6vMxE-34Eeqc-LCjwLsUVg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative32? AdditionalInformation { get; init; }
}
