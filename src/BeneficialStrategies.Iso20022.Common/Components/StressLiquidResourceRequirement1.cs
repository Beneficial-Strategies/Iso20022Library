// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Assumed obligations that are required to be met in cash under a hypothetical stress scenario.
/// </summary>
[IsoId("_yh7egLJPEeaYqc4G3TTwhA")]
[DisplayName("Stress Liquid Resource Requirement")]
public partial record StressLiquidResourceRequirement1
{
    #nullable enable
    
    /// <summary>
    /// Liquidity needs arising from ‘operational’ procedures over the stress horizon. This includes (but is not necessarily limited to) repayment of excess cash collateral to members, cash to non‐cash collateral substitutions by members, reductions in margin requirements and related cash collateral and provision of liquidity to facilitate settlement / delivery for non‐defaulting members.
    /// </summary>
    [IsoId("_4Pv88LJPEeaYqc4G3TTwhA")]
    [DisplayName("Operational Outflow")]
    [IsoXmlTag("OprlOutflw")]
    public required AmountAndDirection102 OperationalOutflow { get; init; } 
    
    /// <summary>
    /// Variation margin payment obligation of the CCP that is modelled to arise due to the default of CM1 and CM2 over the stress horizon.
    /// </summary>
    [IsoId("_8MqecLJPEeaYqc4G3TTwhA")]
    [DisplayName("Variation Margin Payment Obligation")]
    [IsoXmlTag("VartnMrgnPmtOblgtn")]
    public required AmountAndDirection102 VariationMarginPaymentObligation { get; init; } 
    
    /// <summary>
    /// Liquidity needed by the CCP to fulfil the settlement/delivery obligations arising from the cleared trades of defaulting CM1 and CM2.
    /// </summary>
    [IsoId("_Bv7SsLJQEeaYqc4G3TTwhA")]
    [DisplayName("Settlement Or Delivery")]
    [IsoXmlTag("SttlmOrDlvry")]
    public required AmountAndDirection102 SettlementOrDelivery { get; init; } 
    
    /// <summary>
    /// Other liquidity requirements not captured elsewhere. 
    /// </summary>
    [IsoId("_D1OLQLJQEeaYqc4G3TTwhA")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public required AmountAndDirection102 Other { get; init; } 
    
    
    #nullable disable
    
}
