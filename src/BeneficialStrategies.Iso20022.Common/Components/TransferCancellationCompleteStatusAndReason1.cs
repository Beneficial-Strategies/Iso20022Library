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
/// Status of the transfer cancellation is complete.
/// </summary>
[IsoId("_RQf8mdp-Ed-ak6NoX_4Aeg_2013423795")]
[DisplayName("Transfer Cancellation Complete Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferCancellationCompleteStatusAndReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferCancellationCompleteStatusAndReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferCancellationCompleteStatusAndReason1( CancelledStatusReason1Code reqReason,System.String reqExtendedReason,GenericIdentification1 reqDataSourceScheme )
    {
        Reason = reqReason;
        ExtendedReason = reqExtendedReason;
        DataSourceScheme = reqDataSourceScheme;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the transfer cancellation complete status.
    /// </summary>
    [IsoId("_RQf8mtp-Ed-ak6NoX_4Aeg_1302969453")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatusReason1Code Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatusReason1Code Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatusReason1Code Reason { get; init; } 
    #else
    public CancelledStatusReason1Code Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the transfer cancellation complete status.
    /// </summary>
    [IsoId("_RQptkNp-Ed-ak6NoX_4Aeg_2013423813")]
    [DisplayName("Extended Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedRsn")]
    #endif
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedReason { get; init; } 
    #else
    public System.String ExtendedReason { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary identification of the reason for the transfer cancellation complete status.
    /// </summary>
    [IsoId("_RQptkdp-Ed-ak6NoX_4Aeg_2013423927")]
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
    
    
    #nullable disable
    
}
