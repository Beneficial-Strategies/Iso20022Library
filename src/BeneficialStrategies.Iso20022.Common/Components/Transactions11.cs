// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transactions11.
/// </summary>
[IsoId("_1paxszEyEe6g-ffJsqGiSA")]
[DisplayName("Transactions11")]
public partial record Transactions11
{
    #nullable enable

    /// <summary>
    /// Payment Common Information.
    /// </summary>
    [DisplayName("Payment Common Information")]
    [IsoXmlTag("PmtCmonInf")]
    public PaymentCommon6? PaymentCommonInformation { get; init; } 

    /// <summary>
    /// Transaction Report.
    /// </summary>
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<TransactionReport8> TransactionReport { get; init; } = [];

    /// <summary>
    /// Transactions Summary.
    /// </summary>
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 

    
    #nullable disable
    
}
