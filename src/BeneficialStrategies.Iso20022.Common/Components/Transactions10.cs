// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on transactions.
/// </summary>
[IsoId("_7tkDpQKxEe2rHs6fbn9-0A")]
[DisplayName("Transactions")]
public partial record Transactions10
{
    #nullable enable
    
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    [IsoId("_8Wpc5wKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment Common Information")]
    [IsoXmlTag("PmtCmonInf")]
    public PaymentCommon5? PaymentCommonInformation { get; init; } 
    
    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    [IsoId("_8Wpc6QKxEe2rHs6fbn9-0A")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    
    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    [IsoId("_8Wpc6wKxEe2rHs6fbn9-0A")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<TransactionReport7> TransactionReport { get; init; } = [];
    // ID for the above is _8Wpc6wKxEe2rHs6fbn9-0A
    
    
    #nullable disable
    
}
