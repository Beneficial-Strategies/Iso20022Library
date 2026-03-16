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
[IsoId("_PiJcMXGyEe2TbaNWBpRZpQ")]
[DisplayName("Batch Request")]
public record BatchRequest5
{
    /// <summary>
    /// Sale System identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_PoYAAXGyEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; }

    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_PoYAA3GyEe2TbaNWBpRZpQ")]
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_PoYABXGyEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public ValueList<TransactionToPerform5Choice_> TransactionToPerform { get; init; } = [];
}
