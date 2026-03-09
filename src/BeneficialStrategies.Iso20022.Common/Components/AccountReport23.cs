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
/// Reports to a corporate on the actual set-up of the account, related services and mandates.
/// </summary>
[IsoId("_IlAr9W49EeiU9cctagi5ow")]
[DisplayName("Account Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountReport23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountReport23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountReport23( CustomerAccount5 reqAccount )
    {
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics of the account.
    /// </summary>
    [IsoId("_IuZ4dW49EeiU9cctagi5ow")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustomerAccount5 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CustomerAccount5 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerAccount5 Account { get; init; } 
    #else
    public CustomerAccount5 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_IuZ4d249EeiU9cctagi5ow")]
    [DisplayName("Underlying Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygMstrAgrmt")]
    #endif
    [IsoXmlTag("UndrlygMstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContractDocument1? UnderlyingMasterAgreement { get; init; } 
    #else
    public ContractDocument1? UnderlyingMasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies target and actual dates.
    /// </summary>
    [IsoId("_IuZ4eW49EeiU9cctagi5ow")]
    [DisplayName("Contract Dates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDts")]
    #endif
    [IsoXmlTag("CtrctDts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountContract3? ContractDates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountContract3? ContractDates { get; init; } 
    #else
    public AccountContract3? ContractDates { get; set; } 
    #endif
    
    /// <summary>
    /// Information specifying the account mandate.
    /// </summary>
    [IsoId("_IuZ4e249EeiU9cctagi5ow")]
    [DisplayName("Mandate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mndt")]
    #endif
    [IsoXmlTag("Mndt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OperationMandate4? Mandate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OperationMandate4? Mandate { get; init; } 
    #else
    public OperationMandate4? Mandate { get; set; } 
    #endif
    
    /// <summary>
    /// Definition of a group of parties.
    /// </summary>
    [IsoId("_IuZ4fW49EeiU9cctagi5ow")]
    [DisplayName("Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grp")]
    #endif
    [IsoXmlTag("Grp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Group4? Group { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Group4? Group { get; init; } 
    #else
    public Group4? Group { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account used as a reference for the opening of another account.
    /// </summary>
    [IsoId("_IuZ4f249EeiU9cctagi5ow")]
    [DisplayName("Reference Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefAcct")]
    #endif
    [IsoXmlTag("RefAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? ReferenceAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? ReferenceAccount { get; init; } 
    #else
    public CashAccount38? ReferenceAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the account where to transfer the balance.
    /// </summary>
    [IsoId("_IuZ4gW49EeiU9cctagi5ow")]
    [DisplayName("Balance Transfer Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTrfAcct")]
    #endif
    [IsoXmlTag("BalTrfAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountForAction1? BalanceTransferAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountForAction1? BalanceTransferAccount { get; init; } 
    #else
    public AccountForAction1? BalanceTransferAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transfer account servicer.
    /// </summary>
    [IsoId("_IuZ4g249EeiU9cctagi5ow")]
    [DisplayName("Transfer Account Servicer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfAcctSvcrId")]
    #endif
    [IsoXmlTag("TrfAcctSvcrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? TransferAccountServicerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? TransferAccountServicerIdentification { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? TransferAccountServicerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
