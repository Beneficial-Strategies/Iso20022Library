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
[IsoId("_T5oiA9p-Ed-ak6NoX_4Aeg_1742147586")]
[DisplayName("Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Period3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Period3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Period3( DateFormat12Choice_ reqStartDate,DateFormat12Choice_ reqEndDate )
    {
        StartDate = reqStartDate;
        EndDate = reqEndDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_T5oiBNp-Ed-ak6NoX_4Aeg_1743067755")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat12Choice_ StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat12Choice_ StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat12Choice_ StartDate { get; init; } 
    #else
    public DateFormat12Choice_ StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T5oiBdp-Ed-ak6NoX_4Aeg_1743067910")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat12Choice_ EndDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat12Choice_ EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat12Choice_ EndDate { get; init; } 
    #else
    public DateFormat12Choice_ EndDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
