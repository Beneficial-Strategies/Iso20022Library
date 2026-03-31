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
[IsoId("_qY_QQffREeiNZp_PtLohLw")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption158
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_qY_QS_fREeiNZp_PtLohLw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_qY_QU_fREeiNZp_PtLohLw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption29Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_qY_QW_fREeiNZp_PtLohLw")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat27Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_qY_QXffREeiNZp_PtLohLw")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType29Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_qY_QZffREeiNZp_PtLohLw")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat7Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_qY_QbffREeiNZp_PtLohLw")]
    [DisplayName("Eligible For Collateral Indicator")]
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_qY_QdffREeiNZp_PtLohLw")]
    [DisplayName("Currency To Buy")]
    [IsoXmlTag("CcyToBuy")]
    public ActiveCurrencyCode? CurrencyToBuy { get; init; }

    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_qY_20ffREeiNZp_PtLohLw")]
    [DisplayName("Currency To Sell")]
    [IsoXmlTag("CcyToSell")]
    public ActiveCurrencyCode? CurrencyToSell { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_qY_22ffREeiNZp_PtLohLw")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_qY_24ffREeiNZp_PtLohLw")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification20? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_qY_26ffREeiNZp_PtLohLw")]
    [DisplayName("Securities Quantity Or Instructed Amount")]
    [IsoXmlTag("SctiesQtyOrInstdAmt")]
    public required SecuritiesQuantityOrAmount5Choice_ SecuritiesQuantityOrInstructedAmount { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_qY_28ffREeiNZp_PtLohLw")]
    [DisplayName("Execution Requested Date Time")]
    [IsoXmlTag("ExctnReqdDtTm")]
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_qY_2-ffREeiNZp_PtLohLw")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate73? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_qY_3AffREeiNZp_PtLohLw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice62? PriceDetails { get; init; }

    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_qY_3CffREeiNZp_PtLohLw")]
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax25Text)]
    [StringLength(maximumLength: 25, MinimumLength = 1)]
    public IsoRestrictedFINXMax25Text? ShareholderNumber { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_qY_3C_fREeiNZp_PtLohLw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative33? AdditionalInformation { get; init; }
}
