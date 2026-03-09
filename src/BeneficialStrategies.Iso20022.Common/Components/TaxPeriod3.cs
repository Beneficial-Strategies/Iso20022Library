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
/// Period of time details related to the tax payment.
/// </summary>
[IsoId("_oB4Gpd4lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxPeriod3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Year related to the tax payment.
    /// </summary>
    [IsoId("_oDl94d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Yr")]
    #endif
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYear? Year { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? Year { get; init; } 
    #else
    public System.UInt16? Year { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the period related to the tax payment.
    /// </summary>
    [IsoId("_oDl9494lEeqt1ZcLzWyWFw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxRecordPeriod1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxRecordPeriod1Code? Type { get; init; } 
    #else
    public TaxRecordPeriod1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Range of time between a start date and an end date for which the tax report is provided.
    /// </summary>
    [IsoId("_oDl95d4lEeqt1ZcLzWyWFw")]
    [DisplayName("From To Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrToDt")]
    #endif
    [IsoXmlTag("FrToDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod2? FromToDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod2? FromToDate { get; init; } 
    #else
    public DatePeriod2? FromToDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
