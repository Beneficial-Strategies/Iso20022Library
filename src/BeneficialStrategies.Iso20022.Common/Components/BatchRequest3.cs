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
[IsoId("_3uU-gS8QEeu125Ip9zFcsQ")]
[DisplayName("Batch Request")]
public record BatchRequest3
{
    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_36DtYS8QEeu125Ip9zFcsQ")]
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_36DtYy8QEeu125Ip9zFcsQ")]
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public TransactionToPerform3Choice_? TransactionToPerform { get; init; }
}
