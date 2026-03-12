// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_M2S65W49EeiU9cctagi5ow")]
[DisplayName("Cash Account")]
public partial record CashAccount37
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_M_PbhW49EeiU9cctagi5ow")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    [IsoId("_M_Pbh249EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; } 
    
    /// <summary>
    /// Specifies the currency of the cash account.
    /// </summary>
    [IsoId("_M_PbiW49EeiU9cctagi5ow")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Specifies an alternate assumed name for the identification of the account. 
    /// </summary>
    [IsoId("_xwEtUXh1EeidzqjNEfehPg")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; } 
    
    /// <summary>
    /// Maximum amount value applied to or by a participant versus a set of counterparts. The multilateral system is taken into account by the transaction administrator to contain the risk in the system.|With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for whom no bilateral limit was set.
    /// </summary>
    [IsoId("_M_Pbi249EeiU9cctagi5ow")]
    [DisplayName("Current Multilateral Limit")]
    [IsoXmlTag("CurMulLmt")]
    public Limit5? CurrentMultilateralLimit { get; init; } 
    
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_M_PbjW49EeiU9cctagi5ow")]
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PartyIdentification135? Owner { get; init; } 
    
    /// <summary>
    /// Servicer of the account which is being queried.
    /// </summary>
    [IsoId("_M_Pbj249EeiU9cctagi5ow")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    
    /// <summary>
    /// Balance is calculated with regard to many members in the system.
    /// </summary>
    [IsoId("_M_PbkW49EeiU9cctagi5ow")]
    [DisplayName("Multilateral Balance")]
    [IsoXmlTag("MulBal")]
    public CashBalance13? MultilateralBalance { get; init; } 
    
    /// <summary>
    /// Limit fixed by a party A with regard to a specific counterparty B and corresponding to the maximum amount of traffic that party A may send to party B. The bilateral limit can be expressed as a debit limit or a credit limit. |With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// </summary>
    [IsoId("_M_Pbk249EeiU9cctagi5ow")]
    [DisplayName("Current Bilateral Limit")]
    [IsoXmlTag("CurBilLmt")]
    public BilateralLimit3? CurrentBilateralLimit { get; init; } 
    
    /// <summary>
    /// Instruction given by a party that has explicit authority to instruct a debit on the account, that is either the debtor or originating party, to the debtor agent, to process liquidity transfers at specified intervals during an implicit or explicit period of time. A standing order is given once and is valid for an open or closed period of time.
    /// </summary>
    [IsoId("_M_PblW49EeiU9cctagi5ow")]
    [DisplayName("Standing Order")]
    [IsoXmlTag("StgOrdr")]
    public StandingOrder6? StandingOrder { get; init; } 
    
    
    #nullable disable
    
}
