// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order Priority1.
/// </summary>
[IsoId("_Mav_UBAUEe6N57R8Wekj-w")]
[DisplayName("Order Priority1")]
public record OrderPriority1
{
    /// <summary>
    /// Size.
    /// </summary>
    [DisplayName("Size")]
    [IsoXmlTag("Sz")]
    public IsoPositiveNumber? Size { get; init; }

    /// <summary>
    /// Time Stamp.
    /// </summary>
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public IsoISODateTime? TimeStamp { get; init; }
}
