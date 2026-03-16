// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Instrument Attributes132.
/// </summary>
[IsoId("_STb3gYV9Ee-ufOxNNkEXmg")]
[DisplayName("Financial Instrument Attributes132")]
public record FinancialInstrumentAttributes132
{
    /// <summary>
    /// Classification Type.
    /// </summary>
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType32Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Contract Size.
    /// </summary>
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity33Choice_? ContractSize { get; init; }

    /// <summary>
    /// Conversion Date.
    /// </summary>
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Dated Date.
    /// </summary>
    [DisplayName("Dated Date")]
    [IsoXmlTag("DtdDt")]
    public IsoISODate? DatedDate { get; init; }

    /// <summary>
    /// Day Count Basis.
    /// </summary>
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Denomination Currency.
    /// </summary>
    [DisplayName("Denomination Currency")]
    [IsoXmlTag("DnmtnCcy")]
    public ActiveOrHistoricCurrencyCode? DenominationCurrency { get; init; }

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public IsoISODate? ExpiryDate { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Floating Rate Fixing Date.
    /// </summary>
    [DisplayName("Floating Rate Fixing Date")]
    [IsoXmlTag("FltgRateFxgDt")]
    public IsoISODate? FloatingRateFixingDate { get; init; }

    /// <summary>
    /// Interest Rate.
    /// </summary>
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public IsoPercentage14Rate? InterestRate { get; init; }

    /// <summary>
    /// Issue Date.
    /// </summary>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public IsoISODate? IssueDate { get; init; }

    /// <summary>
    /// Maturity Date.
    /// </summary>
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Minimum Nominal Quantity.
    /// </summary>
    [DisplayName("Minimum Nominal Quantity")]
    [IsoXmlTag("MinNmnlQty")]
    public FinancialInstrumentQuantity33Choice_? MinimumNominalQuantity { get; init; }

    /// <summary>
    /// Next Callable Date.
    /// </summary>
    [DisplayName("Next Callable Date")]
    [IsoXmlTag("NxtCllblDt")]
    public IsoISODate? NextCallableDate { get; init; }

    /// <summary>
    /// Next Coupon Date.
    /// </summary>
    [DisplayName("Next Coupon Date")]
    [IsoXmlTag("NxtCpnDt")]
    public IsoISODate? NextCouponDate { get; init; }

    /// <summary>
    /// Next Factor.
    /// </summary>
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public IsoBaseOne14Rate? NextFactor { get; init; }

    /// <summary>
    /// Next Interest Rate.
    /// </summary>
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    public IsoPercentage14Rate? NextInterestRate { get; init; }

    /// <summary>
    /// Place Of Listing.
    /// </summary>
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification3Choice_? PlaceOfListing { get; init; }

    /// <summary>
    /// Previous Factor.
    /// </summary>
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public IsoBaseOne14Rate? PreviousFactor { get; init; }

    /// <summary>
    /// Putable Date.
    /// </summary>
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    public IsoISODate? PutableDate { get; init; }
}
