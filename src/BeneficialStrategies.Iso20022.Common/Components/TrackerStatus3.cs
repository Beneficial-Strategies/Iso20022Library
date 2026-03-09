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
/// Provides detailed information on the transaction status to be updated in the tracker.
/// </summary>
[IsoId("_XZ_1A_WfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatus3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatus3( TrackerPaymentStatus1Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_XZ_1BfWfEemtd4wHZYvFUQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerPaymentStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerPaymentStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPaymentStatus1Code Status { get; init; } 
    #else
    public TrackerPaymentStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_XZ_1CfWfEemtd4wHZYvFUQ")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatusReason2? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatusReason2? StatusReason { get; init; } 
    #else
    public PaymentStatusReason2? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the reject or return reason.
    /// </summary>
    [IsoId("_XZ_1C_WfEemtd4wHZYvFUQ")]
    [DisplayName("Reject Return Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctRtrRsn")]
    #endif
    [IsoXmlTag("RjctRtrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentRejectReturnReason2? RejectReturnReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentRejectReturnReason2? RejectReturnReason { get; init; } 
    #else
    public PaymentRejectReturnReason2? RejectReturnReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
