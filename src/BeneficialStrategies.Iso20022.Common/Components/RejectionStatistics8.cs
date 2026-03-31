// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
/// </summary>
[IsoId("_x9xzwVyGEe24CqbZJK5XxA")]
[DisplayName("Rejection Statistics")]
public record RejectionStatistics8
{
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_x-ovYVyGEe24CqbZJK5XxA")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData92 CounterpartyIdentification { get; init; }

    /// <summary>
    /// Information about accepted and rejected reports and the reasons of rejection.
    /// </summary>
    [IsoId("_x-ovY1yGEe24CqbZJK5XxA")]
    [DisplayName("Report Statistics")]
    [IsoXmlTag("RptSttstcs")]
    public required DetailedReportStatistics6 ReportStatistics { get; init; }

    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
    /// </summary>
    [IsoId("_x-ovZVyGEe24CqbZJK5XxA")]
    [DisplayName("Derivative Statistics")]
    [IsoXmlTag("DerivSttstcs")]
    public required DetailedTransactionStatistics6Choice_ DerivativeStatistics { get; init; }
}
