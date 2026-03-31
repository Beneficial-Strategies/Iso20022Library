// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment related to the reconciliation of the transaction.
/// </summary>
[IsoId("_3zNAcU93EeePXdaAO32Uew")]
[DisplayName("Environment")]
public record Environment3
{
    /// <summary>
    /// Initiator of the process.
    /// </summary>
    [IsoId("_3-g4kU93EeePXdaAO32Uew")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification197? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the destination.
    /// </summary>
    [IsoId("_3-g4k093EeePXdaAO32Uew")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_3-g4lU93EeePXdaAO32Uew")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; }

    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_Pncm0E96EeePXdaAO32Uew")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification197? Destination { get; init; }
}
