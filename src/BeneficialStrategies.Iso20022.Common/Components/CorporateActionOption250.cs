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
[IsoId("3e681117-9896-419e-b001-b51adf469948")]
[DisplayName("Corporate Action Option250")]
public record CorporateActionOption250
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("7f62e751-4080-493f-8b9e-bc583404199d")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("37a69d3d-921b-4a89-b5c4-201352ab1f0c")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption37Choice OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounded.
    /// </summary>
    [IsoId("43b76e75-43d0-4acd-8d38-15e3af6f1117")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("4ce599f8-32f1-4f5d-9fd3-b8e4a4dec59f")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat32Choice> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Used for options that have particular proprietary features.
    /// </summary>
    [IsoId("c43a4b20-3c4b-4028-9539-0c24c86508fb")]
    [DisplayName("Supplementary Option Features")]
    [IsoXmlTag("SplmtryOptnFeatrs")]
    public SimpleValueList<ExtendedOptionFeature2Code> SupplementaryOptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("900b79e2-4acc-45bd-8db2-32798950043b")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus3Choice? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Type of certification/breakdown.
    /// </summary>
    [IsoId("16eb231b-a305-4ef3-839c-b5de0f73fb8f")]
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType13Choice> CertificationBreakdownType { get; init; } = [];

    /// <summary>
    /// Currency in which cash proceeds are to be credited/debited.
    /// </summary>
    [IsoId("cc54cafd-33f5-4faa-8491-3106fe52e145")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the option will be selected by default if no instruction is provided by the account owner.
    /// </summary>
    [IsoId("373bd157-3609-4761-a73f-6c93e25496fa")]
    [DisplayName("Default Option Indicator")]
    [IsoXmlTag("DfltOptnInd")]
    public required IsoYesNoIndicator DefaultOptionIndicator { get; init; }

    /// <summary>
    /// Indicates whether certification/breakdown is required from the account owner.
    /// </summary>
    [IsoId("c470c894-90aa-4dfa-9f2e-d2d2f535710c")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("56bef00b-6305-4d05-a1ec-c1a6a0ce2e54")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the oversubscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("400d88d5-ea87-45cd-885e-7866c1d38c8f")]
    [DisplayName("Oversubscription Charge Indicator")]
    [IsoXmlTag("OvrsbcptChrgInd")]
    public IsoYesNoIndicator? OversubscriptionChargeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the protect charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("001b0d74-ffc1-4736-b84e-16c707036cb0")]
    [DisplayName("Protect Charge Indicator")]
    [IsoXmlTag("PrtctChrgInd")]
    public IsoYesNoIndicator? ProtectChargeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the subscription charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("a6b10a67-03f2-41d1-9157-fac4ad8b8619")]
    [DisplayName("Subscription Charge Indicator")]
    [IsoXmlTag("SbcptChrgInd")]
    public IsoYesNoIndicator? SubscriptionChargeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash debit for the step-up charge is made at the time of instruction submission.
    /// </summary>
    [IsoId("1fdbc943-3f6e-4516-94ff-1a984d13921f")]
    [DisplayName("Step Up Charge Indicator")]
    [IsoXmlTag("StepUpChrgInd")]
    public IsoYesNoIndicator? StepUpChargeIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("6634723c-5e95-4819-972a-619476a5aa08")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("a8403faf-0a2f-4f32-9a05-a1570a3e69f4")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate110? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("6becd013-866b-49f7-a933-a1312beb457b")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod18? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("6d447268-052a-4f4b-a8ed-b25c6416855e")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate138? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("1d000b2a-1c6c-4934-821a-ae75fd336b04")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice87? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    [IsoId("ae03be6f-862c-4e10-9f7d-d5e0c0e6f4d2")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption81? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Identification of the tax category.
    /// </summary>
    [IsoId("63bef6f6-967e-4128-b73a-36f60a6539c1")]
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    public ValueList<TaxCategory1> TaxCategory { get; init; } = [];

    /// <summary>
    /// Specifies how instructions prorated below the minimum quantity to instruct will be processed.
    /// </summary>
    [IsoId("8a7e04a4-23a0-4dde-9ecb-75645adaae1c")]
    [DisplayName("Proration Below Minimum Quantity")]
    [IsoXmlTag("PrratnBlwMinQty")]
    public ProrationBelowMinimumQuantity3Choice? ProrationBelowMinimumQuantity { get; init; }

    /// <summary>
    /// Indicates how fractional positions will be handled for events with prorated options.
    /// </summary>
    [IsoId("959fcaec-76f7-4110-9313-2e490feec21e")]
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; }

    /// <summary>
    /// Decimal above which numbers are rounded for prorated options.
    /// </summary>
    [IsoId("41498c93-7783-48bc-b811-6667d5cef94e")]
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    public IsoDecimalNumber? ProrationFraction { get; init; }

    /// <summary>
    /// Indicates how prorated instructions will be handled when the prorated entitlement results in less than the minimum denomination.
    /// </summary>
    [IsoId("e4a53fa0-e38f-420b-825d-3cf9b512253d")]
    [DisplayName("Proration Return Minimum Quantity Treatment")]
    [IsoXmlTag("PrratnRtrMinQtyTrtmnt")]
    public ProrationReturnQuantityTreatment1Code? ProrationReturnMinimumQuantityTreatment { get; init; }

    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    [IsoId("4e0384bb-275b-41c6-8acc-447a73cdff62")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption120> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("79c96d41-094c-46ae-9e62-f65bd9dd8795")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption115> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("63adeb25-5cf9-4e03-9441-5ae813b755fd")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative66? AdditionalInformation { get; init; }
}
