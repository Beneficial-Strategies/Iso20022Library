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
[IsoId("_UEzQMtp-Ed-ak6NoX_4Aeg_-682473212")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption10
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UEzQM9p-Ed-ak6NoX_4Aeg_-682473181")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UEzQNNp-Ed-ak6NoX_4Aeg_-682473151")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption2Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_UEzQNdp-Ed-ak6NoX_4Aeg_-682473089")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType1Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_UEzQNtp-Ed-ak6NoX_4Aeg_-682473059")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat1Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    [IsoId("_UEzQN9p-Ed-ak6NoX_4Aeg_-682472750")]
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat2Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    [IsoId("_UEzQONp-Ed-ak6NoX_4Aeg_-682472719")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat2Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies the status of the option.
    /// </summary>
    [IsoId("_UEzQOdp-Ed-ak6NoX_4Aeg_-682472688")]
    [DisplayName("Option Availability Status")]
    [IsoXmlTag("OptnAvlbtySts")]
    public OptionAvailabilityStatus1Choice_? OptionAvailabilityStatus { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UEzQOtp-Ed-ak6NoX_4Aeg_-682472627")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public ValueList<BeneficiaryCertificationType1Choice_> CertificationType { get; init; } = [];

    /// <summary>
    /// Holder of the security has to certify, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_UEzQO9p-Ed-ak6NoX_4Aeg_-682472596")]
    [DisplayName("Non Domicile Country")]
    [IsoXmlTag("NonDmclCtry")]
    public SimpleValueList<CountryCode> NonDomicileCountry { get; init; } = [];

    /// <summary>
    /// Country of domicile in which the Corporate Action option is valid. The holder of the security has to certify that it is domiciled in the country indicated.
    /// </summary>
    [IsoId("_UE9BMNp-Ed-ak6NoX_4Aeg_-1210508490")]
    [DisplayName("Valid Domicile Country")]
    [IsoXmlTag("VldDmclCtry")]
    public SimpleValueList<CountryCode> ValidDomicileCountry { get; init; } = [];

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_UE9BMdp-Ed-ak6NoX_4Aeg_-682472566")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Indicates whether the corporate action movement is a default processing or a standing instruction.
    /// </summary>
    [IsoId("_UE9BMtp-Ed-ak6NoX_4Aeg_-682472565")]
    [DisplayName("Default Processing Or Standing Instruction")]
    [IsoXmlTag("DfltPrcgOrStgInstr")]
    public required DefaultProcessingOrStandingInstruction1Choice_ DefaultProcessingOrStandingInstruction { get; init; }

    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    [IsoId("_UE9BM9p-Ed-ak6NoX_4Aeg_-682472535")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not certification is required from the account owner. |Yes: certification required |No: no certification required.
    /// </summary>
    [IsoId("_UE9BNNp-Ed-ak6NoX_4Aeg_-682472505")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationIndicator { get; init; }

    /// <summary>
    /// Indicates whether withdrawal of instruction is allowed.
    /// </summary>
    [IsoId("_UE9BNdp-Ed-ak6NoX_4Aeg_-682472257")]
    [DisplayName("Withdrawal Allowed Indicator")]
    [IsoXmlTag("WdrwlAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WithdrawalAllowedIndicator { get; init; }

    /// <summary>
    /// Indicates whether change of instruction is allowed.
    /// </summary>
    [IsoId("_UE9BNtp-Ed-ak6NoX_4Aeg_-682472226")]
    [DisplayName("Change Allowed Indicator")]
    [IsoXmlTag("ChngAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeAllowedIndicator { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_UE9BN9p-Ed-ak6NoX_4Aeg_-682472196")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification11? SecurityIdentification { get; init; }

    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    [IsoId("_UE9BONp-Ed-ak6NoX_4Aeg_-681552101")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate8? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    [IsoId("_UE9BOdp-Ed-ak6NoX_4Aeg_-681552078")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod5? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    [IsoId("_UFGyMNp-Ed-ak6NoX_4Aeg_-681551986")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate5? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_UFGyMdp-Ed-ak6NoX_4Aeg_-681552047")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice6? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity related to a corporate action option.
    /// </summary>
    [IsoId("_UFGyMtp-Ed-ak6NoX_4Aeg_-681551924")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public SecuritiesOption1? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Provides information about securities movement related to a corporate action option.
    /// </summary>
    [IsoId("_UFGyM9p-Ed-ak6NoX_4Aeg_2007212874")]
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption4> SecuritiesMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the cash movement linked to the corporate action option.
    /// </summary>
    [IsoId("_UFGyNNp-Ed-ak6NoX_4Aeg_-682472158")]
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption3> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information about the corporate action movement.
    /// </summary>
    [IsoId("_UFGyNdp-Ed-ak6NoX_4Aeg_-681552132")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative5? AdditionalInformation { get; init; }
}
