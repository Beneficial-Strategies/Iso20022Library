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
[IsoId("_tohNsU0ZEeybj420QgWBkA")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet29
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_tu0qAU0ZEeybj420QgWBkA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_tu0qA00ZEeybj420QgWBkA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability8> Traceability { get; init; } = [];

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_tu0qBU0ZEeybj420QgWBkA")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification176? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_tu0qB00ZEeybj420QgWBkA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = [];

    // ID for the above is _tu0qB00ZEeybj420QgWBkA

    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_tu0qCU0ZEeybj420QgWBkA")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData11? CommonData { get; init; }

    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_tu0qC00ZEeybj420QgWBkA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction10Choice_> Transaction { get; init; } = [];
    // ID for the above is _tu0qC00ZEeybj420QgWBkA
}
