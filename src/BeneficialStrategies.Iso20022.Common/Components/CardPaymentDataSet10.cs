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
[IsoId("_ZjQG0WmFEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Data Set")]
public record CardPaymentDataSet10
{
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_ZxFHcWmFEeS7iYydEtv3Ug")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DataSetIdentification1 DataSetIdentification { get; init; }

    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_ZxFHc2mFEeS7iYydEtv3Ug")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability2? Traceability { get; init; }

    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_ZxFHdWmFEeS7iYydEtv3Ug")]
    [DisplayName("Data Set Initiator")]
    [IsoXmlTag("DataSetInitr")]
    public GenericIdentification53? DataSetInitiator { get; init; }

    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_ZxFHd2mFEeS7iYydEtv3Ug")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals3> TransactionTotals { get; init; } = [];

    // ID for the above is _ZxFHd2mFEeS7iYydEtv3Ug

    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_ZxFHeWmFEeS7iYydEtv3Ug")]
    [DisplayName("Common Data")]
    [IsoXmlTag("CmonData")]
    public CommonData4? CommonData { get; init; }

    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_ZxFHe2mFEeS7iYydEtv3Ug")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction3Choice_> Transaction { get; init; } = [];
    // ID for the above is _ZxFHe2mFEeS7iYydEtv3Ug
}
