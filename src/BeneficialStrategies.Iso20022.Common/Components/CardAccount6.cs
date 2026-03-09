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
/// Customer account information.
/// </summary>
[IsoId("_QK4R0Yq5EeSIDtZ76p6McQ")]
[DisplayName("Card Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAccount6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_QW8X44q5EeSIDtZ76p6McQ")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType2Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType2Code? AccountType { get; init; } 
    #else
    public CardAccountType2Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_QW8X5Yq5EeSIDtZ76p6McQ")]
    [DisplayName("Account Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNm")]
    #endif
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AccountName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountName { get; init; } 
    #else
    public System.String? AccountName { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_QW8X54q5EeSIDtZ76p6McQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_QW8X6Yq5EeSIDtZ76p6McQ")]
    [DisplayName("Account Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctIdr")]
    #endif
    [IsoXmlTag("AcctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification31Choice_? AccountIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification31Choice_? AccountIdentifier { get; init; } 
    #else
    public AccountIdentification31Choice_? AccountIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_QW8X64q5EeSIDtZ76p6McQ")]
    [DisplayName("Credit Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtRef")]
    #endif
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditReference { get; init; } 
    #else
    public System.String? CreditReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_QW8X7Yq5EeSIDtZ76p6McQ")]
    [DisplayName("Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svcr")]
    #endif
    [IsoXmlTag("Svcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification72Choice_? Servicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification72Choice_? Servicer { get; init; } 
    #else
    public PartyIdentification72Choice_? Servicer { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_QW8X74q5EeSIDtZ76p6McQ")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection43? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection43? Balance { get; init; } 
    #else
    public AmountAndDirection43? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_thBFYIq5EeSIDtZ76p6McQ")]
    [DisplayName("Balance Display Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalDispFlg")]
    #endif
    [IsoXmlTag("BalDispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BalanceDisplayFlag { get; init; } 
    #else
    public System.String? BalanceDisplayFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    [IsoId("_6RE3gIq5EeSIDtZ76p6McQ")]
    [DisplayName("Default Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltAcctInd")]
    #endif
    [IsoXmlTag("DfltAcctInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DefaultAccountIndicator { get; init; } 
    #else
    public System.String? DefaultAccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Services allowed on the account.
    /// </summary>
    [IsoId("_kPxHAIq6EeSHjtO_wHA7PQ")]
    [DisplayName("Allowed Services")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdSvcs")]
    #endif
    [IsoXmlTag("AllwdSvcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMServiceType4Code? AllowedServices { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMServiceType4Code? AllowedServices { get; init; } 
    #else
    public ATMServiceType4Code? AllowedServices { get; set; } 
    #endif
    
    /// <summary>
    /// Withdrawal limits for the account.
    /// </summary>
    [IsoId("_2SK8gIq6EeSHjtO_wHA7PQ")]
    [DisplayName("Withdrawal Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WdrwlLmts")]
    #endif
    [IsoXmlTag("WdrwlLmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts4? WithdrawalLimits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts4? WithdrawalLimits { get; init; } 
    #else
    public ATMTransactionAmounts4? WithdrawalLimits { get; set; } 
    #endif
    
    /// <summary>
    /// Deposit limits for the account.
    /// </summary>
    [IsoId("_cl2S0Iq7EeSHjtO_wHA7PQ")]
    [DisplayName("Deposit Limits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DpstLmts")]
    #endif
    [IsoXmlTag("DpstLmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTransactionAmounts5? DepositLimits { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransactionAmounts5? DepositLimits { get; init; } 
    #else
    public ATMTransactionAmounts5? DepositLimits { get; set; } 
    #endif
    
    
    #nullable disable
    
}
