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
/// Delivery information for the purpose of a retrieval fulfilment.
/// </summary>
[IsoId("_IIQ5EcW5EeuhguwJmlgagQ")]
[DisplayName("Delivery Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliveryInformation5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_IM2eIcW5EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact7? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact7? Contact { get; init; } 
    #else
    public Contact7? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address related to a retrieval fulfilment.
    /// </summary>
    [IsoId("_IM2eI8W5EeuhguwJmlgagQ")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? PostalAddress { get; init; } 
    #else
    public Address2? PostalAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
