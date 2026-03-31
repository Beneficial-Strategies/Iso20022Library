// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Location10.
/// </summary>
[IsoId("_22HOUTEyEe6g-ffJsqGiSA")]
[DisplayName("Remittance Location10")]
public record RemittanceLocation10
{
    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required TransactionReferences8 References { get; init; }

    /// <summary>
    /// Remittance Identification.
    /// </summary>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Remittance Location Details.
    /// </summary>
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationData2> RemittanceLocationDetails { get; init; } = [];
}
