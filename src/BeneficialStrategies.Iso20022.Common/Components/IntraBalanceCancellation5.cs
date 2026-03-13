// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the cancellation requests data in the report.
/// </summary>
[IsoId("_p-rkdTnfEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Cancellation")]
public partial record IntraBalanceCancellation5
{
    #nullable enable
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_qIqm6TnfEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount38? CashAccount { get; init; } 
    
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [IsoId("_qIqm5znfEem7JZMuWtwtsg")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_rLDQsTp-EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_qIqm6znfEem7JZMuWtwtsg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus69Choice_? ProcessingStatus { get; init; } 
    
    /// <summary>
    /// Further details of the individual intrabalance cancellation transaction.
    /// </summary>
    [IsoId("_qIqm7TnfEem7JZMuWtwtsg")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public ValueList<IntraBalanceCancellation6> Cancellation { get; init; } = [];
    // ID for the above is _qIqm7TnfEem7JZMuWtwtsg
    
    
    #nullable disable
    
}
