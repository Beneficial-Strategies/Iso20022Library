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
[IsoId("_x_GL_R9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption191
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_x_GMDR9REeuFz_FaCzCLgQ")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_x_GMFR9REeuFz_FaCzCLgQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption46Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_x_GMHR9REeuFz_FaCzCLgQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType31Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_x_GMJR9REeuFz_FaCzCLgQ")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat11Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_x_GMLR9REeuFz_FaCzCLgQ")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat26Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_x_GMNR9REeuFz_FaCzCLgQ")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus4Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Type of certification/breakdown.
    /// </summary>
    [IsoId("_x_GMPR9REeuFz_FaCzCLgQ")]
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType12Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of acceptable bid range values.
    /// </summary>
    [IsoId("_x_GMRR9REeuFz_FaCzCLgQ")]
    [DisplayName("Bid Range Type")]
    [IsoXmlTag("BidRgTp")]
    public BidRangeType1Choice_? BidRangeType { get; init; }

    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_x_GMRx9REeuFz_FaCzCLgQ")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_x_GMTx9REeuFz_FaCzCLgQ")]
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public SimpleValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_x_GMVx9REeuFz_FaCzCLgQ")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_x_GMXx9REeuFz_FaCzCLgQ")]
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_x_GMZx9REeuFz_FaCzCLgQ")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether certification/breakdown is required from the account owner.
    /// Yes: certification required
    /// No: no certification required.
    /// </summary>
    [IsoId("_x_GMbx9REeuFz_FaCzCLgQ")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_x_GMdx9REeuFz_FaCzCLgQ")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_x_GMfx9REeuFz_FaCzCLgQ")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the option, different from the default one, shall be applied by the account owner.
    /// </summary>
    [IsoId("_x_GMhx9REeuFz_FaCzCLgQ")]
    [DisplayName("Applied Option Indicator")]
    [IsoXmlTag("ApldOptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_x_GMiR9REeuFz_FaCzCLgQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_x_GMkR9REeuFz_FaCzCLgQ")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate82? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_x_GykR9REeuFz_FaCzCLgQ")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod12? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_x_GymR9REeuFz_FaCzCLgQ")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate111? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_x_GyoR9REeuFz_FaCzCLgQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice71? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_x_GyqR9REeuFz_FaCzCLgQ")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption56? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("_x_GysR9REeuFz_FaCzCLgQ")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption75> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_x_GyuR9REeuFz_FaCzCLgQ")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption75> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_x_GywR9REeuFz_FaCzCLgQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative48? AdditionalInformation { get; init; }
}
