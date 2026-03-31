// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_QEp0kNp-Ed-ak6NoX_4Aeg_792527554")]
[DisplayName("BIC Identification")]
public record BICIdentification1
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QEp0kdp-Ed-ak6NoX_4Aeg_792527555")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public required IsoBICIdentifier BIC { get; init; }
}
