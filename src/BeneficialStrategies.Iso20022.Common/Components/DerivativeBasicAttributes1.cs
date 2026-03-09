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
/// Details of the derivative contract not included in the general financial instrument attributes component.
/// </summary>
[IsoId("_UAL18Np-Ed-ak6NoX_4Aeg_-764187089")]
[DisplayName("Derivative Basic Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeBasicAttributes1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeBasicAttributes1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeBasicAttributes1( ActiveOrHistoricCurrencyAndAmount reqNotionalCurrencyAndAmount )
    {
        NotionalCurrencyAndAmount = reqNotionalCurrencyAndAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount underlying a financial derivatives contract necessary for calculating payments or receipts.
    /// </summary>
    [IsoId("_UAL18dp-Ed-ak6NoX_4Aeg_-672759476")]
    [DisplayName("Notional Currency And Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcyAndAmt")]
    #endif
    [IsoXmlTag("NtnlCcyAndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount NotionalCurrencyAndAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount NotionalCurrencyAndAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount NotionalCurrencyAndAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount NotionalCurrencyAndAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the given derivative price includes a prorated accrued interest component.
    /// </summary>
    [IsoId("_UAL18tp-Ed-ak6NoX_4Aeg_1385962501")]
    [DisplayName("Interest Included In Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstInclInPric")]
    #endif
    [IsoXmlTag("IntrstInclInPric")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InterestIncludedInPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestIncludedInPrice { get; init; } 
    #else
    public System.String? InterestIncludedInPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
