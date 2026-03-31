// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
[IsoId("_Tyn7Hdp-Ed-ak6NoX_4Aeg_673552870")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes6
{
    /// <summary>
    /// Identification of a financial instrument.
    /// </summary>
    [IsoId("_Tyn7Htp-Ed-ak6NoX_4Aeg_673552872")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification11? SecurityIdentification { get; init; }

    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_TyxsENp-Ed-ak6NoX_4Aeg_673552913")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification2? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_TyxsEdp-Ed-ak6NoX_4Aeg_673552930")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_TyxsEtp-Ed-ak6NoX_4Aeg_673552948")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType2Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_TyxsE9p-Ed-ak6NoX_4Aeg_673552983")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_TyxsFNp-Ed-ak6NoX_4Aeg_673553225")]
    [DisplayName("Next Coupon Date")]
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCouponDate { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_TyxsFdp-Ed-ak6NoX_4Aeg_673553242")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    [IsoId("_TyxsFtp-Ed-ak6NoX_4Aeg_673553260")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_TyxsF9p-Ed-ak6NoX_4Aeg_673553285")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date on which the financial instrument is issued.
    /// </summary>
    [IsoId("_Ty62ANp-Ed-ak6NoX_4Aeg_673553302")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    [IsoId("_Ty62Adp-Ed-ak6NoX_4Aeg_673553320")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    [IsoId("_Ty62Atp-Ed-ak6NoX_4Aeg_673553337")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    [IsoId("_Ty62A9p-Ed-ak6NoX_4Aeg_910894710")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    [IsoId("_Ty62BNp-Ed-ak6NoX_4Aeg_910894727")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_Ty62Bdp-Ed-ak6NoX_4Aeg_-1182634448")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PreviousFactor { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_Ty62Btp-Ed-ak6NoX_4Aeg_-1182633921")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextFactor { get; init; }

    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_Ty62B9p-Ed-ak6NoX_4Aeg_910894762")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_TzEnANp-Ed-ak6NoX_4Aeg_910894780")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? NextInterestRate { get; init; }

    /// <summary>
    /// Also known as Minimum Nominal Value. Minimum nominal quantity of financial instrument that must be purchased/sold.
    /// </summary>
    [IsoId("_TzEnAdp-Ed-ak6NoX_4Aeg_910894995")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TzEnAtp-Ed-ak6NoX_4Aeg_910895237")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TzEnA9p-Ed-ak6NoX_4Aeg_910895272")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    [IsoId("_TzEnBNp-Ed-ak6NoX_4Aeg_910895289")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; }
}
