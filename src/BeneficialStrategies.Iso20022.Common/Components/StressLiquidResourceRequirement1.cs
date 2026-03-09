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
/// Assumed obligations that are required to be met in cash under a hypothetical stress scenario.
/// </summary>
[IsoId("_yh7egLJPEeaYqc4G3TTwhA")]
[DisplayName("Stress Liquid Resource Requirement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StressLiquidResourceRequirement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StressLiquidResourceRequirement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StressLiquidResourceRequirement1( AmountAndDirection102 reqOperationalOutflow,AmountAndDirection102 reqVariationMarginPaymentObligation,AmountAndDirection102 reqSettlementOrDelivery,AmountAndDirection102 reqOther )
    {
        OperationalOutflow = reqOperationalOutflow;
        VariationMarginPaymentObligation = reqVariationMarginPaymentObligation;
        SettlementOrDelivery = reqSettlementOrDelivery;
        Other = reqOther;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Liquidity needs arising from ‘operational’ procedures over the stress horizon. This includes (but is not necessarily limited to) repayment of excess cash collateral to members, cash to non‐cash collateral substitutions by members, reductions in margin requirements and related cash collateral and provision of liquidity to facilitate settlement / delivery for non‐defaulting members.
    /// </summary>
    [IsoId("_4Pv88LJPEeaYqc4G3TTwhA")]
    [DisplayName("Operational Outflow")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OprlOutflw")]
    #endif
    [IsoXmlTag("OprlOutflw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 OperationalOutflow { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 OperationalOutflow { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 OperationalOutflow { get; init; } 
    #else
    public AmountAndDirection102 OperationalOutflow { get; set; } 
    #endif
    
    /// <summary>
    /// Variation margin payment obligation of the CCP that is modelled to arise due to the default of CM1 and CM2 over the stress horizon.
    /// </summary>
    [IsoId("_8MqecLJPEeaYqc4G3TTwhA")]
    [DisplayName("Variation Margin Payment Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPmtOblgtn")]
    #endif
    [IsoXmlTag("VartnMrgnPmtOblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 VariationMarginPaymentObligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 VariationMarginPaymentObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 VariationMarginPaymentObligation { get; init; } 
    #else
    public AmountAndDirection102 VariationMarginPaymentObligation { get; set; } 
    #endif
    
    /// <summary>
    /// Liquidity needed by the CCP to fulfil the settlement/delivery obligations arising from the cleared trades of defaulting CM1 and CM2.
    /// </summary>
    [IsoId("_Bv7SsLJQEeaYqc4G3TTwhA")]
    [DisplayName("Settlement Or Delivery")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmOrDlvry")]
    #endif
    [IsoXmlTag("SttlmOrDlvry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 SettlementOrDelivery { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 SettlementOrDelivery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 SettlementOrDelivery { get; init; } 
    #else
    public AmountAndDirection102 SettlementOrDelivery { get; set; } 
    #endif
    
    /// <summary>
    /// Other liquidity requirements not captured elsewhere. 
    /// </summary>
    [IsoId("_D1OLQLJQEeaYqc4G3TTwhA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 Other { get; init; } 
    #else
    public AmountAndDirection102 Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
