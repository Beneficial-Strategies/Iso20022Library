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
/// Defines the criteria which are used to report on the payment status.
/// </summary>
[IsoId("_RImk0tp-Ed-ak6NoX_4Aeg_-1267402839")]
[DisplayName("Instruction Status Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionStatusReturnCriteria
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructionStatusReturnCriteria instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructionStatusReturnCriteria( System.String reqPaymentInstructionStatusIndicator )
    {
        PaymentInstructionStatusIndicator = reqPaymentInstructionStatusIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the instruction status is requested.
    /// </summary>
    [IsoId("_RImk09p-Ed-ak6NoX_4Aeg_-1267402838")]
    [DisplayName("Payment Instruction Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrStsInd")]
    #endif
    [IsoXmlTag("PmtInstrStsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator PaymentInstructionStatusIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PaymentInstructionStatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PaymentInstructionStatusIndicator { get; init; } 
    #else
    public System.String PaymentInstructionStatusIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the status date and time are requested.
    /// </summary>
    [IsoId("_RImk1Np-Ed-ak6NoX_4Aeg_-1267402837")]
    [DisplayName("Payment Instruction Status Date Time Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrStsDtTmInd")]
    #endif
    [IsoXmlTag("PmtInstrStsDtTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PaymentInstructionStatusDateTimeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentInstructionStatusDateTimeIndicator { get; init; } 
    #else
    public System.String? PaymentInstructionStatusDateTimeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the status reason is requested.
    /// </summary>
    [IsoId("_RImk1dp-Ed-ak6NoX_4Aeg_-1267402836")]
    [DisplayName("Payment Instruction Status Reason Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrStsRsnInd")]
    #endif
    [IsoXmlTag("PmtInstrStsRsnInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? PaymentInstructionStatusReasonIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentInstructionStatusReasonIndicator { get; init; } 
    #else
    public System.String? PaymentInstructionStatusReasonIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
