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
[IsoId("_U6SqEVS7EeuUvsVXOV79DQ")]
[DisplayName("Message Status Response")]
public record MessageStatusResponse5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_VB9_YVS7EeuUvsVXOV79DQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment77 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_VB9_Y1S7EeuUvsVXOV79DQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; }

    /// <summary>
    /// Content of the Message status Response.
    /// </summary>
    [IsoId("_VB9_ZVS7EeuUvsVXOV79DQ")]
    [DisplayName("Message Status Response Data")]
    [IsoXmlTag("MsgStsRspnData")]
    public required MessageStatusResponseData5 MessageStatusResponseData { get; init; }

    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_VB9_Z1S7EeuUvsVXOV79DQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_VB9_aVS7EeuUvsVXOV79DQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
