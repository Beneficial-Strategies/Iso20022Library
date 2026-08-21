// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_0IULUTEyEe6g-ffJsqGiSA")]
[Description(@"Provides information on the remittance advice.")]
[DisplayName("Remittance Location8")]
public record RemittanceLocation8
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationData2> RemittanceLocationDetails { get; init; } = [];
}
