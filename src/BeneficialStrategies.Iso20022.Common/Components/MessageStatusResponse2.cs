// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context
/// and the services to be used with this message.
/// </summary>
[IsoId("_CeKZYYYDEemxIqbaFEE8-w")]
[DisplayName("Message Status Response")]
public record MessageStatusResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_CoZTcYYDEemxIqbaFEE8-w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment73 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_CoZTc4YDEemxIqbaFEE8-w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext27 Context { get; init; }

    /// <summary>
    /// Content of the Message status Response.
    /// </summary>
    [IsoId("_CoZTdYYDEemxIqbaFEE8-w")]
    [DisplayName("Message Status Response Data")]
    [IsoXmlTag("MsgStsRspnData")]
    public required MessageStatusResponseData2 MessageStatusResponseData { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_CoZTd4YDEemxIqbaFEE8-w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_CoZTeYYDEemxIqbaFEE8-w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
