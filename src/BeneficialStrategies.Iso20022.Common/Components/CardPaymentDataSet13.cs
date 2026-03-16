// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
[IsoId("_ozFJQY3IEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet13
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_o988gY3IEeWjkqXgn_0Imw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_o988g43IEeWjkqXgn_0Imw")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_o988hY3IEeWjkqXgn_0Imw")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_o988h43IEeWjkqXgn_0Imw")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = [];

    // ID for the above is _o988h43IEeWjkqXgn_0Imw

    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_o988iY3IEeWjkqXgn_0Imw")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData5? CommonData { get; init; }

    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_o988i43IEeWjkqXgn_0Imw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction4Choice_> Transaction { get; init; } = [];
    // ID for the above is _o988i43IEeWjkqXgn_0Imw
}
