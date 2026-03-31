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
[IsoId("_x_DvRR9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate110
{
    /// <summary>
    /// Annualised interest rate of a financial instrument used to calculate the actual interest rate of the coupon or the accrued interest.
    /// </summary>
    [IsoId("_x_DvSx9REeuFz_FaCzCLgQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public RateAndAmountFormat46Choice_? InterestRate { get; init; }

    /// <summary>
    /// Percentage of securities the offeror/issuer will purchase or redeem under the terms of the event.
    /// </summary>
    [IsoId("_x_DvUx9REeuFz_FaCzCLgQ")]
    [DisplayName("Percentage Sought")]
    [IsoXmlTag("PctgSght")]
    public RateFormat7Choice_? PercentageSought { get; init; }

    /// <summary>
    /// Index rate related to the interest rate of the forthcoming interest payment.
    /// </summary>
    [IsoId("_x_DvWx9REeuFz_FaCzCLgQ")]
    [DisplayName("Related Index")]
    [IsoXmlTag("RltdIndx")]
    public RateFormat3Choice_? RelatedIndex { get; init; }

    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_x_DvYx9REeuFz_FaCzCLgQ")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public RateFormat3Choice_? Spread { get; init; }

    /// <summary>
    /// Acceptable price increment used for submitting a bid.
    /// </summary>
    [IsoId("_x_Dvax9REeuFz_FaCzCLgQ")]
    [DisplayName("Bid Interval")]
    [IsoXmlTag("BidIntrvl")]
    public RateAndAmountFormat50Choice_? BidInterval { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) until the next redemption (factor) date.
    /// </summary>
    [IsoId("_x_Dvcx9REeuFz_FaCzCLgQ")]
    [DisplayName("Previous Factor")]
    [IsoXmlTag("PrvsFctr")]
    public RateFormat12Choice_? PreviousFactor { get; init; }

    /// <summary>
    /// Factor used to calculate the value of the outstanding principal of the financial instrument (for factored securities) that will applicable after the redemption (factor) date.
    /// </summary>
    [IsoId("_x_Dvex9REeuFz_FaCzCLgQ")]
    [DisplayName("Next Factor")]
    [IsoXmlTag("NxtFctr")]
    public RateFormat12Choice_? NextFactor { get; init; }

    /// <summary>
    /// Rate of discount for securities purchased through a reinvestment scheme as compared to the current market price of security.
    /// </summary>
    [IsoId("_x_Dvgx9REeuFz_FaCzCLgQ")]
    [DisplayName("Reinvestment Discount Rate To Market")]
    [IsoXmlTag("RinvstmtDscntRateToMkt")]
    public RateFormat3Choice_? ReinvestmentDiscountRateToMarket { get; init; }

    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the interest payment and the expected or scheduled rate of the interest payment.
    /// </summary>
    [IsoId("_x_Dvix9REeuFz_FaCzCLgQ")]
    [DisplayName("Interest Shortfall")]
    [IsoXmlTag("IntrstShrtfll")]
    public RateAndAmountFormat43Choice_? InterestShortfall { get; init; }

    /// <summary>
    /// For structured security issues where there is a set schedule of principal and interest payments for the life of the issue, this is the difference between the actual rate of the capital or principal repayment and the scheduled capital repayment.
    /// </summary>
    [IsoId("_x_DvjR9REeuFz_FaCzCLgQ")]
    [DisplayName("Realised Loss")]
    [IsoXmlTag("RealsdLoss")]
    public RateAndAmountFormat43Choice_? RealisedLoss { get; init; }

    /// <summary>
    /// Dividend or interest rate declared by the issuer.
    /// </summary>
    [IsoId("_x_Dvjx9REeuFz_FaCzCLgQ")]
    [DisplayName("Declared Rate")]
    [IsoXmlTag("DclrdRate")]
    public RateAndAmountFormat43Choice_? DeclaredRate { get; init; }

    /// <summary>
    /// Public index rate applied to the amount paid to adjust it to inflation.
    /// </summary>
    [IsoId("_x_DvkR9REeuFz_FaCzCLgQ")]
    [DisplayName("Index Factor")]
    [IsoXmlTag("IndxFctr")]
    public RateAndAmountFormat37Choice_? IndexFactor { get; init; }
}
