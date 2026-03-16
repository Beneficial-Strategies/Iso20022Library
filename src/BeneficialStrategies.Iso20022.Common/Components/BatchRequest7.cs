// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Batch Request7.
/// </summary>
[IsoId("_uKia0aEUEe-MRKYsaX6JDg")]
[DisplayName("Batch Request7")]
public record BatchRequest7
{
    /// <summary>
    /// Remove All Flag.
    /// </summary>
    [DisplayName("Remove All Flag")]
    [IsoXmlTag("RmvAllFlg")]
    public IsoTrueFalseIndicator? RemoveAllFlag { get; init; }

    /// <summary>
    /// Sale Batch Identification.
    /// </summary>
    [DisplayName("Sale Batch Identification")]
    [IsoXmlTag("SaleBtchId")]
    public TransactionIdentifier1? SaleBatchIdentification { get; init; }

    /// <summary>
    /// Transaction To Perform.
    /// </summary>
    [DisplayName("Transaction To Perform")]
    [IsoXmlTag("TxToPrfrm")]
    public ValueList<TransactionToPerform7Choice_> TransactionToPerform { get; init; } = [];
}
