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
[IsoId("_L0pD4Q03EeqUVL7sB4m7NA")]
[DisplayName("Message Status Request")]
public record MessageStatusRequest3
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_MAfukQ03EeqUVL7sB4m7NA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_MAfukw03EeqUVL7sB4m7NA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Identification of the previous exchange.
    /// </summary>
    [IsoId("_MAfulQ03EeqUVL7sB4m7NA")]
    [DisplayName("Message Status Request Data")]
    [IsoXmlTag("MsgStsReqData")]
    public required MessageStatusRequestData2 MessageStatusRequestData { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_MAfulw03EeqUVL7sB4m7NA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
