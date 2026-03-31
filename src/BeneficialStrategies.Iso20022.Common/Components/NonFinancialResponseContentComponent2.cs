// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Aim of the non financial response.
/// </summary>
[IsoId("_IHp2YU0DEeybj420QgWBkA")]
[DisplayName("Non Financial Response Content Component")]
public record NonFinancialResponseContentComponent2
{
    /// <summary>
    /// Type of non financial request that the Acquirer processed.
    /// </summary>
    [IsoId("_IOwj8U0DEeybj420QgWBkA")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public required NonFinancialRequestType1Code NonFinancialRequestType { get; init; }

    /// <summary>
    /// Identification of the most relevant Acquirer to process the transaction.
    /// </summary>
    [IsoId("_IOwj800DEeybj420QgWBkA")]
    [DisplayName("Acquirer Selected")]
    [IsoXmlTag("AcqrrSelctd")]
    public Acquirer10? AcquirerSelected { get; init; }

    /// <summary>
    /// Advice from the Acquirer (or its Agent) to the POI to manage risk.
    /// </summary>
    [IsoId("_IOwj9U0DEeybj420QgWBkA")]
    [DisplayName("Risk Management Result")]
    [IsoXmlTag("RskMgmtRslt")]
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; }

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_IOwj900DEeybj420QgWBkA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action12> Action { get; init; } = [];

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_IOwj-U0DEeybj420QgWBkA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }
}
