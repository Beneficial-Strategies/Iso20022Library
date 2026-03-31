// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party And Certificate6.
/// </summary>
[IsoId("_ydFYlTEyEe6g-ffJsqGiSA")]
[DisplayName("Party And Certificate6")]
public record PartyAndCertificate6
{
    /// <summary>
    /// Certificate.
    /// </summary>
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public IsoMax10KBinary? Certificate { get; init; }

    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification272 Party { get; init; }
}
