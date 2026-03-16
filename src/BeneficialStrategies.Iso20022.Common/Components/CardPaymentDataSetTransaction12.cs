// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction to be authorised in a batch.
/// </summary>
[IsoId("_xsescWmMEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Data Set Transaction")]
public record CardPaymentDataSetTransaction12
{
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_x5micWmMEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }

    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_x5mic2mMEeS7iYydEtv3Ug")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability2? Traceability { get; init; }

    /// <summary>
    /// Data related to the environment of the card payment transaction to authorise.
    /// </summary>
    [IsoId("_x5midWmMEeS7iYydEtv3Ug")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment32 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_x5mid2mMEeS7iYydEtv3Ug")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext12? Context { get; init; }

    /// <summary>
    /// Card payment transaction to authorise.
    /// </summary>
    [IsoId("_x5mieWmMEeS7iYydEtv3Ug")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction47 Transaction { get; init; }
}
