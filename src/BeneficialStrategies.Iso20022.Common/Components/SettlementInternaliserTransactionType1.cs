// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data per transaction type for a settlement internaliser.
/// </summary>
[IsoId("_ZsjzoO3oEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Transaction Type")]
public partial record SettlementInternaliserTransactionType1
{
    #nullable enable
    
    /// <summary>
    /// Purchase or sale of securities.
    /// </summary>
    [IsoId("_5qB10O3oEeaWjpoyrnG6Rw")]
    [DisplayName("Securities Buy Or Sell")]
    [IsoXmlTag("SctiesBuyOrSell")]
    public required InternalisationData1 SecuritiesBuyOrSell { get; init; } 
    
    /// <summary>
    /// Relates to securities transfers aiming to provide or to return collateral.
    /// </summary>
    [IsoId("__U4f0O3oEeaWjpoyrnG6Rw")]
    [DisplayName("Collateral Management Operation")]
    [IsoXmlTag("CollMgmtOpr")]
    public required InternalisationData1 CollateralManagementOperation { get; init; } 
    
    /// <summary>
    /// Relates to a securities lending or borrowing operation.
    /// </summary>
    [IsoId("_D0A9kO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Securities Lending Or Borrowing")]
    [IsoXmlTag("SctiesLndgOrBrrwg")]
    public required InternalisationData1 SecuritiesLendingOrBorrowing { get; init; } 
    
    /// <summary>
    /// Repurchase transactions.
    /// </summary>
    [IsoId("_GQqmMO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Repurchase Agreement")]
    [IsoXmlTag("RpAgrmt")]
    public required InternalisationData1 RepurchaseAgreement { get; init; } 
    
    /// <summary>
    /// Covers any securities transactions type not covered as a dedicated type.
    /// </summary>
    [IsoId("_RMMfoO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Other Transactions")]
    [IsoXmlTag("OthrTxs")]
    public required InternalisationData1 OtherTransactions { get; init; } 
    
    
    #nullable disable
    
}
