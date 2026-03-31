// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication details related to the registered currency control contract.
/// </summary>
[IsoId("_oDuGMdL6EeSDLevdaFPXHw")]
[DisplayName("Registered Contract Communication")]
public record RegisteredContractCommunication1
{
    /// <summary>
    /// Method by which the registered contract document is exchanged.
    /// </summary>
    [IsoId("_t3zksNL6EeSDLevdaFPXHw")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required CommunicationMethod4Code Method { get; init; }

    /// <summary>
    /// Date of the exchange.
    /// </summary>
    [IsoId("_8MZrsNL6EeSDLevdaFPXHw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; }
}
