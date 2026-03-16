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
[IsoId("_chdlv5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption123
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_chdlx5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_chdlz5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption25Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    [IsoId("_chdl15KQEeWHWpTQn1FFVg")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType29Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    [IsoId("_chdl35KQEeWHWpTQn1FFVg")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat7Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    [IsoId("_chdl55KQEeWHWpTQn1FFVg")]
    [DisplayName("Eligible For Collateral Indicator")]
    [IsoXmlTag("ElgblForCollInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; }

    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    [IsoId("_chdl75KQEeWHWpTQn1FFVg")]
    [DisplayName("Currency To Buy")]
    [IsoXmlTag("CcyToBuy")]
    public ActiveCurrencyCode? CurrencyToBuy { get; init; }

    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    [IsoId("_chdl95KQEeWHWpTQn1FFVg")]
    [DisplayName("Currency To Sell")]
    [IsoXmlTag("CcyToSell")]
    public ActiveCurrencyCode? CurrencyToSell { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_chdl_5KQEeWHWpTQn1FFVg")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_chdmB5KQEeWHWpTQn1FFVg")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification20? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_chdmD5KQEeWHWpTQn1FFVg")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public required SecuritiesOption54 SecuritiesQuantity { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_chdmF5KQEeWHWpTQn1FFVg")]
    [DisplayName("Execution Requested Date Time")]
    [IsoXmlTag("ExctnReqdDtTm")]
    public DateAndDateTimeChoice_? ExecutionRequestedDateTime { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_chdmH5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate73? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_chdmJ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice62? PriceDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_chdmL5KQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative33? AdditionalInformation { get; init; }
}
