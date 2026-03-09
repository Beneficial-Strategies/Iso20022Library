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
/// Provides the details of each package of currency control records.
/// </summary>
[IsoId("_9WLb9248EeiU9cctagi5ow")]
[DisplayName("Currency Control Package Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlPackageStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyControlPackageStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlPackageStatus2( System.String reqPackageIdentification,StatisticalReportingStatus1Code reqStatus )
    {
        PackageIdentification = reqPackageIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of each package of transactions and optionally the entry/record within the package of transactions.
    /// </summary>
    [IsoId("_9gw7UW48EeiU9cctagi5ow")]
    [DisplayName("Package Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgId")]
    #endif
    [IsoXmlTag("PackgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PackageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PackageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PackageIdentification { get; init; } 
    #else
    public System.String PackageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the status of the reported transaction.
    /// </summary>
    [IsoId("_9gw7U248EeiU9cctagi5ow")]
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
    [IsoId("_9gw7VW48EeiU9cctagi5ow")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValidationStatusReason2? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValidationStatusReason2? StatusReason { get; init; } 
    #else
    public ValidationStatusReason2? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_9gw7V248EeiU9cctagi5ow")]
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
    /// Provides the status of the individual records in the package.
    /// </summary>
    [IsoId("_9gw7WW48EeiU9cctagi5ow")]
    [DisplayName("Record Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdSts")]
    #endif
    [IsoXmlTag("RcrdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyControlRecordStatus2? RecordStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlRecordStatus2? RecordStatus { get; init; } 
    #else
    public CurrencyControlRecordStatus2? RecordStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
