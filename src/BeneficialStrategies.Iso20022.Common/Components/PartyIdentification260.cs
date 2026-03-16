// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party
/// </summary>
[IsoId("_9KuSocWmEeuhguwJmlgagQ")]
[DisplayName("Party Identification")]
public record PartyIdentification260
{
    /// <summary>
    /// Name of the party.
    /// </summary>
    [IsoId("_9PNKAcWmEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Contains identification details.
    /// </summary>
    [IsoId("_9PNKA8WmEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification258? Identification { get; init; }

    /// <summary>
    /// Address of the customer.
    /// </summary>
    [IsoId("_9PNKBcWmEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_9PNKB8WmEeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact6? Contact { get; init; }

    /// <summary>
    /// Special instructions.
    /// </summary>
    [IsoId("_9PNKCcWmEeuhguwJmlgagQ")]
    [DisplayName("Instructions")]
    [IsoXmlTag("Instrs")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Instructions { get; init; }
}
