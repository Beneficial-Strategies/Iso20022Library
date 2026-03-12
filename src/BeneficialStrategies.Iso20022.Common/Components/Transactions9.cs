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
[IsoId("_df3oMdcZEeqRFcf2R4bPBw")]
[DisplayName("Transactions")]
public partial record Transactions9
{
    #nullable enable
    
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    [IsoId("_dhhOB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Common Information")]
    [IsoXmlTag("PmtCmonInf")]
    public PaymentCommon5? PaymentCommonInformation { get; init; } 
    
    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    [IsoId("_dhhOCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transactions Summary")]
    [IsoXmlTag("TxsSummry")]
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    
    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    [IsoId("_dhhOC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ValueList<TransactionReport6> TransactionReport { get; init; } = new ValueList<TransactionReport6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _dhhOC9cZEeqRFcf2R4bPBw
    
    
    #nullable disable
    
}
