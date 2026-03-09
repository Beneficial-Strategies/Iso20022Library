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
/// Instrument specific technical data to support identification.
/// </summary>
[IsoId("_6TNIgTH8EeWRJePX1ORoaw")]
[DisplayName("Record Technical Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecordTechnicalData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RecordTechnicalData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RecordTechnicalData2( System.DateTime reqReceiptDateTime,CancelledStatusReason15Code reqCancellationReason )
    {
        ReceiptDateTime = reqReceiptDateTime;
        CancellationReason = reqCancellationReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    [IsoId("_6nJ_RTH8EeWRJePX1ORoaw")]
    [DisplayName("Receipt Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctDtTm")]
    #endif
    [IsoXmlTag("RctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ReceiptDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ReceiptDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ReceiptDateTime { get; init; } 
    #else
    public System.DateTime ReceiptDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the cancellation the transaction.
    /// </summary>
    [IsoId("_xFDToJHzEeWL7bXuV2k5pg")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatusReason15Code CancellationReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatusReason15Code CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatusReason15Code CancellationReason { get; init; } 
    #else
    public CancelledStatusReason15Code CancellationReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
