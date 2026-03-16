// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Report35.
/// </summary>
[IsoId("_3zeOdTEyEe6g-ffJsqGiSA")]
[DisplayName("Account Report35")]
public record AccountReport35
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification4Choice_ AccountIdentification { get; init; }

    /// <summary>
    /// Account Or Error.
    /// </summary>
    [DisplayName("Account Or Error")]
    [IsoXmlTag("AcctOrErr")]
    public required AccountOrBusinessError6Choice_ AccountOrError { get; init; }
}
