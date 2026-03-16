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
[IsoId("_vGRpwWmNEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction13
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_vTj30WmNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_vTj302mNEeS7iYydEtv3Ug")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability2? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    [IsoId("_vTj31WmNEeS7iYydEtv3Ug")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment41 Environment { get; init; }

    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    [IsoId("_vTj312mNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction48 Transaction { get; init; }

    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    [IsoId("_vTj32WmNEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required CardPaymentTransaction39 TransactionResponse { get; init; }
}
