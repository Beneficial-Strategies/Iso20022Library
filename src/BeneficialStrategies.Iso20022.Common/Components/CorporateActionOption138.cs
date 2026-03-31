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
[IsoId("_OFdycZShEeeh5JjedkaA_g")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption138
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_OXeIfZShEeeh5JjedkaA_g")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_OXeIhZShEeeh5JjedkaA_g")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption18Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_OXeIjZShEeeh5JjedkaA_g")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_OXeIlZShEeeh5JjedkaA_g")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat10Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_OXeInZShEeeh5JjedkaA_g")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat22Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_OXeIpZShEeeh5JjedkaA_g")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus3Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Type of certification/breakdown.
    /// </summary>
    [IsoId("_OXeIrZShEeeh5JjedkaA_g")]
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType9Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_OXeItZShEeeh5JjedkaA_g")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_OXeIvZShEeeh5JjedkaA_g")]
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public SimpleValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_OXeIxZShEeeh5JjedkaA_g")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_OXeIzZShEeeh5JjedkaA_g")]
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_OXeI1ZShEeeh5JjedkaA_g")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Specifies whether certification/breakdown is required from the account owner.
    /// Yes: certification required
    /// No: no certification required.
    /// </summary>
    [IsoId("_OXeI3ZShEeeh5JjedkaA_g")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_OXeI5ZShEeeh5JjedkaA_g")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_OXeI7ZShEeeh5JjedkaA_g")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the option, different from the default one, shall be applied by the account owner.
    /// </summary>
    [IsoId("_OXeI9ZShEeeh5JjedkaA_g")]
    [DisplayName("Applied Option Indicator")]
    [IsoXmlTag("ApldOptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_OXeI95ShEeeh5JjedkaA_g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_OXeI_5ShEeeh5JjedkaA_g")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate64? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_OXeJB5ShEeeh5JjedkaA_g")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod12? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_OXeJD5ShEeeh5JjedkaA_g")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate87? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_OXeJF5ShEeeh5JjedkaA_g")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice68? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("_OXeJH5ShEeeh5JjedkaA_g")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption51? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("_OXeJJ5ShEeeh5JjedkaA_g")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption64> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_OXeJL5ShEeeh5JjedkaA_g")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption56> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_OXeJN5ShEeeh5JjedkaA_g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative29? AdditionalInformation { get; init; }
}
