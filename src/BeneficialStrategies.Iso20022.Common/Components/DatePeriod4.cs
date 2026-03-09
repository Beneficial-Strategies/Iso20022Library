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
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_3ZZIEVo6Ee23K4GXSpBSeg")]
[DisplayName("Date Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DatePeriod4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_3af7U1o6Ee23K4GXSpBSeg")]
    [DisplayName("From Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrDt")]
    #endif
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FromDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FromDate { get; init; } 
    #else
    public System.DateOnly? FromDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_3af7VVo6Ee23K4GXSpBSeg")]
    [DisplayName("To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToDt")]
    #endif
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ToDate { get; init; } 
    #else
    public System.DateOnly? ToDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
