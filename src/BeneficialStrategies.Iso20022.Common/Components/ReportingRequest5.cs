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
[IsoId("_GF3v8W49EeiU9cctagi5ow")]
[DisplayName("Reporting Request")]
public partial record ReportingRequest5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account reporting request.
    /// </summary>
    [IsoId("_GPQVc249EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Specifies the type of the requested reporting message.
    /// </summary>
    [IsoId("_GPQVdW49EeiU9cctagi5ow")]
    [DisplayName("Requested Message Name Identification")]
    [IsoXmlTag("ReqdMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RequestedMessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account to which the reporting request refers.
    /// </summary>
    [IsoId("_GPQVd249EeiU9cctagi5ow")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount38? Account { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_GPQVeW49EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required Party40Choice_ AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_GPQVe249EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    
    /// <summary>
    /// Specifies the requested reporting period.
    /// </summary>
    [IsoId("_GPQVfW49EeiU9cctagi5ow")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public ReportingPeriod2? ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Specifies the range of identification sequence numbers which are being requested.
    /// </summary>
    [IsoId("_GPQVf249EeiU9cctagi5ow")]
    [DisplayName("Reporting Sequence")]
    [IsoXmlTag("RptgSeq")]
    public SequenceRange1Choice_? ReportingSequence { get; init; } 
    
    /// <summary>
    /// Identifies the transactions to be reported.
    /// </summary>
    [IsoId("_GPQVgW49EeiU9cctagi5ow")]
    [DisplayName("Requested Transaction Type")]
    [IsoXmlTag("ReqdTxTp")]
    public TransactionType2? RequestedTransactionType { get; init; } 
    
    /// <summary>
    /// Provides details on the requested balance reporting.
    /// </summary>
    [IsoId("_GPQVg249EeiU9cctagi5ow")]
    [DisplayName("Requested Balance Type")]
    [IsoXmlTag("ReqdBalTp")]
    public BalanceType13? RequestedBalanceType { get; init; } 
    
    
    #nullable disable
    
}
