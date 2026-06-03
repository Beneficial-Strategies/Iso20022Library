// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the environment, the context and the services to be used with this message.
/// </summary>
[IsoId("_xVci0bYBEfCUZfsQO4rYeA")]
[DisplayName("Message Status Response10")]
public record MessageStatusResponse10
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_xWV6tbYBEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_xWV6u7YBEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Content of the message status response.
    /// </summary>
    [IsoId("_xWV6wbYBEfCUZfsQO4rYeA")]
    [DisplayName("Message Status Response Data")]
    [IsoXmlTag("MsgStsRspnData")]
    public required MessageStatusResponseData10 MessageStatusResponseData { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_xWV6x7YBEfCUZfsQO4rYeA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_xWV6zbYBEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
