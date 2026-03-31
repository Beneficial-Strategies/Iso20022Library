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
[IsoId("_PdnCo9p-Ed-ak6NoX_4Aeg_-1749118143")]
[DisplayName("Account Identification")]
public record AccountIdentification1
{
    /// <summary>
    /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
    /// </summary>
    [IsoId("_PdnCpNp-Ed-ak6NoX_4Aeg_-1749118142")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public required SimpleIdentificationInformation Proprietary { get; init; }
}
