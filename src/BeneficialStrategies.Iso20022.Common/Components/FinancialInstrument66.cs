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
[IsoId("_SOTuYTf4Eei6RvewLQWEqw")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument66
{
    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in this class in certified form.
    /// </summary>
    [IsoId("_SerFpzf4Eei6RvewLQWEqw")]
    [DisplayName("Physical Bearer Securities")]
    [IsoXmlTag("PhysBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PhysicalBearerSecurities { get; init; }

    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in paperless form.
    /// </summary>
    [IsoId("_SerFqTf4Eei6RvewLQWEqw")]
    [DisplayName("Dematerialised Bearer Securities")]
    [IsoXmlTag("DmtrlsdBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedBearerSecurities { get; init; }

    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_SerFqzf4Eei6RvewLQWEqw")]
    [DisplayName("Physical Registered Securities")]
    [IsoXmlTag("PhysRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PhysicalRegisteredSecurities { get; init; }

    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_SerFrTf4Eei6RvewLQWEqw")]
    [DisplayName("Dematerialised Registered Securities")]
    [IsoXmlTag("DmtrlsdRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DematerialisedRegisteredSecurities { get; init; }

    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_SerFrzf4Eei6RvewLQWEqw")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public DistributionPolicy1Code? DistributionPolicy { get; init; }

    /// <summary>
    /// Dividend policy of the fund, for example, cash, units.
    /// </summary>
    [IsoId("_SerFsTf4Eei6RvewLQWEqw")]
    [DisplayName("Dividend Policy")]
    [IsoXmlTag("DvddPlcy")]
    public DividendPolicy1Code? DividendPolicy { get; init; }

    /// <summary>
    /// Frequency with which the income is allocated to investors.
    /// </summary>
    [IsoId("_SerFszf4Eei6RvewLQWEqw")]
    [DisplayName("Dividend Frequency")]
    [IsoXmlTag("DvddFrqcy")]
    public EventFrequency5Code? DividendFrequency { get; init; }

    /// <summary>
    /// Frequency with which the reinvestment takes place, this is the same or less than the dividend frequency.
    /// </summary>
    [IsoId("_SerFtTf4Eei6RvewLQWEqw")]
    [DisplayName("Reinvestment Frequency")]
    [IsoXmlTag("RinvstmtFrqcy")]
    public EventFrequency5Code? ReinvestmentFrequency { get; init; }

    /// <summary>
    /// Indicates whether a front end charge on subscription orders for this class can be applied.
    /// </summary>
    [IsoId("_SerFtzf4Eei6RvewLQWEqw")]
    [DisplayName("Front End Load")]
    [IsoXmlTag("FrntEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FrontEndLoad { get; init; }

    /// <summary>
    /// Indicates whether an exit charge (for example, CDSC) on redemption orders for this class can be applied.
    /// </summary>
    [IsoId("_SerFuTf4Eei6RvewLQWEqw")]
    [DisplayName("Back End Load")]
    [IsoXmlTag("BckEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BackEndLoad { get; init; }

    /// <summary>
    /// Indicates whether a separate fee for switching between sub-funds of the same umbrella can be applied.
    /// </summary>
    [IsoId("_SerFuzf4Eei6RvewLQWEqw")]
    [DisplayName("Switch Fee")]
    [IsoXmlTag("SwtchFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SwitchFee { get; init; }

    /// <summary>
    /// Indicates whether the investment fund class is subject to the European Union Saving Directive.
    /// </summary>
    [IsoId("_SerFvTf4Eei6RvewLQWEqw")]
    [DisplayName("EU Savings Directive")]
    [IsoXmlTag("EUSvgsDrctv")]
    public EUSavingsDirective1Code? EUSavingsDirective { get; init; }

    /// <summary>
    /// Date on which the fund is open for investment.
    /// </summary>
    [IsoId("_dbUTUGAOEeiNMJ262H2pWg")]
    [DisplayName("Launch Date")]
    [IsoXmlTag("LnchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LaunchDate { get; init; }

    /// <summary>
    /// Date on which the fund is closed to investment.
    /// </summary>
    [IsoId("_hlU1oGAOEeiNMJ262H2pWg")]
    [DisplayName("Fund End Date")]
    [IsoXmlTag("FndEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FundEndDate { get; init; }

    /// <summary>
    /// Date the fund closes.
    /// </summary>
    [IsoId("_nm8Z0GAOEeiNMJ262H2pWg")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TerminationDate { get; init; }

    /// <summary>
    /// Date on which the discount period of the newly launched investment fund ends.
    /// </summary>
    [IsoId("_sjGKwGAOEeiNMJ262H2pWg")]
    [DisplayName("Initial Offer End Date")]
    [IsoXmlTag("InitlOfferEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InitialOfferEndDate { get; init; }

    /// <summary>
    /// Date on which valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_0h-s4GAOEeiNMJ262H2pWg")]
    [DisplayName("Suspension Start Date")]
    [IsoXmlTag("SspnsnStartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SuspensionStartDate { get; init; }

    /// <summary>
    /// Date on which valuation of the investment fund class is unsuspended.
    /// </summary>
    [IsoId("_4LaRsGAOEeiNMJ262H2pWg")]
    [DisplayName("Suspension End Date")]
    [IsoXmlTag("SspnsnEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SuspensionEndDate { get; init; }

    /// <summary>
    /// Maturity date of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00065. In EMT v1, the element Maturity Date is reference 05090.
    /// </summary>
    [IsoId("_JolpEYBiEei8Q7I_11BpAQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Indicates whether the fund is close-ended.
    /// </summary>
    [IsoId("_8w-HkGAOEeiNMJ262H2pWg")]
    [DisplayName("Closed End Fund")]
    [IsoXmlTag("ClsdEndFnd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ClosedEndFund { get; init; }

    /// <summary>
    /// Indicates whether equalisation is applied.
    /// </summary>
    [IsoId("_B4yV8GAPEeiNMJ262H2pWg")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Equalisation { get; init; }

    /// <summary>
    /// Indicates whether the fund is eligible for a tax efficient product.
    /// </summary>
    [IsoId("_InaKEGAPEeiNMJ262H2pWg")]
    [DisplayName("Tax Efficient Product Eligible")]
    [IsoXmlTag("TaxEffcntPdctElgbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TaxEfficientProductEligible { get; init; }

    /// <summary>
    /// Indicates whether the fund is authorised by the regulatory compliance authority.
    /// </summary>
    [IsoId("_McY3kGAPEeiNMJ262H2pWg")]
    [DisplayName("Authorised")]
    [IsoXmlTag("Authrsd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Authorised { get; init; }

    /// <summary>
    /// Indicates whether the fund is compliant with the Retail Distribution Review (RDR).
    /// </summary>
    [IsoId("_QT8X8GAPEeiNMJ262H2pWg")]
    [DisplayName("RDR Compliant")]
    [IsoXmlTag("RDRCmplnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RDRCompliant { get; init; }

    /// <summary>
    /// Specifies from where the management fee is taken.
    /// </summary>
    [IsoId("_T2Oy8GAPEeiNMJ262H2pWg")]
    [DisplayName("Management Fee Source")]
    [IsoXmlTag("MgmtFeeSrc")]
    public AnnualChargePaymentType1Code? ManagementFeeSource { get; init; }

    /// <summary>
    /// Indicates whether there is a performance fee feature. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00045.
    /// </summary>
    [IsoId("_pAPSkGAPEeiNMJ262H2pWg")]
    [DisplayName("Performance Fee")]
    [IsoXmlTag("PrfrmncFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PerformanceFee { get; init; }

    /// <summary>
    /// Additional information about the fund.
    /// </summary>
    [IsoId("_OKRH8WAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
