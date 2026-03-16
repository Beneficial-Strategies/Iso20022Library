// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option235.
/// </summary>
[IsoId("_254CMYV4Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Option235")]
public record CorporateActionOption235
{
    /// <summary>
    /// Acceptance Priority Level.
    /// </summary>
    [DisplayName("Acceptance Priority Level")]
    [IsoXmlTag("AccptncPrtyLvl")]
    public IsoExact3UpperCaseAlphaNumericText? AcceptancePriorityLevel { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative66? AdditionalInformation { get; init; }

    /// <summary>
    /// Cash Movement Details.
    /// </summary>
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption108> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Certification Breakdown Indicator.
    /// </summary>
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Certification Breakdown Type.
    /// </summary>
    [DisplayName("Certification Breakdown Type")]
    [IsoXmlTag("CertfctnBrkdwnTp")]
    public ValueList<BeneficiaryCertificationType13Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Currency Option.
    /// </summary>
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate104? DateDetails { get; init; }

    /// <summary>
    /// Default Option Indicator.
    /// </summary>
    [DisplayName("Default Option Indicator")]
    [IsoXmlTag("DfltOptnInd")]
    public required IsoYesNoIndicator DefaultOptionIndicator { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Fraction Disposition.
    /// </summary>
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Offer Type.
    /// </summary>
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat14Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Option Availability Status.
    /// </summary>
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus3Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Option Features.
    /// </summary>
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat28Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Option Number.
    /// </summary>
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption37Choice_ OptionType { get; init; }

    /// <summary>
    /// Oversubscription Charge Indicator.
    /// </summary>
    [DisplayName("Oversubscription Charge Indicator")]
    [IsoXmlTag("OvrsbcptChrgInd")]
    public IsoYesNoIndicator? OversubscriptionChargeIndicator { get; init; }

    /// <summary>
    /// Period Details.
    /// </summary>
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod12? PeriodDetails { get; init; }

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice87? PriceDetails { get; init; }

    /// <summary>
    /// Proration Below Minimum Quantity.
    /// </summary>
    [DisplayName("Proration Below Minimum Quantity")]
    [IsoXmlTag("PrratnBlwMinQty")]
    public ProrationBelowMinimumQuantity2Choice_? ProrationBelowMinimumQuantity { get; init; }

    /// <summary>
    /// Proration Fraction.
    /// </summary>
    [DisplayName("Proration Fraction")]
    [IsoXmlTag("PrratnFrctn")]
    public IsoDecimalNumber? ProrationFraction { get; init; }

    /// <summary>
    /// Proration Return Minimum Quantity Treatment.
    /// </summary>
    [DisplayName("Proration Return Minimum Quantity Treatment")]
    [IsoXmlTag("PrratnRtrMinQtyTrtmnt")]
    public ProrationReturnQuantityTreatment1Code? ProrationReturnMinimumQuantityTreatment { get; init; }

    /// <summary>
    /// Proration Rounding Indicator.
    /// </summary>
    [DisplayName("Proration Rounding Indicator")]
    [IsoXmlTag("PrratnRndgInd")]
    public FractionDispositionType12Code? ProrationRoundingIndicator { get; init; }

    /// <summary>
    /// Protect Charge Indicator.
    /// </summary>
    [DisplayName("Protect Charge Indicator")]
    [IsoXmlTag("PrtctChrgInd")]
    public IsoYesNoIndicator? ProtectChargeIndicator { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate124? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Securities Movement Details.
    /// </summary>
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption114> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Securities Quantity.
    /// </summary>
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption81? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Step Up Charge Indicator.
    /// </summary>
    [DisplayName("Step Up Charge Indicator")]
    [IsoXmlTag("StepUpChrgInd")]
    public IsoYesNoIndicator? StepUpChargeIndicator { get; init; }

    /// <summary>
    /// Subscription Charge Indicator.
    /// </summary>
    [DisplayName("Subscription Charge Indicator")]
    [IsoXmlTag("SbcptChrgInd")]
    public IsoYesNoIndicator? SubscriptionChargeIndicator { get; init; }

    /// <summary>
    /// Supplementary Option Features.
    /// </summary>
    [DisplayName("Supplementary Option Features")]
    [IsoXmlTag("SplmtryOptnFeatrs")]
    public ValueList<ExtendedOptionFeature2Code> SupplementaryOptionFeatures { get; init; } = [];

    /// <summary>
    /// Tax Category.
    /// </summary>
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    public TaxCategory1? TaxCategory { get; init; }

    /// <summary>
    /// Withdrawal Allowed Indicator.
    /// </summary>
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }
}
