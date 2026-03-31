// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivery information for the purpose of a retrieval fulfilment.
/// </summary>
[IsoId("_IIQ5EcW5EeuhguwJmlgagQ")]
[DisplayName("Delivery Information")]
public record DeliveryInformation5
{
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
}
