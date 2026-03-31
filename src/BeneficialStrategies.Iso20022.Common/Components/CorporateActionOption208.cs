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
[IsoId("_p4Yp3Ti7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption208
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_p4Yp8Ti7Eeydid5dcNPKvg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_p4Yp-Ti7Eeydid5dcNPKvg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption46Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_p4YqATi7Eeydid5dcNPKvg")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType31Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_p4YqCTi7Eeydid5dcNPKvg")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat13Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_p4YqETi7Eeydid5dcNPKvg")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat26Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_p4YqGTi7Eeydid5dcNPKvg")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus4Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Type of certification/breakdown.
    /// </summary>
    [IsoId("_p4YqITi7Eeydid5dcNPKvg")]
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType12Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of acceptable bid range values.
    /// </summary>
    [IsoId("_p4YqKTi7Eeydid5dcNPKvg")]
    [DisplayName("Bid Range Type")]
    [IsoXmlTag("BidRgTp")]
    public BidRangeType1Choice_? BidRangeType { get; init; }

    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_p4YqKzi7Eeydid5dcNPKvg")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_p4YqMzi7Eeydid5dcNPKvg")]
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public SimpleValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_p4YqOzi7Eeydid5dcNPKvg")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_p4YqQzi7Eeydid5dcNPKvg")]
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_p4YqSzi7Eeydid5dcNPKvg")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether certification/breakdown is required from the account owner.
    /// Yes: certification required
    /// No: no certification required.
    /// </summary>
    [IsoId("_p4YqUzi7Eeydid5dcNPKvg")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_p4YqWzi7Eeydid5dcNPKvg")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_p4YqYzi7Eeydid5dcNPKvg")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the option, different from the default one, shall be applied by the account owner.
    /// </summary>
    [IsoId("_p4Yqazi7Eeydid5dcNPKvg")]
    [DisplayName("Applied Option Indicator")]
    [IsoXmlTag("ApldOptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_p4YqbTi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_p4YqdTi7Eeydid5dcNPKvg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate82? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_p4YqfTi7Eeydid5dcNPKvg")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod12? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_p4YqhTi7Eeydid5dcNPKvg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate111? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_p4YqjTi7Eeydid5dcNPKvg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice81? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_p4YqlTi7Eeydid5dcNPKvg")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption84? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("_p4YqnTi7Eeydid5dcNPKvg")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption85> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_p4YqpTi7Eeydid5dcNPKvg")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption82> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_p4YqrTi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative48? AdditionalInformation { get; init; }
}
