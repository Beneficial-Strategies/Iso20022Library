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
[IsoId("_4O-qcearEemtTOaHuc_63w")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption165
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_4greeearEemtTOaHuc_63w")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_4gregearEemtTOaHuc_63w")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption31Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_4greiearEemtTOaHuc_63w")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_4grei-arEemtTOaHuc_63w")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType28Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_4grek-arEemtTOaHuc_63w")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat6Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_4grem-arEemtTOaHuc_63w")]
    [DisplayName("Eligible For Collateral Indicator")]
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_4greo-arEemtTOaHuc_63w")]
    [DisplayName("Currency To Buy")]
    [IsoXmlTag("CcyToBuy")]
    public ActiveCurrencyCode? CurrencyToBuy { get; init; }

    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_4greq-arEemtTOaHuc_63w")]
    [DisplayName("Currency To Sell")]
    [IsoXmlTag("CcyToSell")]
    public ActiveCurrencyCode? CurrencyToSell { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_4gres-arEemtTOaHuc_63w")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_4greu-arEemtTOaHuc_63w")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification19? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_4grew-arEemtTOaHuc_63w")]
    [DisplayName("Securities Quantity Or Instructed Amount")]
    [IsoXmlTag("SctiesQtyOrInstdAmt")]
    public required SecuritiesQuantityOrAmount4Choice_ SecuritiesQuantityOrInstructedAmount { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_4grey-arEemtTOaHuc_63w")]
    [DisplayName("Execution Requested Date Time")]
    [IsoXmlTag("ExctnReqdDtTm")]
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_4gre0-arEemtTOaHuc_63w")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate71? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_4gre2-arEemtTOaHuc_63w")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice60? PriceDetails { get; init; }

    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    [IsoId("_4gre4-arEemtTOaHuc_63w")]
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    [IsoSimpleType(IsoSimpleType.Max25Text)]
    [StringLength(maximumLength: 25, MinimumLength = 1)]
    public IsoMax25Text? ShareholderNumber { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_4gre5earEemtTOaHuc_63w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative32? AdditionalInformation { get; init; }
}
