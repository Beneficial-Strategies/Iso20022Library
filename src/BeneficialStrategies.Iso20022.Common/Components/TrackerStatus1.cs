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
[IsoId("_sTptYM7wEemEIuVuDudp4g")]
[DisplayName("Tracker Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatus1( ExternalPaymentTransactionStatus1Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_pLlJMs7wEemEIuVuDudp4g")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalPaymentTransactionStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalPaymentTransactionStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalPaymentTransactionStatus1Code Status { get; init; } 
    #else
    public ExternalPaymentTransactionStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Date for the status.
    /// </summary>
    [IsoId("_uY9TgM_hEemHcp9lKLekIw")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? Date { get; init; } 
    #else
    public DateAndDateTime2Choice_? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_pLlJM87wEemEIuVuDudp4g")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatusReason1? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatusReason1? StatusReason { get; init; } 
    #else
    public PaymentStatusReason1? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_vhy8UPSrEemJpbG3s5kY2A")]
    [DisplayName("Reject Return Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctRtrRsn")]
    #endif
    [IsoXmlTag("RjctRtrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentRejectReturnReason1? RejectReturnReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentRejectReturnReason1? RejectReturnReason { get; init; } 
    #else
    public PaymentRejectReturnReason1? RejectReturnReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
