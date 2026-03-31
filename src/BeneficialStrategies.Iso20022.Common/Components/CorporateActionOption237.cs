// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option237.
/// </summary>
[IsoId("_3p1fgYV4Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Option237")]
public record CorporateActionOption237
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative32? AdditionalInformation { get; init; }

    /// <summary>
    /// Change Type.
    /// </summary>
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat6Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Currency Option.
    /// </summary>
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Currency To Buy.
    /// </summary>
    [DisplayName("Currency To Buy")]
    [IsoXmlTag("CcyToBuy")]
    public ActiveCurrencyCode? CurrencyToBuy { get; init; }

    /// <summary>
    /// Currency To Sell.
    /// </summary>
    [DisplayName("Currency To Sell")]
    [IsoXmlTag("CcyToSell")]
    public ActiveCurrencyCode? CurrencyToSell { get; init; }

    /// <summary>
    /// Eligible For Collateral Indicator.
    /// </summary>
    [DisplayName("Eligible For Collateral Indicator")]
    [IsoXmlTag("ElgblForCollInd")]
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; }

    /// <summary>
    /// Execution Requested Date Time.
    /// </summary>
    [DisplayName("Execution Requested Date Time")]
    [IsoXmlTag("ExctnReqdDtTm")]
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; }

    /// <summary>
    /// Fraction Disposition.
    /// </summary>
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType28Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Option Features.
    /// </summary>
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; }

    /// <summary>
    /// Option Number.
    /// </summary>
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption40Choice_ OptionType { get; init; }

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice88? PriceDetails { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate127? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Securities Quantity Or Instructed Amount.
    /// </summary>
    [DisplayName("Securities Quantity Or Instructed Amount")]
    [IsoXmlTag("SctiesQtyOrInstdAmt")]
    public required SecuritiesQuantityOrAmount6Choice_ SecuritiesQuantityOrInstructedAmount { get; init; }

    /// <summary>
    /// Security Identification.
    /// </summary>
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification19? SecurityIdentification { get; init; }

    /// <summary>
    /// Shareholder Number.
    /// </summary>
    [DisplayName("Shareholder Number")]
    [IsoXmlTag("ShrhldrNb")]
    public IsoMax25Text? ShareholderNumber { get; init; }

    /// <summary>
    /// Solicitation Dealer Fee Indicator.
    /// </summary>
    [DisplayName("Solicitation Dealer Fee Indicator")]
    [IsoXmlTag("SlctnDealrFeeInd")]
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; }
}
