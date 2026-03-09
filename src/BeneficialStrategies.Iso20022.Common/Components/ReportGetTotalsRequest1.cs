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
/// Content of the Get Totals Request message.
/// </summary>
[IsoId("_mY7jcN6SEeiwsev40qZGEQ")]
[DisplayName("Report Get Totals Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportGetTotalsRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the hierarchical structure of the report.
    /// </summary>
    [IsoId("_s0kxMN6SEeiwsev40qZGEQ")]
    [DisplayName("Total Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlDtls")]
    #endif
    [IsoXmlTag("TtlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalDetails1Code? TotalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalDetails1Code? TotalDetails { get; init; } 
    #else
    public TotalDetails1Code? TotalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Filter to compute the totals.
    /// </summary>
    [IsoId("_Pc6eMN6TEeiwsev40qZGEQ")]
    [DisplayName("Total Filter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlFltr")]
    #endif
    [IsoXmlTag("TtlFltr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TotalFilter1? TotalFilter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TotalFilter1? TotalFilter { get; init; } 
    #else
    public TotalFilter1? TotalFilter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
