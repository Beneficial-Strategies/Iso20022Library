// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation response from the acquirer.
/// </summary>
[IsoId("_qwueYXJXEe299ZbWCkdR_w")]
[DisplayName("Acceptor Authorisation Response")]
public record AcceptorAuthorisationResponse12
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_q3ZHEXJXEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; }

    /// <summary>
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_q3ZHE3JXEe299ZbWCkdR_w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction129 Transaction { get; init; }

    /// <summary>
    /// Authorisation response from the acquirer.
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_q3ZHFXJXEe299ZbWCkdR_w")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction128 TransactionResponse { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_q3ZHF3JXEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
