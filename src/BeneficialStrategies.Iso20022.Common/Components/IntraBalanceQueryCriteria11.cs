// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intra Balance Query Criteria11.
/// </summary>
[IsoId("_7D3oNTEyEe6g-ffJsqGiSA")]
[DisplayName("Intra Balance Query Criteria11")]
public partial record IntraBalanceQueryCriteria11
{
    #nullable enable

    /// <summary>
    /// Balance Type.
    /// </summary>
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public ValueList<IntraBalanceType3> BalanceType { get; init; } = [];

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> CashAccount { get; init; } = [];

    /// <summary>
    /// Cash Account Owner.
    /// </summary>
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public ValueList<SystemPartyIdentification8> CashAccountOwner { get; init; } = [];

    /// <summary>
    /// Cash Account Servicer.
    /// </summary>
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? CashAccountServicer { get; init; } 

    /// <summary>
    /// Cash Sub Balance Identification.
    /// </summary>
    [DisplayName("Cash Sub Balance Identification")]
    [IsoXmlTag("CshSubBalId")]
    public ValueList<GenericIdentification37> CashSubBalanceIdentification { get; init; } = [];

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; } 

    /// <summary>
    /// Effective Settlement Date.
    /// </summary>
    [DisplayName("Effective Settlement Date")]
    [IsoXmlTag("FctvSttlmDt")]
    public DateAndDateTimeSearch5Choice_? EffectiveSettlementDate { get; init; } 

    /// <summary>
    /// Intended Settlement Date.
    /// </summary>
    [DisplayName("Intended Settlement Date")]
    [IsoXmlTag("IntnddSttlmDt")]
    public DateAndDateTimeSearch5Choice_? IntendedSettlementDate { get; init; } 

    /// <summary>
    /// Message Originator.
    /// </summary>
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = [];

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public ValueList<PriorityNumeric4Choice_> Priority { get; init; } = [];

    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<References36Choice_> References { get; init; } = [];

    /// <summary>
    /// Settled Amount.
    /// </summary>
    [DisplayName("Settled Amount")]
    [IsoXmlTag("SttldAmt")]
    public ImpliedCurrencyAmountRange1Choice_? SettledAmount { get; init; } 

    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ImpliedCurrencyAmountRange1Choice_? SettlementAmount { get; init; } 

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ValueList<ActiveOrHistoricCurrencyCode> SettlementCurrency { get; init; } = [];

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public IntraBalanceQueryStatus3? Status { get; init; } 

    
    #nullable disable
    
}
