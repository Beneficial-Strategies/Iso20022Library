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
/// Detailed statistics on reports.
/// </summary>
[IsoId("_2KfKwcrVEeii_5g6VX90qQ")]
[DisplayName("Detailed Report Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedReportStatistics5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedReportStatistics5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedReportStatistics5( System.String reqTotalNumberOfReports,System.String reqTotalNumberOfReportsAccepted,System.String reqTotalNumberOfReportsRejected )
    {
        TotalNumberOfReports = reqTotalNumberOfReports;
        TotalNumberOfReportsAccepted = reqTotalNumberOfReportsAccepted;
        TotalNumberOfReportsRejected = reqTotalNumberOfReportsRejected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    [IsoId("_2UBhQcrVEeii_5g6VX90qQ")]
    [DisplayName("Total Number Of Reports")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRpts")]
    #endif
    [IsoXmlTag("TtlNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfReports { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfReports { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfReports { get; init; } 
    #else
    public System.String TotalNumberOfReports { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports accepted.
    /// </summary>
    [IsoId("_Ak4tEMrWEeii_5g6VX90qQ")]
    [DisplayName("Total Number Of Reports Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRptsAccptd")]
    #endif
    [IsoXmlTag("TtlNbOfRptsAccptd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfReportsAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfReportsAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfReportsAccepted { get; init; } 
    #else
    public System.String TotalNumberOfReportsAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reports rejected.
    /// </summary>
    [IsoId("_HPzW0MrfEeii_5g6VX90qQ")]
    [DisplayName("Total Number Of Reports Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfRptsRjctd")]
    #endif
    [IsoXmlTag("TtlNbOfRptsRjctd")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText TotalNumberOfReportsRejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfReportsRejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfReportsRejected { get; init; } 
    #else
    public System.String TotalNumberOfReportsRejected { get; set; } 
    #endif
    
    /// <summary>
    /// Number of reports rejected per error code.
    /// </summary>
    [IsoId("_2UBhRcrVEeii_5g6VX90qQ")]
    [DisplayName("Number Of Reports Rejected Per Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfRptsRjctdPerErr")]
    #endif
    [IsoXmlTag("NbOfRptsRjctdPerErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberOfTransactionsPerValidationRule5? NumberOfReportsRejectedPerError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOfTransactionsPerValidationRule5? NumberOfReportsRejectedPerError { get; init; } 
    #else
    public NumberOfTransactionsPerValidationRule5? NumberOfReportsRejectedPerError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
