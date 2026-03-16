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
[IsoId("_gMF4cap0EeanIZ10Ka8PnA")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet16
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_gWwQUap0EeanIZ10Ka8PnA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification5 DataSetIdentification { get; init; }

    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_gWwQU6p0EeanIZ10Ka8PnA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability5? Traceability { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_gWwQVap0EeanIZ10Ka8PnA")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_gWwQV6p0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals7> TransactionTotals { get; init; } = [];

    // ID for the above is _gWwQV6p0EeanIZ10Ka8PnA

    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_gWwQWap0EeanIZ10Ka8PnA")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData6? CommonData { get; init; }

    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_gWwQW6p0EeanIZ10Ka8PnA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction5Choice_> Transaction { get; init; } = [];
    // ID for the above is _gWwQW6p0EeanIZ10Ka8PnA
}
