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
[IsoId("_lqkMQYlXEeavwKddCbm3hg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption131
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_mEAnCYlXEeavwKddCbm3hg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_mEAnEYlXEeavwKddCbm3hg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption20Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_mEAnGYlXEeavwKddCbm3hg")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType28Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_mEAnIYlXEeavwKddCbm3hg")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat6Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_mEAnKYlXEeavwKddCbm3hg")]
    [DisplayName("Eligible For Collateral Indicator")]
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_mEAnMYlXEeavwKddCbm3hg")]
    [DisplayName("Currency To Buy")]
    [IsoXmlTag("CcyToBuy")]
    public ActiveCurrencyCode? CurrencyToBuy { get; init; }

    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_mEAnOYlXEeavwKddCbm3hg")]
    [DisplayName("Currency To Sell")]
    [IsoXmlTag("CcyToSell")]
    public ActiveCurrencyCode? CurrencyToSell { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_mEAnQYlXEeavwKddCbm3hg")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_mEAnSYlXEeavwKddCbm3hg")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification19? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_mEAnUYlXEeavwKddCbm3hg")]
    [DisplayName("Securities Quantity Or Instructed Amount")]
    [IsoXmlTag("SctiesQtyOrInstdAmt")]
    public required SecuritiesQuantityOrAmount1Choice_ SecuritiesQuantityOrInstructedAmount { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_mEAnWYlXEeavwKddCbm3hg")]
    [DisplayName("Execution Requested Date Time")]
    [IsoXmlTag("ExctnReqdDtTm")]
    public DateAndDateTimeChoice_? ExecutionRequestedDateTime { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_mEAnYYlXEeavwKddCbm3hg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate71? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_mEAnaYlXEeavwKddCbm3hg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice60? PriceDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_mEAncYlXEeavwKddCbm3hg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative32? AdditionalInformation { get; init; }
}
