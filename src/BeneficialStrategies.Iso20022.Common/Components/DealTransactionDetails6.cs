// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the triparty collateral transaction deal.
/// </summary>
[IsoId("_lpi_4RIcEeyLzJfz3xPQNA")]
[DisplayName("Deal Transaction Details")]
public record DealTransactionDetails6
{
    /// <summary>
    /// Identifies the number of days in which the cash investor and dealer can agree to revisit the terms of an agreement.
    /// </summary>
    [IsoId("_mAfgRRIcEeyLzJfz3xPQNA")]
    [DisplayName("Minimum Notice Period")]
    [IsoXmlTag("MinNtcePrd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? MinimumNoticePeriod { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_mAfgRxIcEeyLzJfz3xPQNA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public required ClosingDate4Choice_ ClosingDate { get; init; }

    /// <summary>
    /// Specifies the details for the deal amounts.
    /// </summary>
    [IsoId("_mAfgSRIcEeyLzJfz3xPQNA")]
    [DisplayName("Deal Details Amount")]
    [IsoXmlTag("DealDtlsAmt")]
    public CollateralAmount12? DealDetailsAmount { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount as agreed between the counterparties and the tenor of the interest rate index.
    /// </summary>
    [IsoId("_mAfgSxIcEeyLzJfz3xPQNA")]
    [DisplayName("Pricing Rate And Index")]
    [IsoXmlTag("PricgRateAndIndx")]
    public RateOrName4Choice_? PricingRateAndIndex { get; init; }

    /// <summary>
    /// Indicates for a floating rate transaction if an overnight frequency  rate fixing should be applied.  If not present, a periodic fixing frequency will be applied (default is N).
    /// </summary>
    [IsoId("_mAfgTRIcEeyLzJfz3xPQNA")]
    [DisplayName("Overnight Frequency Rate Fixing")]
    [IsoXmlTag("OvrnghtFrqcyRateFxg")]
    public FrequencyRateFixing1Choice_? OvernightFrequencyRateFixing { get; init; }

    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_mAfgTxIcEeyLzJfz3xPQNA")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Spread { get; init; }

    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_mAfgURIcEeyLzJfz3xPQNA")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies whether the instruction is free or against payment.
    /// </summary>
    [IsoId("_mAfgUxIcEeyLzJfz3xPQNA")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public DeliveryReceiptType2Code? Payment { get; init; }

    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_mAfgVRIcEeyLzJfz3xPQNA")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public OptionType6Choice_? OptionType { get; init; }

    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    [IsoId("_mAfgVxIcEeyLzJfz3xPQNA")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public RepoTerminationOption1Code? TerminationOption { get; init; }
}
