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
/// Defines the criteria which are used to search for the status of the payment.
/// </summary>
[IsoId("_5RK8odEcEei798TPbKJMuw")]
[DisplayName("Instruction Status Search")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionStatusSearch5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of a transfer.
    /// </summary>
    [IsoId("_5cxvs9EcEei798TPbKJMuw")]
    [DisplayName("Payment Instruction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrSts")]
    #endif
    [IsoXmlTag("PmtInstrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatusCodeSearch2Choice_? PaymentInstructionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatusCodeSearch2Choice_? PaymentInstructionStatus { get; init; } 
    #else
    public PaymentStatusCodeSearch2Choice_? PaymentInstructionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    [IsoId("_5cxvtdEcEei798TPbKJMuw")]
    [DisplayName("Payment Instruction Status Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrStsDtTm")]
    #endif
    [IsoXmlTag("PmtInstrStsDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? PaymentInstructionStatusDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? PaymentInstructionStatusDateTime { get; init; } 
    #else
    public DateTimePeriod1Choice_? PaymentInstructionStatusDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the reason that has been used by the system to reject the transaction.
    /// </summary>
    [IsoId("_5cxvt9EcEei798TPbKJMuw")]
    [DisplayName("Proprietary Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryStsRsn")]
    #endif
    [IsoXmlTag("PrtryStsRsn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? ProprietaryStatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProprietaryStatusReason { get; init; } 
    #else
    public System.String? ProprietaryStatusReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
