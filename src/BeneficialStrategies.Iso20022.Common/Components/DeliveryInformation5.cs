// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivery information for the purpose of a retrieval fulfilment.
/// </summary>
[IsoId("_IIQ5EcW5EeuhguwJmlgagQ")]
[DisplayName("Delivery Information")]
public partial record DeliveryInformation5
{
    #nullable enable
    
    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_IM2eIcW5EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact7? Contact { get; init; } 
    
    /// <summary>
    /// Postal address related to a retrieval fulfilment.
    /// </summary>
    [IsoId("_IM2eI8W5EeuhguwJmlgagQ")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public Address2? PostalAddress { get; init; } 
    
    
    #nullable disable
    
}
