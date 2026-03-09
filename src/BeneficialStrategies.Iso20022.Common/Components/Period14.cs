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
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_jm0boeWhEeevU7McUP3D1w")]
[DisplayName("Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Period14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Period14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Period14( DateFormat56Choice_ reqStartDate,DateFormat56Choice_ reqEndDate )
    {
        StartDate = reqStartDate;
        EndDate = reqEndDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_jvxjUeWhEeevU7McUP3D1w")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat56Choice_ StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat56Choice_ StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat56Choice_ StartDate { get; init; } 
    #else
    public DateFormat56Choice_ StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_jvxjU-WhEeevU7McUP3D1w")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat56Choice_ EndDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat56Choice_ EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat56Choice_ EndDate { get; init; } 
    #else
    public DateFormat56Choice_ EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
