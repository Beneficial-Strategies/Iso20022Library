// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Event Context7.
/// </summary>
[IsoId("_h-lFIZ9wEe-nbM0aSPcoiQ")]
[DisplayName("Event Context7")]
public record EventContext7
{
    /// <summary>
    /// Component Identification.
    /// </summary>
    [DisplayName("Component Identification")]
    [IsoXmlTag("CmpntId")]
    public PointOfInteractionComponent17? ComponentIdentification { get; init; }

    /// <summary>
    /// Sale Identification.
    /// </summary>
    [DisplayName("Sale Identification")]
    [IsoXmlTag("SaleId")]
    public IsoMax35Text? SaleIdentification { get; init; }

    /// <summary>
    /// Service Type.
    /// </summary>
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required RetailerService1Code ServiceType { get; init; }
}
