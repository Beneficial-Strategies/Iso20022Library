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
/// Information about reported derivatives and reported derivatives with outliers.
/// </summary>
[IsoId("_x4xX8VyGEe24CqbZJK5XxA")]
[DisplayName("Detailed Transaction Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedTransactionStatistics28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedTransactionStatistics28 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedTransactionStatistics28( System.UInt64 reqNumberOfDerivativesReported,System.UInt64 reqNumberOfDerivativesReportedWithOutliers )
    {
        NumberOfDerivativesReported = reqNumberOfDerivativesReported;
        NumberOfDerivativesReportedWithOutliers = reqNumberOfDerivativesReportedWithOutliers;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of reported derivatives.
    /// </summary>
    [IsoId("_x5wPYVyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDerivsRptd")]
    #endif
    [IsoXmlTag("NbOfDerivsRptd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDerivativesReported { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDerivativesReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDerivativesReported { get; init; } 
    #else
    public System.UInt64 NumberOfDerivativesReported { get; set; } 
    #endif
    
    /// <summary>
    /// Number of reported derivatives with outliers.
    /// </summary>
    [IsoId("_x5wPY1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported With Outliers")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDerivsRptdWthOtlrs")]
    #endif
    [IsoXmlTag("NbOfDerivsRptdWthOtlrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDerivativesReportedWithOutliers { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDerivativesReportedWithOutliers { get; init; } 
    #else
    public System.UInt64 NumberOfDerivativesReportedWithOutliers { get; set; } 
    #endif
    
    /// <summary>
    /// Details of abnormal values.
    /// </summary>
    [IsoId("_x5wPZVyGEe24CqbZJK5XxA")]
    [DisplayName("Warnings")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wrnngs")]
    #endif
    [IsoXmlTag("Wrnngs")]
    public ValueList<AbnormalValuesData4> Warnings { get; init; } = new ValueList<AbnormalValuesData4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _x5wPZVyGEe24CqbZJK5XxA
    
    
    #nullable disable
    
}
