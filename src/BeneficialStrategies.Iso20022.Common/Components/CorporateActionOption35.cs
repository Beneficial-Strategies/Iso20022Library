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
[IsoId("_nmciMfmUEeCcAY_zfcalaA")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption35
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_nmlsOfmUEeCcAY_zfcalaA")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_nmlsQ_mUEeCcAY_zfcalaA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption10Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_nmlsTfmUEeCcAY_zfcalaA")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType1Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_nmlsV_mUEeCcAY_zfcalaA")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat1Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_nmlsYfmUEeCcAY_zfcalaA")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat9Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    [IsoId("_nmlsa_mUEeCcAY_zfcalaA")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat9Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_nmlsdfmUEeCcAY_zfcalaA")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Indicates the type of certification/breakdown.
    /// </summary>
    [IsoId("_nmlsf_mUEeCcAY_zfcalaA")]
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType5Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_nmlsifmUEeCcAY_zfcalaA")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_nmlsk_mUEeCcAY_zfcalaA")]
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public SimpleValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_nmlsnfmUEeCcAY_zfcalaA")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_nmlsp_mUEeCcAY_zfcalaA")]
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    [IsoId("_nmlssfmUEeCcAY_zfcalaA")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not certification/breakdown is required from the account owner.
    /// Yes: certification required
    /// No: no certification required.
    /// </summary>
    [IsoId("_nmlsu_mUEeCcAY_zfcalaA")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_nmlsxfmUEeCcAY_zfcalaA")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_nmlsz_mUEeCcAY_zfcalaA")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_nmls2fmUEeCcAY_zfcalaA")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification14? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_nmls4_mUEeCcAY_zfcalaA")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate15? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_nmls7fmUEeCcAY_zfcalaA")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod7? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_nmls9_mUEeCcAY_zfcalaA")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate25? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_nmltAfmUEeCcAY_zfcalaA")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice28? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity related to a corporate action option.
    /// </summary>
    [IsoId("_nmltC_mUEeCcAY_zfcalaA")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption23? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about securities movement related to a corporate action option.
    /// </summary>
    [IsoId("_nmltFfmUEeCcAY_zfcalaA")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption24> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_nmltH_mUEeCcAY_zfcalaA")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption16> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information about the corporate action movement.
    /// </summary>
    [IsoId("_nmltKfmUEeCcAY_zfcalaA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative20? AdditionalInformation { get; init; }
}
