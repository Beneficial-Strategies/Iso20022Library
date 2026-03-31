// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction for Inquiry.
/// </summary>
[IsoId("_Ru_cefJFEeiJn9rM2Znz2w")]
[DisplayName("Environment")]
public record Environment16
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_Ru_cfvJFEeiJn9rM2Znz2w")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification197 Acquirer { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_Ru_cf_JFEeiJn9rM2Znz2w")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_Ru_cevJFEeiJn9rM2Znz2w")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; }

    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_Oz4gwfJGEeiJn9rM2Znz2w")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification197? Destination { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_Ru_ce_JFEeiJn9rM2Znz2w")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData2? Card { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_JivXQfJGEeiJn9rM2Znz2w")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; }
}
