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
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_HG95hcWFEeiRga8tPu1L4Q")]
[DisplayName("Position Set Total")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetTotal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Refers to the number of trades contained in the position set.
    /// </summary>
    [IsoId("_HG95hsWFEeiRga8tPu1L4Q")]
    [DisplayName("Number Of Trades")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTrds")]
    #endif
    [IsoXmlTag("NbOfTrds")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20PositiveNumber? NumberOfTrades { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfTrades { get; init; } 
    #else
    public System.UInt64? NumberOfTrades { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregations of all positive values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_HG95k8WFEeiRga8tPu1L4Q")]
    [DisplayName("Positive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Postv")]
    #endif
    [IsoXmlTag("Postv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetValueAndNotional1? Positive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetValueAndNotional1? Positive { get; init; } 
    #else
    public PositionSetValueAndNotional1? Positive { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregations of all negative values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_HG95jcWFEeiRga8tPu1L4Q")]
    [DisplayName("Negative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Neg")]
    #endif
    [IsoXmlTag("Neg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetValueAndNotional1? Negative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetValueAndNotional1? Negative { get; init; } 
    #else
    public PositionSetValueAndNotional1? Negative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
