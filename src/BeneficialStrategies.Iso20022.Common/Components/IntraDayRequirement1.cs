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
/// Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.
/// </summary>
[IsoId("_vFk_wKp1EeamNLogr5TkIQ")]
[DisplayName("Intra Day Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraDayRequirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraDayRequirement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraDayRequirement1( ActiveCurrencyAndAmount reqIntraDayMarginCall,ActiveCurrencyAndAmount reqPeakInitialMarginLiability,ActiveCurrencyAndAmount reqPeakVariationMarginLiability,ActiveCurrencyAndAmount reqAggregatePeakLiability,GenericIdentification165 reqMarginAccountIdentification )
    {
        IntraDayMarginCall = reqIntraDayMarginCall;
        PeakInitialMarginLiability = reqPeakInitialMarginLiability;
        PeakVariationMarginLiability = reqPeakVariationMarginLiability;
        AggregatePeakLiability = reqAggregatePeakLiability;
        MarginAccountIdentification = reqMarginAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total aggregate value of collateral called intraday, excluding repayments.
    /// </summary>
    [IsoId("_tJOLUKp2EeamNLogr5TkIQ")]
    [DisplayName("Intra Day Margin Call")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraDayMrgnCall")]
    #endif
    [IsoXmlTag("IntraDayMrgnCall")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount IntraDayMarginCall { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount IntraDayMarginCall { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount IntraDayMarginCall { get; init; } 
    #else
    public ActiveCurrencyAndAmount IntraDayMarginCall { get; set; } 
    #endif
    
    /// <summary>
    /// Peak increase in initial margin liability for the account during the day.
    /// </summary>
    [IsoId("_y6cjEKp2EeamNLogr5TkIQ")]
    [DisplayName("Peak Initial Margin Liability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PeakInitlMrgnLblty")]
    #endif
    [IsoXmlTag("PeakInitlMrgnLblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PeakInitialMarginLiability { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PeakInitialMarginLiability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PeakInitialMarginLiability { get; init; } 
    #else
    public ActiveCurrencyAndAmount PeakInitialMarginLiability { get; set; } 
    #endif
    
    /// <summary>
    /// Peak loss uncollateralised variation margin liability on the margin account during the day.
    /// </summary>
    [IsoId("_4uHK0Kp2EeamNLogr5TkIQ")]
    [DisplayName("Peak Variation Margin Liability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PeakVartnMrgnLblty")]
    #endif
    [IsoXmlTag("PeakVartnMrgnLblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount PeakVariationMarginLiability { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount PeakVariationMarginLiability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount PeakVariationMarginLiability { get; init; } 
    #else
    public ActiveCurrencyAndAmount PeakVariationMarginLiability { get; set; } 
    #endif
    
    /// <summary>
    /// Peak intraday liability (sum of increase in initial margin relative to end of day plus sum of decrease in variation margin relative to end of day) for a margin account during the day. Liabilities are shown as positive integers.
    /// </summary>
    [IsoId("_-L_v0Kp2EeamNLogr5TkIQ")]
    [DisplayName("Aggregate Peak Liability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AggtPeakLblty")]
    #endif
    [IsoXmlTag("AggtPeakLblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AggregatePeakLiability { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AggregatePeakLiability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AggregatePeakLiability { get; init; } 
    #else
    public ActiveCurrencyAndAmount AggregatePeakLiability { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account used to calculate margin requirements and determine intraday calls.
    /// </summary>
    [IsoId("_QtEHsPneEeadN4WGmMtGCQ")]
    [DisplayName("Margin Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnAcctId")]
    #endif
    [IsoXmlTag("MrgnAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 MarginAccountIdentification { get; init; } 
    #else
    public GenericIdentification165 MarginAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
