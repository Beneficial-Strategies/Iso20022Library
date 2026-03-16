// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates of a corporate action.
/// </summary>
[IsoId("_CTPKMRIyEeKKuerhIbkpig")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate35
{
    /// <summary>
    /// Annual rate of a financial instrument.
    /// </summary>
    [IsoId("_CrFCdRIyEeKKuerhIbkpig")]
    [DisplayName("Interest")]
    [IsoXmlTag("Intrst")]
    public RateAndAmountFormat14Choice_? Interest { get; init; }

    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event.
    /// </summary>
    [IsoId("_CrFCfxIyEeKKuerhIbkpig")]
    [DisplayName("Percentage Sought")]
    [IsoXmlTag("PctgSght")]
    public RateFormat7Choice_? PercentageSought { get; init; }

    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_CrFCiRIyEeKKuerhIbkpig")]
    [DisplayName("Related Index")]
    [IsoXmlTag("RltdIndx")]
    public RateFormat6Choice_? RelatedIndex { get; init; }

    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_CrFCkxIyEeKKuerhIbkpig")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public RateFormat6Choice_? Spread { get; init; }

    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_CrFCnRIyEeKKuerhIbkpig")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat14Choice_? BidInterval { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_CrFCpxIyEeKKuerhIbkpig")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat3Choice_? PreviousFactor { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_CrFCsRIyEeKKuerhIbkpig")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat3Choice_? NextFactor { get; init; }

    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_CrFCuxIyEeKKuerhIbkpig")]
    [DisplayName("Reinvestment Discount Rate To Market")]
    [IsoXmlTag("RinvstmtDscntRateToMkt")]
    public RateFormat6Choice_? ReinvestmentDiscountRateToMarket { get; init; }

    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the interest payment and the expected or scheduled rate of the interest payment.
    /// </summary>
    [IsoId("_CrFCxRIyEeKKuerhIbkpig")]
    [DisplayName("Interest Shortfall")]
    [IsoXmlTag("IntrstShrtfll")]
    public RateAndAmountFormat12Choice_? InterestShortfall { get; init; }

    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the capital or principal repayment and the scheduled capital repayment.
    /// </summary>
    [IsoId("_CrFCyRIyEeKKuerhIbkpig")]
    [DisplayName("Realised Loss")]
    [IsoXmlTag("RealsdLoss")]
    public RateAndAmountFormat12Choice_? RealisedLoss { get; init; }

    /// <summary>
    /// Dividend or interest rate declared by the issuer.
    /// </summary>
    [IsoId("_oDZjwBIyEeKKuerhIbkpig")]
    [DisplayName("Declared Rate")]
    [IsoXmlTag("DclrdRate")]
    public RateAndAmountFormat12Choice_? DeclaredRate { get; init; }
}
