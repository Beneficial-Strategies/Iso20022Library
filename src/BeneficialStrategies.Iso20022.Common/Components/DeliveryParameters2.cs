// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of a physical delivery.
/// </summary>
[IsoId("_VMU4_9p-Ed-ak6NoX_4Aeg_-1776273308")]
[DisplayName("Delivery Parameters")]
public partial record DeliveryParameters2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the address for the physical delivery is the registered address.
    /// </summary>
    [IsoId("_VMU5ANp-Ed-ak6NoX_4Aeg_-1646980441")]
    [DisplayName("Registered Address Indicator")]
    [IsoXmlTag("RegdAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RegisteredAddressIndicator { get; init; } 
    
    /// <summary>
    /// Name and address to/from which the physical delivery/receipt of the financial instrument must take place.
    /// </summary>
    [IsoId("_VMU5Adp-Ed-ak6NoX_4Aeg_-1646980710")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress1? NameAndAddress { get; init; } 
    
    
    #nullable disable
    
}
