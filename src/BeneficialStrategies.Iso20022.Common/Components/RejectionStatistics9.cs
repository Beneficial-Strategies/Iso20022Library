// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejection Statistics9.
/// </summary>
[IsoId("_l4cXEfreEe2mU4Wi2q3MzQ")]
[DisplayName("Rejection Statistics9")]
public record RejectionStatistics9
{
    /// <summary>
    /// Counterparty Identification.
    /// </summary>
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData92 CounterpartyIdentification { get; init; }

    /// <summary>
    /// Derivative Statistics.
    /// </summary>
    [DisplayName("Derivative Statistics")]
    [IsoXmlTag("DerivSttstcs")]
    public required DetailedTransactionStatistics7Choice_ DerivativeStatistics { get; init; }

    /// <summary>
    /// Report Statistics.
    /// </summary>
    [DisplayName("Report Statistics")]
    [IsoXmlTag("RptSttstcs")]
    public required DetailedReportStatistics7 ReportStatistics { get; init; }
}
