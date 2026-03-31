// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of a physical delivery.
/// </summary>
[IsoId("_T6hS0tp-Ed-ak6NoX_4Aeg_177856099")]
[DisplayName("Delivery Parameters")]
public record DeliveryParameters4
{
    /// <summary>
    /// Indicates whether the address for the physical delivery is the registered address.
    /// </summary>
    [IsoId("_T6hS09p-Ed-ak6NoX_4Aeg_185241494")]
    [DisplayName("Registered Address Indicator")]
    [IsoXmlTag("RegdAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RegisteredAddressIndicator { get; init; }

    /// <summary>
    /// Name and address to/from which the physical delivery/receipt of the financial instrument must take place.
    /// </summary>
    [IsoId("_T6hS1Np-Ed-ak6NoX_4Aeg_177856117")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress4? NameAndAddress { get; init; }

    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [IsoId("_T6hS1dp-Ed-ak6NoX_4Aeg_690410383")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification2? ContactPerson { get; init; }
}
