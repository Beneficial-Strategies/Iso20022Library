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
[IsoId("_eun4sdtQEee9e6xduATmQg")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction25
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_e3dEkdtQEee9e6xduATmQg")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_e3dEk9tQEee9e6xduATmQg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    [IsoId("_e3dEldtQEee9e6xduATmQg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment69 Environment { get; init; }

    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    [IsoId("_e3dEl9tQEee9e6xduATmQg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction78 Transaction { get; init; }

    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    [IsoId("_e3dEmdtQEee9e6xduATmQg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction84 TransactionResponse { get; init; }
}
