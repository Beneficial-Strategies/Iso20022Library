// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option220.
/// </summary>
[IsoId("_G9yKYWHkEe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Option220")]
public record CorporateActionOption220
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative57? AdditionalInformation { get; init; }

    /// <summary>
    /// Applied Option Indicator.
    /// </summary>
    [DisplayName("Applied Option Indicator")]
    [IsoXmlTag("ApldOptnInd")]
    public IsoYesNoIndicator? AppliedOptionIndicator { get; init; }

    /// <summary>
    /// Cash Movement Details.
    /// </summary>
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption93> CashMovementDetails { get; init; } = [];

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
    public ValueList<BeneficiaryCertificationType9Choice_> CertificationBreakdownType { get; init; } =
        [];

    /// <summary>
    /// Change Allowed Indicator.
    /// </summary>
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Charges Applied Indicator.
    /// </summary>
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

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
    public CorporateActionDate78? DateDetails { get; init; }

    /// <summary>
    /// Default Processing Or Standing Instruction.
    /// </summary>
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Fraction Disposition.
    /// </summary>
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType26Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Non Domicile Country.
    /// </summary>
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public ValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Offer Type.
    /// </summary>
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat12Choice_> OfferType { get; init; } = [];

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
    public CorporateActionPrice68? PriceDetails { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate106? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Securities Movement Details.
    /// </summary>
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption101> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Securities Quantity.
    /// </summary>
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption81? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Security Identification.
    /// </summary>
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification19? SecurityIdentification { get; init; }

    /// <summary>
    /// Valid Domicile Country.
    /// </summary>
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public ValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Withdrawal Allowed Indicator.
    /// </summary>
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }
}
