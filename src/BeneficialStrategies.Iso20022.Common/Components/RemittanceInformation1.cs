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
/// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_QFsWV9p-Ed-ak6NoX_4Aeg_-92384845")]
[DisplayName("Remittance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system in an unstructured form.
    /// </summary>
    [IsoId("_QFsWWNp-Ed-ak6NoX_4Aeg_-92384592")]
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
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system in a structured form.
    /// </summary>
    [IsoId("_QF2HUNp-Ed-ak6NoX_4Aeg_-92384550")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StructuredRemittanceInformation6? Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StructuredRemittanceInformation6? Structured { get; init; } 
    #else
    public StructuredRemittanceInformation6? Structured { get; set; } 
    #endif
    
    
    #nullable disable
    
}
