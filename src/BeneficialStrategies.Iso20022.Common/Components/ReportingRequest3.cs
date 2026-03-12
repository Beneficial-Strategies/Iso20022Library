// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reporting request.
/// </summary>
[IsoId("_tmkLxFkyEeGeoaLUQk__nA_-763760907")]
[DisplayName("Reporting Request")]
public partial record ReportingRequest3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account reporting request.
    /// </summary>
    [IsoId("_tmt8wFkyEeGeoaLUQk__nA_-1760833260")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Specifies the type of the requested reporting message.
    /// </summary>
    [IsoId("_tmt8wVkyEeGeoaLUQk__nA_-1195376634")]
    [DisplayName("Requested Message Name Identification")]
    [IsoXmlTag("ReqdMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RequestedMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account to which the reporting request refers.
    /// </summary>
    [IsoId("_tmt8wlkyEeGeoaLUQk__nA_927327284")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount24? Account { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_tmt8w1kyEeGeoaLUQk__nA_1089633804")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required Party12Choice_ AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tm3twFkyEeGeoaLUQk__nA_1850398957")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    
    /// <summary>
    /// Specifies the requested reporting period.
    /// </summary>
    [IsoId("_tm3twVkyEeGeoaLUQk__nA_1839300180")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public ReportingPeriod1? ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Identifies the transactions to be reported.
    /// </summary>
    [IsoId("_tm3twlkyEeGeoaLUQk__nA_282932778")]
    [DisplayName("Requested Transaction Type")]
    [IsoXmlTag("ReqdTxTp")]
    public TransactionType1? RequestedTransactionType { get; init; } 
    
    /// <summary>
    /// Provides details on the requested balance reporting.
    /// </summary>
    [IsoId("_tm3tw1kyEeGeoaLUQk__nA_-1224719927")]
    [DisplayName("Requested Balance Type")]
    [IsoXmlTag("ReqdBalTp")]
    public BalanceType12? RequestedBalanceType { get; init; } 
    
    
    #nullable disable
    
}
