// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Delivery information
/// </summary>
[IsoId("_1qvqUcW3EeuhguwJmlgagQ")]
[DisplayName("Delivery Information")]
public record DeliveryInformation4
{
    /// <summary>
    /// Contains the number identifying an individual delivery note.
    /// </summary>
    [IsoId("_1vSzIcW3EeuhguwJmlgagQ")]
    [DisplayName("Delivery Note Number")]
    [IsoXmlTag("DlvryNoteNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DeliveryNoteNumber { get; init; }

    /// <summary>
    /// Delivery address.
    /// </summary>
    [IsoId("_1vSzI8W3EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Contact for delivery.
    /// </summary>
    [IsoId("_1vSzJcW3EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; }

    /// <summary>
    /// Special instructions.
    /// </summary>
    [IsoId("_1vSzJ8W3EeuhguwJmlgagQ")]
    [DisplayName("Instructions")]
    [IsoXmlTag("Instrs")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Instructions { get; init; }

    /// <summary>
    /// Contains the package delivery date.
    /// </summary>
    [IsoId("_1vSzKcW3EeuhguwJmlgagQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Contains the package delivery time.
    /// </summary>
    [IsoId("_1vSzK8W3EeuhguwJmlgagQ")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; }
}
