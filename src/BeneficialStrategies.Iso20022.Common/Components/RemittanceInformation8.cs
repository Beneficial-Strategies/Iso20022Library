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
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_XijF0aFnEeKHbozT2UhHKA")]
[DisplayName("Remittance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceInformation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RemittanceInformation8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RemittanceInformation8( OriginalPaymentInformation6 reqOriginalPaymentInformation )
    {
        OriginalPaymentInformation = reqOriginalPaymentInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, assigned by the originator, to unambiguously identify the remittance information within the message.
    /// </summary>
    [IsoId("_WZG0Z6LOEeKkeNjCPqn3xA")]
    [DisplayName("Remittance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtId")]
    #endif
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceIdentification { get; init; } 
    #else
    public System.String? RemittanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_XtkqFaFnEeKHbozT2UhHKA")]
    [DisplayName("Unstructured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ustrd")]
    #endif
    [IsoXmlTag("Ustrd")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Unstructured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Unstructured { get; init; } 
    #else
    public System.String? Unstructured { get; set; } 
    #endif
    
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_XtkqGaFnEeKHbozT2UhHKA")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StructuredRemittanceInformation10? Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StructuredRemittanceInformation10? Structured { get; init; } 
    #else
    public StructuredRemittanceInformation10? Structured { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the original transactions, to which the remittance message refers.
    /// </summary>
    [IsoId("_F_dZ8KJhEeKmspP9k_hIRQ")]
    [DisplayName("Original Payment Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInf")]
    #endif
    [IsoXmlTag("OrgnlPmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalPaymentInformation6 OriginalPaymentInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalPaymentInformation6 OriginalPaymentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInformation6 OriginalPaymentInformation { get; init; } 
    #else
    public OriginalPaymentInformation6 OriginalPaymentInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
