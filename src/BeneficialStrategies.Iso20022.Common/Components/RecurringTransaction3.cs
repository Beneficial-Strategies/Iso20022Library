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
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_hH4hcK4wEeWpsoxRhdX-8A")]
[DisplayName("Recurring Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecurringTransaction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RecurringTransaction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RecurringTransaction3( System.DateOnly reqStartDate,System.DateOnly reqEndDate )
    {
        StartDate = reqStartDate;
        EndDate = reqEndDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of first transfer.
    /// </summary>
    [IsoId("_hUsOba4wEeWpsoxRhdX-8A")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly StartDate { get; init; } 
    #else
    public System.DateOnly StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of transfers to perform.
    /// </summary>
    [IsoId("_hUsOa64wEeWpsoxRhdX-8A")]
    [DisplayName("Number Of Occurrences")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfOcrncs")]
    #endif
    [IsoXmlTag("NbOfOcrncs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfOccurrences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfOccurrences { get; init; } 
    #else
    public System.UInt64? NumberOfOccurrences { get; set; } 
    #endif
    
    /// <summary>
    /// Date of last transfer.
    /// </summary>
    [IsoId("_CTLosK4xEeWpsoxRhdX-8A")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate EndDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly EndDate { get; init; } 
    #else
    public System.DateOnly EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Period of the recurring transfer.
    /// </summary>
    [IsoId("_hUsOZ64wEeWpsoxRhdX-8A")]
    [DisplayName("Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdUnit")]
    #endif
    [IsoXmlTag("PrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Code? PeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Code? PeriodUnit { get; init; } 
    #else
    public Frequency3Code? PeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Day of the period when the transfer will be performed.
    /// </summary>
    [IsoId("_hUsOaa4wEeWpsoxRhdX-8A")]
    [DisplayName("Interval Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrvlDay")]
    #endif
    [IsoXmlTag("IntrvlDay")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? IntervalDay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? IntervalDay { get; init; } 
    #else
    public System.UInt64? IntervalDay { get; set; } 
    #endif
    
    
    #nullable disable
    
}
