// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Instrument Attributes136.
/// </summary>
[IsoId("_nLXU-5t3Ee-wQIOX0djF2w")]
[DisplayName("Financial Instrument Attributes136")]
public partial record FinancialInstrumentAttributes136
{
    #nullable enable

    /// <summary>
    /// Classification Type.
    /// </summary>
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public ClassificationType33Choice_? ClassificationType { get; init; } 

    /// <summary>
    /// Contract Size.
    /// </summary>
    [DisplayName("Contract Size")]
    [IsoXmlTag("CtrctSz")]
    public FinancialInstrumentQuantity36Choice_? ContractSize { get; init; } 

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
    public InterestComputationMethodFormat5Choice_? DayCountBasis { get; init; } 

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
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 

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
    public RateFormat24Choice_? InterestRate { get; init; } 

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
    public FinancialInstrumentQuantity36Choice_? MinimumNominalQuantity { get; init; } 

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
    public RateFormat12Choice_? NextFactor { get; init; } 

    /// <summary>
    /// Next Interest Rate.
    /// </summary>
    [DisplayName("Next Interest Rate")]
    [IsoXmlTag("NxtIntrstRate")]
    public RateFormat24Choice_? NextInterestRate { get; init; } 

    /// <summary>
    /// Option Style.
    /// </summary>
    [DisplayName("Option Style")]
    [IsoXmlTag("OptnStyle")]
    public OptionStyle9Choice_? OptionStyle { get; init; } 

    /// <summary>
    /// Percentage Of Debt Claim.
    /// </summary>
    [DisplayName("Percentage Of Debt Claim")]
    [IsoXmlTag("PctgOfDebtClm")]
    public RateFormat24Choice_? PercentageOfDebtClaim { get; init; } 

    /// <summary>
    /// Place Of Listing.
    /// </summary>
    [DisplayName("Place Of Listing")]
    [IsoXmlTag("PlcOfListg")]
    public MarketIdentification4Choice_? PlaceOfListing { get; init; } 

    /// <summary>
    /// Previous Factor.
    /// </summary>
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat12Choice_? PreviousFactor { get; init; } 

    /// <summary>
    /// Putable Date.
    /// </summary>
    [DisplayName("Putable Date")]
    [IsoXmlTag("PutblDt")]
    public IsoISODate? PutableDate { get; init; } 

    /// <summary>
    /// Warrant Parity.
    /// </summary>
    [DisplayName("Warrant Parity")]
    [IsoXmlTag("WarrtParity")]
    public QuantityToQuantityRatio2? WarrantParity { get; init; } 

    
    #nullable disable
    
}
