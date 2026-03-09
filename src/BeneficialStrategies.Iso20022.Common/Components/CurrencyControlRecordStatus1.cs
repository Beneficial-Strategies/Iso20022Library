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
/// Provides the details of each individual currency control record.
/// </summary>
[IsoId("_hI5IpAtOEeWkxvNyFrBT8Q")]
[DisplayName("Currency Control Record Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlRecordStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyControlRecordStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlRecordStatus1( System.String reqRecordIdentification,StatisticalReportingStatus1Code reqStatus )
    {
        RecordIdentification = reqRecordIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of each entry/record within the package of transactions.
    /// </summary>
    [IsoId("_hI5IpgtOEeWkxvNyFrBT8Q")]
    [DisplayName("Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdId")]
    #endif
    [IsoXmlTag("RcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RecordIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RecordIdentification { get; init; } 
    #else
    public System.String RecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the status of the reported record.
    /// </summary>
    [IsoId("_hI5IpQtOEeWkxvNyFrBT8Q")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatisticalReportingStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatisticalReportingStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatisticalReportingStatus1Code Status { get; init; } 
    #else
    public StatisticalReportingStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_Fe-w4QtPEeWkxvNyFrBT8Q")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusReason1? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusReason1? StatusReason { get; init; } 
    #else
    public ValidationStatusReason1? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_X421cW5bEeW1GNjYvtuLyQ")]
    [DisplayName("Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDtTm")]
    #endif
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StatusDateTime { get; init; } 
    #else
    public System.DateTime? StatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the document.
    /// </summary>
    [IsoId("_DXmYMAtQEeWkxvNyFrBT8Q")]
    [DisplayName("Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocId")]
    #endif
    [IsoXmlTag("DocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification28? DocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification28? DocumentIdentification { get; init; } 
    #else
    public DocumentIdentification28? DocumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
