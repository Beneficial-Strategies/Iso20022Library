// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the context when the event occurred.
/// </summary>
[IsoId("_chPX0bZ0EfCUZfsQO4rYeA")]
[DisplayName("Event Context8")]
public record EventContext8
{
    /// <summary>
    /// Reference to the service and functions related to the event.
    /// </summary>
    [IsoId("_ciHhlbZ0EfCUZfsQO4rYeA")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required RetailerService1Code ServiceType { get; init; }

    /// <summary>
    /// Identification of the Point Of Interaction.
    /// </summary>
    [IsoId("_ciHhm7Z0EfCUZfsQO4rYeA")]
    [DisplayName("Component Identification")]
    [IsoXmlTag("CmpntId")]
    public PointOfInteractionComponent18? ComponentIdentification { get; init; }

    /// <summary>
    /// Identification of the Sale System.
    /// </summary>
    [IsoId("_ciHhobZ0EfCUZfsQO4rYeA")]
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    public IsoMax35Text? SaleIdentification { get; init; }
}
