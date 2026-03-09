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
/// Specifies generic information about an investigation report.
/// </summary>
[IsoId("_RI5fwNp-Ed-ak6NoX_4Aeg_24374172")]
[DisplayName("Report Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportHeader
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportHeader instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportHeader( System.String reqIdentification,System.String reqFrom,System.String reqTo,System.DateTime reqCreationDateTime )
    {
        Identification = reqIdentification;
        From = reqFrom;
        To = reqTo;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_RI5fwdp-Ed-ak6NoX_4Aeg_-1998731747")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party reporting the status of the case.
    /// </summary>
    [IsoId("_RI5fwtp-Ed-ak6NoX_4Aeg_-1991343595")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String From { get; init; } 
    #else
    public System.String From { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    [IsoId("_RI5fw9p-Ed-ak6NoX_4Aeg_-1981183608")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String To { get; init; } 
    #else
    public System.String To { get; set; } 
    #endif
    
    /// <summary>
    /// Creation date and time of the report generation.
    /// </summary>
    [IsoId("_RI5fxNp-Ed-ak6NoX_4Aeg_-1970102765")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
