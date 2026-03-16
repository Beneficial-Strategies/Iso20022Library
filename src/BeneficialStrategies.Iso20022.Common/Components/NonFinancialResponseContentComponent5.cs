// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Financial Response Content Component5.
/// </summary>
[IsoId("_eD9ZwZ9cEe-nbM0aSPcoiQ")]
[DisplayName("Non Financial Response Content Component5")]
public partial record NonFinancialResponseContentComponent5
{
    #nullable enable

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
    public ValueList<Action17> Action { get; init; } = [];

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

    
    #nullable disable
    
}
