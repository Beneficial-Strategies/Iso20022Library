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
[IsoId("_3VGegTKQEeOqyZqt0rCZLg")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet7
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_3kIZATKQEeOqyZqt0rCZLg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; }

    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_3kIZAzKQEeOqyZqt0rCZLg")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public ValueList<Traceability1> Traceability { get; init; } = [];

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_3kIZBTKQEeOqyZqt0rCZLg")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification32? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_3kIZBzKQEeOqyZqt0rCZLg")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals2> TransactionTotals { get; init; } = [];

    // ID for the above is _3kIZBzKQEeOqyZqt0rCZLg

    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_3kIZCTKQEeOqyZqt0rCZLg")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData3? CommonData { get; init; }

    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_3kIZCzKQEeOqyZqt0rCZLg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction2Choice_> Transaction { get; init; } = [];
    // ID for the above is _3kIZCzKQEeOqyZqt0rCZLg
}
