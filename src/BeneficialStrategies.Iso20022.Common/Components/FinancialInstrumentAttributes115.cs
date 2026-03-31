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
[IsoId("_ptK3szi7Eeydid5dcNPKvg")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes115
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_ptK3uzi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_ptK3wzi7Eeydid5dcNPKvg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification4Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_ptK3yzi7Eeydid5dcNPKvg")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_ptK30zi7Eeydid5dcNPKvg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType33Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised.
    /// </summary>
    [IsoId("_ptK32zi7Eeydid5dcNPKvg")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle9Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_ptK34zi7Eeydid5dcNPKvg")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_ptK36zi7Eeydid5dcNPKvg")]
    [DisplayName("Next Coupon Date")]
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCouponDate { get; init; }

    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    [IsoId("_ptK38zi7Eeydid5dcNPKvg")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_ptK3-zi7Eeydid5dcNPKvg")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date at which the security was made available.
    /// </summary>
    [IsoId("_ptK4Azi7Eeydid5dcNPKvg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    [IsoId("_ptK4Czi7Eeydid5dcNPKvg")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    [IsoId("_ptK4Ezi7Eeydid5dcNPKvg")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    [IsoId("_ptK4Gzi7Eeydid5dcNPKvg")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    [IsoId("_ptK4Izi7Eeydid5dcNPKvg")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_ptK4Kzi7Eeydid5dcNPKvg")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat12Choice_? PreviousFactor { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_ptK4Mzi7Eeydid5dcNPKvg")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat12Choice_? NextFactor { get; init; }

    /// <summary>
    /// Annualised interest rate of a financial instrument used to calculate the actual interest rate of the coupon or the accrued interest.
    /// </summary>
    [IsoId("_ptK4Ozi7Eeydid5dcNPKvg")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public RateFormat3Choice_? InterestRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_ptK4Qzi7Eeydid5dcNPKvg")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    public RateFormat3Choice_? NextInterestRate { get; init; }

    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    [IsoId("_ptK4Szi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity36Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_ptK4Uzi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Quantity To Instruct")]
    [IsoXmlTag("MinQtyToInst")]
    public FinancialInstrumentQuantity36Choice_? MinimumQuantityToInstruct { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_ptK4Wzi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Multiple Quantity To Instruct")]
    [IsoXmlTag("MinMltplQtyToInst")]
    public FinancialInstrumentQuantity36Choice_? MinimumMultipleQuantityToInstruct { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    [IsoId("_ptK4Yzi7Eeydid5dcNPKvg")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity36Choice_? ContractSize { get; init; }

    /// <summary>
    /// Initial issue/valuation price of a resulting security under a corporate action.
    /// </summary>
    [IsoId("_ptK4azi7Eeydid5dcNPKvg")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat57Choice_? IssuePrice { get; init; }
}
