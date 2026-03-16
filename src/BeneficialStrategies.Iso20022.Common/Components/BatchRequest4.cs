// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a Batch service.
/// </summary>
[IsoId("_rZAYYU35Eey_VecAUE-C9Q")]
[DisplayName("Batch Request")]
public record BatchRequest4
{
    /// <summary>
    /// Sale System identification of the batch in an unambiguous way.
    /// </summary>
    [IsoId("_ahgJgU7aEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; }

    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_rfZ7UU35Eey_VecAUE-C9Q")]
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_rfaiYU35Eey_VecAUE-C9Q")]
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public TransactionToPerform4Choice_? TransactionToPerform { get; init; }
}
