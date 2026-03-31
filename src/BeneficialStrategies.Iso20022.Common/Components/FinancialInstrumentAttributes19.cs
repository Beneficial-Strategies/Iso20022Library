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
[IsoId("_eHGMteaUEd-q8fx_Zl_34A")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes19
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_eHGMt-aUEd-q8fx_Zl_34A")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }

    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_eHGMueaUEd-q8fx_Zl_34A")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification2? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_eHGMu-aUEd-q8fx_Zl_34A")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat1Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_eHGMveaUEd-q8fx_Zl_34A")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType2Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised.
    /// </summary>
    [IsoId("_eHGMv-aUEd-q8fx_Zl_34A")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle4Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_eHGMweaUEd-q8fx_Zl_34A")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_eHGMw-aUEd-q8fx_Zl_34A")]
    [DisplayName("Next Coupon Date")]
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCouponDate { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_eHGMxeaUEd-q8fx_Zl_34A")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    [IsoId("_eHGMx-aUEd-q8fx_Zl_34A")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_eHGMyeaUEd-q8fx_Zl_34A")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date on which the financial instrument is issued.
    /// </summary>
    [IsoId("_eHGMy-aUEd-q8fx_Zl_34A")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    [IsoId("_eHGMzeaUEd-q8fx_Zl_34A")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    [IsoId("_eHGMz-aUEd-q8fx_Zl_34A")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    [IsoId("_eHGM0eaUEd-q8fx_Zl_34A")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    [IsoId("_eHGM0-aUEd-q8fx_Zl_34A")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_eHGM1eaUEd-q8fx_Zl_34A")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public RateFormat3Choice_? InterestRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_eHGM1-aUEd-q8fx_Zl_34A")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    public RateFormat3Choice_? NextInterestRate { get; init; }

    /// <summary>
    /// Percentage of the underlying assets of a fund that represents a debt and is in the scope of the EU Savings directive.
    /// </summary>
    [IsoId("_eHGM2eaUEd-q8fx_Zl_34A")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    public RateFormat3Choice_? PercentageOfDebtClaim { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_eHGM2-aUEd-q8fx_Zl_34A")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat3Choice_? PreviousFactor { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_eHGM3eaUEd-q8fx_Zl_34A")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat3Choice_? NextFactor { get; init; }

    /// <summary>
    /// Also known as Minimum Nominal Value. Minimum nominal quantity of financial instrument that must be purchased/sold.
    /// </summary>
    [IsoId("_eHGM3-aUEd-q8fx_Zl_34A")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_eHGM4eaUEd-q8fx_Zl_34A")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_eHGM4-aUEd-q8fx_Zl_34A")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    [IsoId("_eHGM5eaUEd-q8fx_Zl_34A")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity1Choice_? ContractSize { get; init; }
}
