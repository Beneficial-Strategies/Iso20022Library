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
/// Reason for the reversed status.
/// </summary>
[IsoId("_RQptldp-Ed-ak6NoX_4Aeg_-1949430355")]
[DisplayName("Reversed Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversedStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversedStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversedStatus1( System.String reqReason,GenericIdentification1 reqDataSourceScheme,NoReasonCode reqNoSpecifiedReason )
    {
        Reason = reqReason;
        DataSourceScheme = reqDataSourceScheme;
        NoSpecifiedReason = reqNoSpecifiedReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the reversal status.
    /// </summary>
    [IsoId("_RQptltp-Ed-ak6NoX_4Aeg_-1949430313")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Reason { get; init; } 
    #else
    public System.String Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of the reason for the reversed status.
    /// </summary>
    [IsoId("_RQptl9p-Ed-ak6NoX_4Aeg_-1949430294")]
    [DisplayName("Data Source Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSrcSchme")]
    #endif
    [IsoXmlTag("DataSrcSchme")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1 DataSourceScheme { get; init; } 
    #else
    public GenericIdentification1 DataSourceScheme { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RQptmNp-Ed-ak6NoX_4Aeg_1619833408")]
    [DisplayName("No Specified Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoSpcfdRsn")]
    #endif
    [IsoXmlTag("NoSpcfdRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoReasonCode NoSpecifiedReason { get; init; } 
    #else
    public NoReasonCode NoSpecifiedReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
