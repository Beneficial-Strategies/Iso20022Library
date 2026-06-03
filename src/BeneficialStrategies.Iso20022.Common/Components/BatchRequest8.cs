// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a batch service.
/// </summary>
[IsoId("_QXsx8bZaEfCUZfsQO4rYeA")]
[DisplayName("Batch Request8")]
public record BatchRequest8
{
    /// <summary>
    /// Sale System identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_QYpNJbZaEfCUZfsQO4rYeA")]
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; }

    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_QYpNK7ZaEfCUZfsQO4rYeA")]
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_QYpNMbZaEfCUZfsQO4rYeA")]
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public ValueList<TransactionToPerform8Choice_> TransactionToPerform { get; init; } = [];
}
