// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents information to identify a previous exchange.
/// </summary>
[IsoId("_YPBmEbYDEfCUZfsQO4rYeA")]
[DisplayName("Message Status Request9")]
public record MessageStatusRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_YP_2dbYDEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_YP_2e7YDEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Identification of the previous exchange.
    /// </summary>
    [IsoId("_YP_2gbYDEfCUZfsQO4rYeA")]
    [DisplayName("Message Status Request Data")]
    [IsoXmlTag("MsgStsReqData")]
    public required MessageStatusRequestData2 MessageStatusRequestData { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_YP_2h7YDEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
