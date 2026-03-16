// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction including an authorisation response.
/// </summary>
[IsoId("_G2-PoU0ZEeybj420QgWBkA")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction38
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_G9cEAU0ZEeybj420QgWBkA")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_G9cEA00ZEeybj420QgWBkA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];

    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    [IsoId("_G9cEBU0ZEeybj420QgWBkA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    [IsoId("_G9cEB00ZEeybj420QgWBkA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction121 Transaction { get; init; }

    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    [IsoId("_G9cECU0ZEeybj420QgWBkA")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction114 TransactionResponse { get; init; }
}
