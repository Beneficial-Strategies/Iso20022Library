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
[IsoId("_kiglgQxrEeqdx6buGpCCQw")]
[DisplayName("Batch Request")]
public record BatchRequest2
{
    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_ktg7oQxrEeqdx6buGpCCQw")]
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_ktg7owxrEeqdx6buGpCCQw")]
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public TransactionToPerform2Choice_? TransactionToPerform { get; init; }
}
