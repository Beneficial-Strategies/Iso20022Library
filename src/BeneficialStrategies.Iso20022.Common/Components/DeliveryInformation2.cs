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
[IsoId("_Acm7UVaAEeeFltjJxERUxw")]
[DisplayName("Delivery Information")]
public partial record DeliveryInformation2
{
    #nullable enable
    
    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_AozkQVaAEeeFltjJxERUxw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact7? Contact { get; init; } 
    
    /// <summary>
    /// Postal address related to a retrieval fulfilment.
    /// </summary>
    [IsoId("_AozkQ1aAEeeFltjJxERUxw")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public Address1? PostalAddress { get; init; } 
    
    
    #nullable disable
    
}
