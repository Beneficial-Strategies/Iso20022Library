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
[IsoId("_dwiMsNuREeiB5uLfkg9ZJA")]
[DisplayName("Batch Request")]
public record BatchRequest1
{
    /// <summary>
    /// Flag to remove all the transactions.
    /// </summary>
    [IsoId("_qPtDINuREeiB5uLfkg9ZJA")]
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Content of the Batch Request message.
    /// </summary>
    [IsoId("_td75sNuREeiB5uLfkg9ZJA")]
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public ValueList<TransactionToPerform1Choice_> TransactionToPerform { get; init; } = [];
}
