// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Batch Request6.
/// </summary>
[IsoId("_eF_1AZTaEe6sd81HehWb6w")]
[DisplayName("Batch Request6")]
public partial record BatchRequest6
{
    #nullable enable

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
    public ValueList<TransactionToPerform6Choice_> TransactionToPerform { get; init; } = [];

    
    #nullable disable
    
}
