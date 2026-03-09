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
/// Specifies two values to compare related to payment data attributes not reported in dedicated fields.
/// </summary>
[IsoId("_5w6zAYpbEeyVdPSarESe_A")]
[DisplayName("Compare Other Payment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CompareOtherPayment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the other payment types are matching or not.
    /// </summary>
    [IsoId("_LD9oIIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmtTp")]
    #endif
    [IsoXmlTag("OthrPmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOtherPaymentType1? OtherPaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOtherPaymentType1? OtherPaymentType { get; init; } 
    #else
    public CompareOtherPaymentType1? OtherPaymentType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the other payment amounts are matching or not.
    /// </summary>
    [IsoId("_O1IMoIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmtAmt")]
    #endif
    [IsoXmlTag("OthrPmtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection3? OtherPaymentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection3? OtherPaymentAmount { get; init; } 
    #else
    public CompareAmountAndDirection3? OtherPaymentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the other payment dates are matching or not.
    /// </summary>
    [IsoId("_SP2AAIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmtDt")]
    #endif
    [IsoXmlTag("OthrPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? OtherPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? OtherPaymentDate { get; init; } 
    #else
    public CompareDate3? OtherPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the other payment payers are matching or not.
    /// </summary>
    [IsoId("_WcZgAIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmtPyer")]
    #endif
    [IsoXmlTag("OthrPmtPyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification7? OtherPaymentPayer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification7? OtherPaymentPayer { get; init; } 
    #else
    public CompareOrganisationIdentification7? OtherPaymentPayer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the other payment receivers are matching or not.
    /// </summary>
    [IsoId("_Z0F0kIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmtRcvr")]
    #endif
    [IsoXmlTag("OthrPmtRcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification7? OtherPaymentReceiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification7? OtherPaymentReceiver { get; init; } 
    #else
    public CompareOrganisationIdentification7? OtherPaymentReceiver { get; set; } 
    #endif
    
    
    #nullable disable
    
}
