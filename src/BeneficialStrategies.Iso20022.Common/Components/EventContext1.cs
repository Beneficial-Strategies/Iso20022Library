// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the Retailer Event message.
/// </summary>
[IsoId("_tONqIN6bEeiwsev40qZGEQ")]
[DisplayName("Event Context")]
public record EventContext1
{
    /// <summary>
    /// Reference to the service and functions related to the event.
    /// </summary>
    [IsoId("_7l8ksN6bEeiwsev40qZGEQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required RetailerService1Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the Point Of Interaction.
    /// </summary>
    [IsoId("__H8EwN6bEeiwsev40qZGEQ")]
    [DisplayName("Component Identification")]
    [IsoXmlTag("CmpntId")]
    public PointOfInteractionComponent9? ComponentIdentification { get; init; }

    /// <summary>
    /// Identification of the Sale System.
    /// </summary>
    [IsoId("_B5dxMN6cEeiwsev40qZGEQ")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleIdentification { get; init; }
}
