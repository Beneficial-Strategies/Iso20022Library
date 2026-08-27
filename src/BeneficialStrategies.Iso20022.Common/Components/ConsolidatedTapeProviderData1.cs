// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the Consolidated Tape Provider.
/// </summary>
[IsoId("_gBfUUGImEfCeoPFCHQnhvA")]
[DisplayName("Consolidated Tape Provider Data1")]
public record ConsolidatedTapeProviderData1
{
    /// <summary>
    /// Date and time when the transaction was received by the Consolidated Tape Provider (CTP).
    /// Usage: Only applicable for output data.
    /// </summary>
    [IsoId("_qVZ0IGImEfCeoPFCHQnhvA")]
    [DisplayName("Reception Date Time")]
    [IsoXmlTag("RcptnDtTm")]
    public required IsoISODateTime ReceptionDateTime { get; init; }

    /// <summary>
    /// Date and time when the transaction was published by the Consolidated Tape Provider (CTP).
    /// Usage: Only applicable for output data.
    /// </summary>
    [IsoId("_vbztQGImEfCeoPFCHQnhvA")]
    [DisplayName("Dissemination Date Time")]
    [IsoXmlTag("DssmntnDtTm")]
    public required IsoISODateTime DisseminationDateTime { get; init; }
}
