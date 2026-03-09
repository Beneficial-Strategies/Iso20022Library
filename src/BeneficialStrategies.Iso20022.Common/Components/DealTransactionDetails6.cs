// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the triparty collateral transaction deal.
/// </summary>
[IsoId("_lpi_4RIcEeyLzJfz3xPQNA")]
[DisplayName("Deal Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DealTransactionDetails6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DealTransactionDetails6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DealTransactionDetails6( ClosingDate4Choice_ reqClosingDate )
    {
        ClosingDate = reqClosingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the number of days in which the cash investor and dealer can agree to revisit the terms of an agreement.
    /// </summary>
    [IsoId("_mAfgRRIcEeyLzJfz3xPQNA")]
    [DisplayName("Minimum Notice Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNtcePrd")]
    #endif
    [IsoXmlTag("MinNtcePrd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? MinimumNoticePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MinimumNoticePeriod { get; init; } 
    #else
    public System.String? MinimumNoticePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_mAfgRxIcEeyLzJfz3xPQNA")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingDate4Choice_ ClosingDate { get; init; } 
    #else
    public ClosingDate4Choice_ ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the details for the deal amounts.
    /// </summary>
    [IsoId("_mAfgSRIcEeyLzJfz3xPQNA")]
    [DisplayName("Deal Details Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealDtlsAmt")]
    #endif
    [IsoXmlTag("DealDtlsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAmount12? DealDetailsAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAmount12? DealDetailsAmount { get; init; } 
    #else
    public CollateralAmount12? DealDetailsAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount as agreed between the counterparties and the tenor of the interest rate index.
    /// </summary>
    [IsoId("_mAfgSxIcEeyLzJfz3xPQNA")]
    [DisplayName("Pricing Rate And Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgRateAndIndx")]
    #endif
    [IsoXmlTag("PricgRateAndIndx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateOrName4Choice_? PricingRateAndIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrName4Choice_? PricingRateAndIndex { get; init; } 
    #else
    public RateOrName4Choice_? PricingRateAndIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates for a floating rate transaction if an overnight frequency  rate fixing should be applied.  If not present, a periodic fixing frequency will be applied (default is N).
    /// </summary>
    [IsoId("_mAfgTRIcEeyLzJfz3xPQNA")]
    [DisplayName("Overnight Frequency Rate Fixing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrnghtFrqcyRateFxg")]
    #endif
    [IsoXmlTag("OvrnghtFrqcyRateFxg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FrequencyRateFixing1Choice_? OvernightFrequencyRateFixing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FrequencyRateFixing1Choice_? OvernightFrequencyRateFixing { get; init; } 
    #else
    public FrequencyRateFixing1Choice_? OvernightFrequencyRateFixing { get; set; } 
    #endif
    
    /// <summary>
    /// Margin allowed over or under a given rate.
    /// </summary>
    [IsoId("_mAfgTxIcEeyLzJfz3xPQNA")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Spread { get; init; } 
    #else
    public System.Decimal? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_mAfgURIcEeyLzJfz3xPQNA")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the instruction is free or against payment.
    /// </summary>
    [IsoId("_mAfgUxIcEeyLzJfz3xPQNA")]
    [DisplayName("Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pmt")]
    #endif
    [IsoXmlTag("Pmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReceiptType2Code? Payment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code? Payment { get; init; } 
    #else
    public DeliveryReceiptType2Code? Payment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_mAfgVRIcEeyLzJfz3xPQNA")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType6Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType6Choice_? OptionType { get; init; } 
    #else
    public OptionType6Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    [IsoId("_mAfgVxIcEeyLzJfz3xPQNA")]
    [DisplayName("Termination Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnOptn")]
    #endif
    [IsoXmlTag("TermntnOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    #else
    public RepoTerminationOption1Code? TerminationOption { get; set; } 
    #endif
    
    
    #nullable disable
    
}
