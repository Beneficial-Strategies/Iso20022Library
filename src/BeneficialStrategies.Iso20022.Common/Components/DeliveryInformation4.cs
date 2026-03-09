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
/// Delivery information
/// </summary>
[IsoId("_1qvqUcW3EeuhguwJmlgagQ")]
[DisplayName("Delivery Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveryInformation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the number identifying an individual delivery note. 
    /// </summary>
    [IsoId("_1vSzIcW3EeuhguwJmlgagQ")]
    [DisplayName("Delivery Note Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryNoteNb")]
    #endif
    [IsoXmlTag("DlvryNoteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DeliveryNoteNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryNoteNumber { get; init; } 
    #else
    public System.String? DeliveryNoteNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery address.
    /// </summary>
    [IsoId("_1vSzI8W3EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? Address { get; init; } 
    #else
    public Address2? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_1vSzJcW3EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact6? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact6? Contact { get; init; } 
    #else
    public Contact6? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Special instructions. 
    /// </summary>
    [IsoId("_1vSzJ8W3EeuhguwJmlgagQ")]
    [DisplayName("Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instrs")]
    #endif
    [IsoXmlTag("Instrs")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Instructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Instructions { get; init; } 
    #else
    public System.String? Instructions { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the package delivery date.
    /// </summary>
    [IsoId("_1vSzKcW3EeuhguwJmlgagQ")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the package delivery time.
    /// </summary>
    [IsoId("_1vSzK8W3EeuhguwJmlgagQ")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Time { get; init; } 
    #else
    public System.TimeOnly? Time { get; set; } 
    #endif
    
    
    #nullable disable
    
}
