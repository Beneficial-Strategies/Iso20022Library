// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("__zRv8Z9TEeqxTNfi5y7ywQ")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument96
{
    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in this class in certified form.
    /// </summary>
    [IsoId("_AKCqJZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Physical Bearer Securities")]
    [IsoXmlTag("PhysBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PhysicalBearerSecurities { get; init; }

    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in paperless form.
    /// </summary>
    [IsoId("_AKCqJ59UEeqxTNfi5y7ywQ")]
    [DisplayName("Dematerialised Bearer Securities")]
    [IsoXmlTag("DmtrlsdBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedBearerSecurities { get; init; }

    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_AKCqKZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Physical Registered Securities")]
    [IsoXmlTag("PhysRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PhysicalRegisteredSecurities { get; init; }

    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_AKCqK59UEeqxTNfi5y7ywQ")]
    [DisplayName("Dematerialised Registered Securities")]
    [IsoXmlTag("DmtrlsdRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedRegisteredSecurities { get; init; }

    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_AKCqLZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Dividend policy of the fund, for example, cash, units.
    /// </summary>
    [IsoId("_AKCqL59UEeqxTNfi5y7ywQ")]
    [DisplayName("Dividend Policy")]
    [IsoXmlTag("DvddPlcy")]
    public DividendPolicy1Code? DividendPolicy { get; init; }

    /// <summary>
    /// Frequency with which the income is allocated to investors.
    /// </summary>
    [IsoId("_AKCqMZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Dividend Frequency")]
    [IsoXmlTag("DvddFrqcy")]
    public EventFrequency5Code? DividendFrequency { get; init; }

    /// <summary>
    /// Frequency with which the reinvestment takes place, this is the same or less than the dividend frequency.
    /// </summary>
    [IsoId("_AKCqM59UEeqxTNfi5y7ywQ")]
    [DisplayName("Reinvestment Frequency")]
    [IsoXmlTag("RinvstmtFrqcy")]
    public EventFrequency5Code? ReinvestmentFrequency { get; init; }

    /// <summary>
    /// Indicates whether a front end charge on subscription orders for this class can be applied.
    /// </summary>
    [IsoId("_AKCqNZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Front End Load")]
    [IsoXmlTag("FrntEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FrontEndLoad { get; init; }

    /// <summary>
    /// Indicates whether an exit charge (for example, CDSC) on redemption orders for this class can be applied.
    /// </summary>
    [IsoId("_AKCqN59UEeqxTNfi5y7ywQ")]
    [DisplayName("Back End Load")]
    [IsoXmlTag("BckEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BackEndLoad { get; init; }

    /// <summary>
    /// Indicates whether a separate fee for switching between sub-funds of the same umbrella can be applied.
    /// </summary>
    [IsoId("_AKCqOZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Switch Fee")]
    [IsoXmlTag("SwtchFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SwitchFee { get; init; }

    /// <summary>
    /// Indicates whether the investment fund class is subject to the European Union Saving Directive.
    /// </summary>
    [IsoId("_AKCqO59UEeqxTNfi5y7ywQ")]
    [DisplayName("EU Savings Directive")]
    [IsoXmlTag("EUSvgsDrctv")]
    public EUSavingsDirective1Code? EUSavingsDirective { get; init; }

    /// <summary>
    /// Date on which the fund is open for investment.
    /// </summary>
    [IsoId("_AKCqPZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Launch Date")]
    [IsoXmlTag("LnchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LaunchDate { get; init; }

    /// <summary>
    /// Date on which the fund is closed to investment.
    /// </summary>
    [IsoId("_AKCqP59UEeqxTNfi5y7ywQ")]
    [DisplayName("Fund End Date")]
    [IsoXmlTag("FndEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FundEndDate { get; init; }

    /// <summary>
    /// Date the fund closes.
    /// </summary>
    [IsoId("_AKCqQZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }

    /// <summary>
    /// Date on which the discount period of the newly launched investment fund ends.
    /// </summary>
    [IsoId("_AKCqQ59UEeqxTNfi5y7ywQ")]
    [DisplayName("Initial Offer End Date")]
    [IsoXmlTag("InitlOfferEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InitialOfferEndDate { get; init; }

    /// <summary>
    /// Date on which valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_AKCqRZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Suspension Start Date")]
    [IsoXmlTag("SspnsnStartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SuspensionStartDate { get; init; }

    /// <summary>
    /// Date on which valuation of the investment fund class is unsuspended.
    /// </summary>
    [IsoId("_AKCqR59UEeqxTNfi5y7ywQ")]
    [DisplayName("Suspension End Date")]
    [IsoXmlTag("SspnsnEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SuspensionEndDate { get; init; }

    /// <summary>
    /// Maturity date of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00065.
    /// </summary>
    [IsoId("_AKCqSZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Specifies whether the product may be terminated early. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00067.
    /// </summary>
    [IsoId("_69UTMaDrEequlaOyi6MUhw")]
    [DisplayName("May Be Terminated Early")]
    [IsoXmlTag("MayBeTermntdEarly")]
    public TargetMarket1Code? MayBeTerminatedEarly { get; init; }

    /// <summary>
    /// Indicates whether the fund is close-ended.
    /// </summary>
    [IsoId("_AKCqS59UEeqxTNfi5y7ywQ")]
    [DisplayName("Closed End Fund")]
    [IsoXmlTag("ClsdEndFnd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ClosedEndFund { get; init; }

    /// <summary>
    /// Indicates whether equalisation is applied.
    /// </summary>
    [IsoId("_AKCqTZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Equalisation { get; init; }

    /// <summary>
    /// Indicates whether the fund is eligible for a tax efficient product.
    /// </summary>
    [IsoId("_AKCqT59UEeqxTNfi5y7ywQ")]
    [DisplayName("Tax Efficient Product Eligible")]
    [IsoXmlTag("TaxEffcntPdctElgbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TaxEfficientProductEligible { get; init; }

    /// <summary>
    /// Indicates whether the fund is authorised by the regulatory compliance authority.
    /// </summary>
    [IsoId("_AKCqUZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Authorised")]
    [IsoXmlTag("Authrsd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Authorised { get; init; }

    /// <summary>
    /// Indicates whether the fund is compliant with the Retail Distribution Review (RDR).
    /// </summary>
    [IsoId("_AKCqU59UEeqxTNfi5y7ywQ")]
    [DisplayName("RDR Compliant")]
    [IsoXmlTag("RDRCmplnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RDRCompliant { get; init; }

    /// <summary>
    /// Specifies from where the management fee is taken.
    /// </summary>
    [IsoId("_AKCqVZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Management Fee Source")]
    [IsoXmlTag("MgmtFeeSrc")]
    public AnnualChargePaymentType1Code? ManagementFeeSource { get; init; }

    /// <summary>
    /// Indicates whether there is a performance fee feature or carried interest. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00045.
    /// </summary>
    [IsoId("_AKCqV59UEeqxTNfi5y7ywQ")]
    [DisplayName("Performance Fee")]
    [IsoXmlTag("PrfrmncFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PerformanceFee { get; init; }

    /// <summary>
    /// Additional information about the fund.
    /// </summary>
    [IsoId("_AKCqWZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
