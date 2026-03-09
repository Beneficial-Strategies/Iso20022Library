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
/// Investment restrictions linked to the trading of an investment fund, or an alternative/hedge fund.
/// </summary>
[IsoId("_Sp4ScV88Eeicg40_9gK9vQ")]
[DisplayName("Investment Restrictions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentRestrictions3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum initial quantity of securities, expressed as an amount, that must be purchased at subscription.
    /// </summary>
    [IsoId("_S5y9w188Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Initial Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinInitlSbcptAmt")]
    #endif
    [IsoXmlTag("MinInitlSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumInitialSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumInitialSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumInitialSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum initial number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_S5y9xV88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Initial Subscription Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinInitlSbcptUnits")]
    #endif
    [IsoXmlTag("MinInitlSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MinimumInitialSubscriptionUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumInitialSubscriptionUnits { get; init; } 
    #else
    public System.UInt64? MinimumInitialSubscriptionUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities, expressed as an amount, that must be purchased.
    /// </summary>
    [IsoId("_S5y9x188Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Subsequent Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSbsqntSbcptAmt")]
    #endif
    [IsoXmlTag("MinSbsqntSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumSubsequentSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumSubsequentSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumSubsequentSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_S5y9yV88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Subsequent Subscription Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSbsqntSbcptUnits")]
    #endif
    [IsoXmlTag("MinSbsqntSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MinimumSubsequentSubscriptionUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumSubsequentSubscriptionUnits { get; init; } 
    #else
    public System.UInt64? MinimumSubsequentSubscriptionUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum quantity of securities, expressed as an amount, that can be sold. 
    /// </summary>
    [IsoId("_S5y9y188Eeicg40_9gK9vQ")]
    [DisplayName("Maximum Redemption Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxRedAmt")]
    #endif
    [IsoXmlTag("MaxRedAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MaximumRedemptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MaximumRedemptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MaximumRedemptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of shares/units that may be redeemed on a single dealing day.
    /// </summary>
    [IsoId("_S5y9zV88Eeicg40_9gK9vQ")]
    [DisplayName("Maximum Redemption Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxRedUnits")]
    #endif
    [IsoXmlTag("MaxRedUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? MaximumRedemptionUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumRedemptionUnits { get; init; } 
    #else
    public System.UInt64? MaximumRedemptionUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum percentage of holding that may be redeemed.
    /// </summary>
    [IsoId("_0VZA0N6eEei9RJrL5H7TLQ")]
    [DisplayName("Minimum Redemption Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinRedPctg")]
    #endif
    [IsoXmlTag("MinRedPctg")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? MinimumRedemptionPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumRedemptionPercentage { get; init; } 
    #else
    public System.UInt64? MinimumRedemptionPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies any other restrictions that may limit an investor&apos;s ability to redeem.
    /// </summary>
    [IsoId("_S5y9z188Eeicg40_9gK9vQ")]
    [DisplayName("Other Redemption Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRedRstrctns")]
    #endif
    [IsoXmlTag("OthrRedRstrctns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? OtherRedemptionRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherRedemptionRestrictions { get; init; } 
    #else
    public System.String? OtherRedemptionRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities, expressed as an amount, that must be purchased.
    /// </summary>
    [IsoId("_zKI5MN6fEei9RJrL5H7TLQ")]
    [DisplayName("Minimum Switch Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSwtchSbcptAmt")]
    #endif
    [IsoXmlTag("MinSwtchSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumSwitchSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumSwitchSubscriptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumSwitchSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_8WiXUN6fEei9RJrL5H7TLQ")]
    [DisplayName("Minimum Switch Subscription Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinSwtchSbcptUnits")]
    #endif
    [IsoXmlTag("MinSwtchSbcptUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? MinimumSwitchSubscriptionUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumSwitchSubscriptionUnits { get; init; } 
    #else
    public System.UInt64? MinimumSwitchSubscriptionUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum quantity of securities, expressed as an amount, that can be sold. 
    /// </summary>
    [IsoId("_kS7MwF88Eeicg40_9gK9vQ")]
    [DisplayName("Maximum Switch Redemption Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSwtchRedAmt")]
    #endif
    [IsoXmlTag("MaxSwtchRedAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MaximumSwitchRedemptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MaximumSwitchRedemptionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MaximumSwitchRedemptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of shares/units that may be redeemed on a single dealing day.
    /// </summary>
    [IsoId("_CNJlYN6gEei9RJrL5H7TLQ")]
    [DisplayName("Maximum Switch Redemption Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSwtchRedUnits")]
    #endif
    [IsoXmlTag("MaxSwtchRedUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? MaximumSwitchRedemptionUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumSwitchRedemptionUnits { get; init; } 
    #else
    public System.UInt64? MaximumSwitchRedemptionUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies any other restrictions that may limit an investor&apos;s ability to switch.
    /// </summary>
    [IsoId("_1coDMF89Eeicg40_9gK9vQ")]
    [DisplayName("Other Switch Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrSwtchRstrctns")]
    #endif
    [IsoXmlTag("OthrSwtchRstrctns")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? OtherSwitchRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherSwitchRestrictions { get; init; } 
    #else
    public System.String? OtherSwitchRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum value of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_S5y90V88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Holding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinHldgAmt")]
    #endif
    [IsoXmlTag("MinHldgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MinimumHoldingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MinimumHoldingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MinimumHoldingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_S5y90188Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Holding Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinHldgUnits")]
    #endif
    [IsoXmlTag("MinHldgUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? MinimumHoldingUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MinimumHoldingUnits { get; init; } 
    #else
    public System.UInt64? MinimumHoldingUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the period, that may be a number of days or weeks or another way of describing the period, during which the units/shares must be held following their issue before redemption will be permitted.
    /// </summary>
    [IsoId("_S5y91V88Eeicg40_9gK9vQ")]
    [DisplayName("Minimum Holding Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinHldgPrd")]
    #endif
    [IsoXmlTag("MinHldgPrd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? MinimumHoldingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MinimumHoldingPeriod { get; init; } 
    #else
    public System.String? MinimumHoldingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how registered investors are able to transfer some or all of their holdings to third parties.
    /// </summary>
    [IsoId("_S5y91188Eeicg40_9gK9vQ")]
    [DisplayName("Holding Transferable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgTrfbl")]
    #endif
    [IsoXmlTag("HldgTrfbl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HoldingTransferable1Code? HoldingTransferable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HoldingTransferable1Code? HoldingTransferable { get; init; } 
    #else
    public HoldingTransferable1Code? HoldingTransferable { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the investment restrictions.
    /// </summary>
    [IsoId("_Val68WAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
