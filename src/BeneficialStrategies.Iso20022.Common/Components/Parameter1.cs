// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters associated to a cryptographic algorithm.
/// </summary>
[IsoId("_Sw--tQEcEeCQm6a_G2yO_w_1068010819")]
[DisplayName("Parameter")]
public record Parameter1
{
    /// <summary>
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    [IsoId("_Sw--tgEcEeCQm6a_G2yO_w_498114806")]
    [DisplayName("Initialisation Vector")]
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public IsoMax500Binary? InitialisationVector { get; init; }
}
