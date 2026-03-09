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
/// Information about the business status of a cancellation request message.
/// </summary>
[IsoId("_RXzed9p-Ed-ak6NoX_4Aeg_-377525821")]
[DisplayName("Cancellation Status Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancellationStatusInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancellationStatusInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancellationStatusInformation1( CancellationStatus4Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information on the business status of the cancellation.
    /// </summary>
    [IsoId("_RXzeeNp-Ed-ak6NoX_4Aeg_-377525819")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationStatus4Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationStatus4Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatus4Code Status { get; init; } 
    #else
    public CancellationStatus4Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// The reason for the cancellation status.
    /// </summary>
    [IsoId("_RX8oYNp-Ed-ak6NoX_4Aeg_-377525790")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReason4Choice_? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReason4Choice_? StatusReason { get; init; } 
    #else
    public StatusReason4Choice_? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_RX8oYdp-Ed-ak6NoX_4Aeg_-377525729")]
    [DisplayName("Additional Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlStsRsnInf")]
    #endif
    [IsoXmlTag("AddtlStsRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalStatusReasonInformation { get; init; } 
    #else
    public System.String? AdditionalStatusReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
