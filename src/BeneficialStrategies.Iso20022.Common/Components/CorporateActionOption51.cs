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
[IsoId("_ehKqURFHEeKp2ZN13DI_pA")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption51
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_e2LRHRFHEeKp2ZN13DI_pA")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_e2LRJxFHEeKp2ZN13DI_pA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption10Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_e2LRMRFHEeKp2ZN13DI_pA")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType19Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_e2LROxFHEeKp2ZN13DI_pA")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat3Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_e2LRRRFHEeKp2ZN13DI_pA")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat9Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_e2LRTxFHEeKp2ZN13DI_pA")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Indicates the type of certification/breakdown.
    /// </summary>
    [IsoId("_e2LRWRFHEeKp2ZN13DI_pA")]
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType5Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_e2LRYxFHEeKp2ZN13DI_pA")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_e2LRbRFHEeKp2ZN13DI_pA")]
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public SimpleValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_e2LRdxFHEeKp2ZN13DI_pA")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_e2LRgRFHEeKp2ZN13DI_pA")]
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_e2LRixFHEeKp2ZN13DI_pA")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Whether or not certification/breakdown is required from the account owner.
    /// Yes: certification required
    /// No: no certification required.
    /// </summary>
    [IsoId("_e2LRlRFHEeKp2ZN13DI_pA")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_e2LRnxFHEeKp2ZN13DI_pA")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_e2LRqRFHEeKp2ZN13DI_pA")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_e2LRsxFHEeKp2ZN13DI_pA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_e2LRvRFHEeKp2ZN13DI_pA")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate15? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_e2LRxxFHEeKp2ZN13DI_pA")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod7? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_e2LR0RFHEeKp2ZN13DI_pA")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate36? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_e2LR2xFHEeKp2ZN13DI_pA")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice28? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_e2LR5RFHEeKp2ZN13DI_pA")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption23? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("_e2LR7xFHEeKp2ZN13DI_pA")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption33> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_e2LR-RFHEeKp2ZN13DI_pA")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption24> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_e2LSBxFHEeKp2ZN13DI_pA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative20? AdditionalInformation { get; init; }
}
