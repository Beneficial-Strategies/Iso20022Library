// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of an account, as assigned by the account servicer.
/// </summary>
[IsoId("_ku_soSxxEeKgiYs1KJCQUg")]
[DisplayName("Account Identification")]
public record AccountIdentification26
{
    /// <summary>
    /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
    /// </summary>
    [IsoId("_lDQscSxxEeKgiYs1KJCQUg")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public required SimpleIdentificationInformation4 Proprietary { get; init; }
}
