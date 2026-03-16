// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Movements4.
/// </summary>
[IsoId("_3syXoTEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Movements4")]
public partial record IntraBalanceMovements4
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
    /// Movement.
    /// </summary>
    [DisplayName("Movement")]
    [IsoXmlTag("Mvmnt")]
    public ValueList<IntraBalanceMovement7> Movement { get; init; } = [];

    /// <summary>
    /// Status And Reason.
    /// </summary>
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public IntraBalanceStatusAndReason2? StatusAndReason { get; init; } 

    
    #nullable disable
    
}
