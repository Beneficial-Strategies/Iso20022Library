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
/// Measure of the total capital requirement all the clearing members are required to hold against their default fund contributions to a central counterparty.
/// </summary>
[IsoId("_LK-vILb2EeabfchHYoktpA")]
[DisplayName("Hypothetical Capital Measure")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HypotheticalCapitalMeasure1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HypotheticalCapitalMeasure1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HypotheticalCapitalMeasure1( ActiveCurrencyAndAmount reqAmount,System.String reqDefaultWaterfallIdentification )
    {
        Amount = reqAmount;
        DefaultWaterfallIdentification = reqDefaultWaterfallIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the amount of the total capital requirement all the clearing members are required to hold against their default fund contributions to a central counterparty.
    /// </summary>
    [IsoId("_UHwc4Lb2EeabfchHYoktpA")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique internal identifier for each default waterfall at the central counterparty.
    /// </summary>
    [IsoId("_qdBOsLb2EeabfchHYoktpA")]
    [DisplayName("Default Waterfall Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltWtrfllId")]
    #endif
    [IsoXmlTag("DfltWtrfllId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DefaultWaterfallIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DefaultWaterfallIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DefaultWaterfallIdentification { get; init; } 
    #else
    public System.String DefaultWaterfallIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
