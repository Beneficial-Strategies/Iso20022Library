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
[IsoId("_HGlzoap0EeanIZ10Ka8PnA")]
[DisplayName("Acceptor Authorisation Response")]
public record AcceptorAuthorisationResponse6
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_HRKE4ap0EeanIZ10Ka8PnA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment65 Environment { get; init; }

    /// <summary>
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_HRKE46p0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction77 Transaction { get; init; }

    /// <summary>
    /// Authorisation response from the acquirer.
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_HRKE5ap0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction67 TransactionResponse { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_HRKE56p0EeanIZ10Ka8PnA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
