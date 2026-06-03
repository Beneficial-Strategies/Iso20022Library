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
[IsoId("_CHyokbZYEfCUZfsQO4rYeA")]
[DisplayName("Non Financial Response Content Component6")]
public record NonFinancialResponseContentComponent6
{
    /// <summary>
    /// Type of non financial request that the acquirer processed.
    /// </summary>
    [IsoId("_CIsnhbZYEfCUZfsQO4rYeA")]
    [DisplayName("Non Financial Request Type")]
    [IsoXmlTag("NonFinReqTp")]
    public required NonFinancialRequestType2Code NonFinancialRequestType { get; init; }

    /// <summary>
    /// Identification of the most relevant acquirer to process the transaction.
    /// </summary>
    [IsoId("_CIsni7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Acquirer Selected")]
    [IsoXmlTag("AcqrrSelctd")]
    public Acquirer10? AcquirerSelected { get; init; }

    /// <summary>
    /// Advice from the acquirer (or its agent) to the POI to manage risk.
    /// </summary>
    [IsoId("_CIsnkbZYEfCUZfsQO4rYeA")]
    [DisplayName("Risk Management Result")]
    [IsoXmlTag("RskMgmtRslt")]
    public NonFinancialResponseRisk1Code? RiskManagementResult { get; init; }

    /// <summary>
    /// Details of instalment supported by the service provider.
    /// </summary>
    [IsoId("_CIsnl7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public ValueList<RecurringTransaction7> Instalment { get; init; } = [];

    /// <summary>
    /// Additional elements sent by the service provider which are not linked to payment.
    /// </summary>
    [IsoId("_CIsnnbZYEfCUZfsQO4rYeA")]
    [DisplayName("Additional Response")]
    [IsoXmlTag("AddtlRspn")]
    public ValueList<ExternallyDefinedData5> AdditionalResponse { get; init; } = [];

    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_CIsno7ZYEfCUZfsQO4rYeA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action18> Action { get; init; } = [];

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_CIsnqbZYEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }
}
