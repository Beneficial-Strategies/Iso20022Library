// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates.
/// </summary>
[IsoId("_Tf2JBdp-Ed-ak6NoX_4Aeg_-1452767156")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate1
{
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_Tf2JBtp-Ed-ak6NoX_4Aeg_-2054958770")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public RateAndAmountFormat1Choice_? Interest { get; init; }

    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_Tf2JB9p-Ed-ak6NoX_4Aeg_-1563128851")]
    [DisplayName("Related Index")]
    [IsoXmlTag("RltdIndx")]
    public RateFormat1Choice_? RelatedIndex { get; init; }

    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_Tf2JCNp-Ed-ak6NoX_4Aeg_-2024233567")]
    [DisplayName("Percentage Sought")]
    [IsoXmlTag("PctgSght")]
    public RateFormat1Choice_? PercentageSought { get; init; }

    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_Tf_6ANp-Ed-ak6NoX_4Aeg_-613289454")]
    [DisplayName("Reinvestment Discount To Market")]
    [IsoXmlTag("RinvstmtDscntToMkt")]
    public RateFormat1Choice_? ReinvestmentDiscountToMarket { get; init; }

    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_Tf_6Adp-Ed-ak6NoX_4Aeg_377917731")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public RateFormat1Choice_? Spread { get; init; }

    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_Tf_6Atp-Ed-ak6NoX_4Aeg_440695672")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public AmountAndRateFormat3Choice_? BidInterval { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_Tf_6A9p-Ed-ak6NoX_4Aeg_-733274509")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public RateAndAmountFormat1Choice_? Charges { get; init; }
}
