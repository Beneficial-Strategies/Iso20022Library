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
[IsoId("_ctOxH5KQEeWHWpTQn1FFVg")]
[DisplayName("Financial Instrument Attributes")]
public record FinancialInstrumentAttributes70
{
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_ctOxJZKQEeWHWpTQn1FFVg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_ctOxLZKQEeWHWpTQn1FFVg")]
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification4Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_ctOxNZKQEeWHWpTQn1FFVg")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_ctOxPZKQEeWHWpTQn1FFVg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType33Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Specifies how an option can be exercised.
    /// </summary>
    [IsoId("_ctOxRZKQEeWHWpTQn1FFVg")]
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle9Choice_? OptionStyle { get; init; }

    /// <summary>
    /// Currency in which a financial instrument is currently denominated.
    /// </summary>
    [IsoId("_ctOxTZKQEeWHWpTQn1FFVg")]
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Next payment date of an interest bearing financial instrument.
    /// </summary>
    [IsoId("_ctOxVZKQEeWHWpTQn1FFVg")]
    [DisplayName("Next Coupon Date")]
    [IsoXmlTag("NxtCpnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCouponDate { get; init; }

    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_ctOxXZKQEeWHWpTQn1FFVg")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Date on which the interest rate or redemption price will be/was calculated according to the terms of the issue.
    /// </summary>
    [IsoId("_ctOxZZKQEeWHWpTQn1FFVg")]
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument becomes due and assets are to be repaid.
    /// </summary>
    [IsoId("_ctOxbZKQEeWHWpTQn1FFVg")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Date on which the financial instrument is issued.
    /// </summary>
    [IsoId("_ctOxdZKQEeWHWpTQn1FFVg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Date on which a financial instrument is called away/redeemed before its scheduled maturity.
    /// </summary>
    [IsoId("_ctOxfZKQEeWHWpTQn1FFVg")]
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Date on which a holder of a financial instrument has the right to request redemption of the principal amount prior to its scheduled maturity date.
    /// </summary>
    [IsoId("_ctOxhZKQEeWHWpTQn1FFVg")]
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PutableDate { get; init; }

    /// <summary>
    /// Date on which an interest bearing financial instrument begins to accrue interest.
    /// </summary>
    [IsoId("_ctOxjZKQEeWHWpTQn1FFVg")]
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Deadline by which a convertible security must be converted, according to the terms of the issue.
    /// </summary>
    [IsoId("_ctOxlZKQEeWHWpTQn1FFVg")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_ctOxnZKQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public RateFormat3Choice_? InterestRate { get; init; }

    /// <summary>
    /// Interest rate applicable to the next interest payment period in relation to variable rate instruments.
    /// </summary>
    [IsoId("_ctOxpZKQEeWHWpTQn1FFVg")]
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    public RateFormat3Choice_? NextInterestRate { get; init; }

    /// <summary>
    /// Percentage of the underlying assets of a fund that represents a debt, for example, in the context of the EU Savings directive.
    /// </summary>
    [IsoId("_ctOxrZKQEeWHWpTQn1FFVg")]
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    public RateFormat3Choice_? PercentageOfDebtClaim { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_ctOxtZKQEeWHWpTQn1FFVg")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat12Choice_? PreviousFactor { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_ctOxvZKQEeWHWpTQn1FFVg")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat12Choice_? NextFactor { get; init; }

    /// <summary>
    /// Provides the ratio between the quantity of warrants and the quantity of underlying securities.
    /// </summary>
    [IsoId("_ctOxxZKQEeWHWpTQn1FFVg")]
    [DisplayName("Warrant Parity")]
    [IsoXmlTag("WarrtParity")]
    public QuantityToQuantityRatio2? WarrantParity { get; init; }

    /// <summary>
    /// Minimum nominal quantity of financial instrument.
    /// </summary>
    [IsoId("_ctOxx5KQEeWHWpTQn1FFVg")]
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity15Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Ratio or multiplying factor used to convert one contract into a financial instrument quantity.
    /// </summary>
    [IsoId("_ctOxz5KQEeWHWpTQn1FFVg")]
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity15Choice_? ContractSize { get; init; }
}
