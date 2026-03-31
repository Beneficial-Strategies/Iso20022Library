// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Payment Data Set Transaction46.
/// </summary>
[IsoId("_Bjc90ZH2Ee6qwqnYOGEReg")]
[DisplayName("Card Payment Data Set Transaction46")]
public record CardPaymentDataSetTransaction46
{
    /// <summary>
    /// Context.
    /// </summary>
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext30? Context { get; init; }

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; }

    /// <summary>
    /// Traceability.
    /// </summary>
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required CardPaymentTransaction116 Transaction { get; init; }

    /// <summary>
    /// Transaction Sequence Counter.
    /// </summary>
    [DisplayName("Transaction Sequence Counter")]
    [IsoXmlTag("TxSeqCntr")]
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; }
}
