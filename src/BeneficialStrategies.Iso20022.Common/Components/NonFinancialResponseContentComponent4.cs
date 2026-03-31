// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Financial Response Content Component4.
/// </summary>
[IsoId("_BWeW8ZHkEe6qwqnYOGEReg")]
[DisplayName("Non Financial Response Content Component4")]
public record NonFinancialResponseContentComponent4
{
    /// <summary>
    /// Acquirer Selected.
    /// </summary>
    [DisplayName("Acquirer Selected")]
    [IsoXmlTag("AcqrrSelctd")]
    public Acquirer10? AcquirerSelected { get; init; }

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action15> Action { get; init; } = [];

    /// <summary>
    /// Additional Response.
    /// </summary>
    [DisplayName("Additional Response")]
    [IsoXmlTag("AddtlRspn")]
    public ValueList<ExternallyDefinedData5> AdditionalResponse { get; init; } = [];

    /// <summary>
    /// Instalment.
    /// </summary>
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public ValueList<RecurringTransaction6> Instalment { get; init; } = [];

    /// <summary>
    /// Non Financial Request Type.
    /// </summary>
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public required NonFinancialRequestType2Code NonFinancialRequestType { get; init; }

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Risk Management Result.
    /// </summary>
    [DisplayName("Risk Management Result")]
    [IsoXmlTag("RskMgmtRslt")]
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; }
}
