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
/// Contains the details of the labour performed and associated duration and billing rate. 
/// </summary>
[IsoId("_4TwEBPfdEei89sMSHxl1ew")]
[DisplayName("Temporary Services Labor")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TemporaryServicesLabor1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the time sheet identification number.
    /// </summary>
    [IsoId("_4TwEBffdEei89sMSHxl1ew")]
    [DisplayName("Time Sheet Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmSheetNb")]
    #endif
    [IsoXmlTag("TmSheetNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TimeSheetNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimeSheetNumber { get; init; } 
    #else
    public System.String? TimeSheetNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the date of the end of the billing cycle. 
    /// </summary>
    [IsoId("_4TwEBvfdEei89sMSHxl1ew")]
    [DisplayName("Week Ending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WkEndg")]
    #endif
    [IsoXmlTag("WkEndg")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? WeekEnding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WeekEnding { get; init; } 
    #else
    public System.String? WeekEnding { get; set; } 
    #endif
    
    /// <summary>
    /// Contains details of the amount charged. 
    /// </summary>
    [IsoId("_4TwEB_fdEei89sMSHxl1ew")]
    [DisplayName("Charge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrg")]
    #endif
    [IsoXmlTag("Chrg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount12? Charge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount12? Charge { get; init; } 
    #else
    public Amount12? Charge { get; set; } 
    #endif
    
    
    #nullable disable
    
}
