// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Modification8.
/// </summary>
[IsoId("_7wCKszEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Modification8")]
public partial record IntraBalanceModification8
{
    #nullable enable

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccount40? CashAccount { get; init; } 

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; } 

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; } 

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus71Choice_? ProcessingStatus { get; init; } 

    /// <summary>
    /// Request Details.
    /// </summary>
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public RequestDetails22? RequestDetails { get; init; } 

    /// <summary>
    /// Request Reference.
    /// </summary>
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    public required IsoMax35Text RequestReference { get; init; } 

    /// <summary>
    /// Status Date.
    /// </summary>
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public IsoISODateTime? StatusDate { get; init; } 

    /// <summary>
    /// Underlying Intra Balance.
    /// </summary>
    [DisplayName("Underlying Intra Balance")]
    [IsoXmlTag("UndrlygIntraBal")]
    public IntraBalance5? UnderlyingIntraBalance { get; init; } 

    
    #nullable disable
    
}
