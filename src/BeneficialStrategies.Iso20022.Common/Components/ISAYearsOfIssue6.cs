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
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_3gg5VEXfEeGY6MkiuzuPOA_-1852894636")]
[DisplayName("ISA Years Of Issue")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISAYearsOfIssue6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3gqDQEXfEeGY6MkiuzuPOA_-1966733702")]
    [DisplayName("Current Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurYr")]
    #endif
    [IsoXmlTag("CurYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrentYearType2Choice_? CurrentYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrentYearType2Choice_? CurrentYear { get; init; } 
    #else
    public CurrentYearType2Choice_? CurrentYear { get; set; } 
    #endif
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3gqDQUXfEeGY6MkiuzuPOA_334088888")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PreviousYearChoice_? PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYearChoice_? PreviousYears { get; init; } 
    #else
    public PreviousYearChoice_? PreviousYears { get; set; } 
    #endif
    
    
    #nullable disable
    
}
