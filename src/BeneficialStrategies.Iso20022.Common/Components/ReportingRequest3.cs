// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reporting request.
/// </summary>
[IsoId("_tmkLxFkyEeGeoaLUQk__nA_-763760907")]
[DisplayName("Reporting Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportingRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportingRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportingRequest3( System.String reqRequestedMessageNameIdentification,Party12Choice_ reqAccountOwner )
    {
        RequestedMessageNameIdentification = reqRequestedMessageNameIdentification;
        AccountOwner = reqAccountOwner;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the account reporting request.
    /// </summary>
    [IsoId("_tmt8wFkyEeGeoaLUQk__nA_-1760833260")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the requested reporting message.
    /// </summary>
    [IsoId("_tmt8wVkyEeGeoaLUQk__nA_-1195376634")]
    [DisplayName("Requested Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdMsgNmId")]
    #endif
    [IsoXmlTag("ReqdMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RequestedMessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestedMessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestedMessageNameIdentification { get; init; } 
    #else
    public System.String RequestedMessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account to which the reporting request refers.
    /// </summary>
    [IsoId("_tmt8wlkyEeGeoaLUQk__nA_927327284")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? Account { get; init; } 
    #else
    public CashAccount24? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_tmt8w1kyEeGeoaLUQk__nA_1089633804")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party12Choice_ AccountOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party12Choice_ AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party12Choice_ AccountOwner { get; init; } 
    #else
    public Party12Choice_ AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_tm3twFkyEeGeoaLUQk__nA_1850398957")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the requested reporting period.
    /// </summary>
    [IsoId("_tm3twVkyEeGeoaLUQk__nA_1839300180")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReportingPeriod1? ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingPeriod1? ReportingPeriod { get; init; } 
    #else
    public ReportingPeriod1? ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transactions to be reported.
    /// </summary>
    [IsoId("_tm3twlkyEeGeoaLUQk__nA_282932778")]
    [DisplayName("Requested Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTxTp")]
    #endif
    [IsoXmlTag("ReqdTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionType1? RequestedTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionType1? RequestedTransactionType { get; init; } 
    #else
    public TransactionType1? RequestedTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the requested balance reporting.
    /// </summary>
    [IsoId("_tm3tw1kyEeGeoaLUQk__nA_-1224719927")]
    [DisplayName("Requested Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdBalTp")]
    #endif
    [IsoXmlTag("ReqdBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BalanceType12? RequestedBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType12? RequestedBalanceType { get; init; } 
    #else
    public BalanceType12? RequestedBalanceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
