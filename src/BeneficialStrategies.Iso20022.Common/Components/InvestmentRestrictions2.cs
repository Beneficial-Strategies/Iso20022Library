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
/// Investment restrictions linked to the instrument.
/// </summary>
[IsoId("_ScM6utp-Ed-ak6NoX_4Aeg_841139560")]
[DisplayName("Investment Restrictions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentRestrictions2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentRestrictions2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentRestrictions2( HoldingTransferable1Code reqHoldingTransferable )
    {
        HoldingTransferable = reqHoldingTransferable;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum initial quantity of securities, expressed as an amount that must be purchased at subscription.
    /// </summary>
    [IsoId("_ScM6u9p-Ed-ak6NoX_4Aeg_842059571")]
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
    [IsoId("_ScWEoNp-Ed-ak6NoX_4Aeg_842059623")]
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
    /// Minimum quantity of securities, expressed as an amount that must be purchased.
    /// </summary>
    [IsoId("_ScWEodp-Ed-ak6NoX_4Aeg_842059715")]
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
    [IsoId("_ScWEotp-Ed-ak6NoX_4Aeg_842059654")]
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
    /// Maximum quantity of securities, expressed as an amount that can be sold.
    /// </summary>
    [IsoId("_ScWEo9p-Ed-ak6NoX_4Aeg_842059746")]
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
    [IsoId("_ScWEpNp-Ed-ak6NoX_4Aeg_842059807")]
    [DisplayName("Maximum Redemption Units")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxRedUnits")]
    #endif
    [IsoXmlTag("MaxRedUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumRedemptionUnits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumRedemptionUnits { get; init; } 
    #else
    public System.UInt64? MaximumRedemptionUnits { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies any other restrictions that may limit an investor&apos;s ability to redeem.
    /// </summary>
    [IsoId("_ScWEpdp-Ed-ak6NoX_4Aeg_842059838")]
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
    /// Minimum value of units that must be maintained to avoid automatic redemption.
    /// </summary>
    [IsoId("_ScWEptp-Ed-ak6NoX_4Aeg_842059868")]
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
    [IsoId("_ScWEp9p-Ed-ak6NoX_4Aeg_842060116")]
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
    /// Description of a period, that may be a number of days, weeks or descriptive period during which the units/shares must be held following their issue before redemption will be permitted.
    /// </summary>
    [IsoId("_ScWEqNp-Ed-ak6NoX_4Aeg_842060146")]
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
    /// Indicates whether registered investors are able to transfer some or all of their holdings to third parties.
    /// </summary>
    [IsoId("_ScWEqdp-Ed-ak6NoX_4Aeg_842060177")]
    [DisplayName("Holding Transferable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldgTrfbl")]
    #endif
    [IsoXmlTag("HldgTrfbl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required HoldingTransferable1Code HoldingTransferable { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required HoldingTransferable1Code HoldingTransferable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HoldingTransferable1Code HoldingTransferable { get; init; } 
    #else
    public HoldingTransferable1Code HoldingTransferable { get; set; } 
    #endif
    
    
    #nullable disable
    
}
