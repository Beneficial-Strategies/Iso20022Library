// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the type of admin service to be used with this message.
/// </summary>
[IsoId("__r8l4YYBEemxIqbaFEE8-w")]
[DisplayName("Administrative Response")]
public record AdministrativeResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("__2mWsYYBEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("__2mWs4YBEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("__2mWtYYBEemxIqbaFEE8-w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("__2mWt4YBEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
