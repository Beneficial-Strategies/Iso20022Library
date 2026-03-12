// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash management feature limiting the maximum risk a party accepts to take with respect to a counterparty or a set of counterparties. A risk management limit is either bilateral, ie, for a counterparty, or multilateral, ie, for a set of counterparties or all other members in a system.The limit may also apply to sponsored members, ie, indirect members. In principle, a risk management limit is calculated on the net position between two members and is expressed as a credit or debit limit, from the point of view of the party setting the limit.
/// </summary>
[IsoId("_jOt60O5NEeCisYr99QEiWA_-281816560")]
[DisplayName("Limit Identification")]
public partial record LimitIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by the account servicer to unambiguously identify the account.
    /// </summary>
    [IsoId("_jOt60e5NEeCisYr99QEiWA_932788374")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification4Choice_ AccountIdentification { get; init; } 
    
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    [IsoId("_jOt60u5NEeCisYr99QEiWA_-1514351595")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required LimitType4Code Type { get; init; } 
    
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    [IsoId("_jOt60-5NEeCisYr99QEiWA_2125379305")]
    [DisplayName("Limit Currency")]
    [IsoXmlTag("LmtCcy")]
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_jOt61O5NEeCisYr99QEiWA_-1060264326")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    public required IsoBICFIIdentifier AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [IsoId("_jO3r0O5NEeCisYr99QEiWA_-1722859271")]
    [DisplayName("Bilateral Limit Counterparty Identification")]
    [IsoXmlTag("BilLmtCtrPtyId")]
    public SystemPartyIdentification4? BilateralLimitCounterpartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
