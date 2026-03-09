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
[IsoId("_eYroYYp5EeS3NqNpgnMh2w")]
[DisplayName("Card Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardAccount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used by the cardholder and the terminal for the choice of the account.
    /// </summary>
    [IsoId("_ekmkgYp5EeS3NqNpgnMh2w")]
    [DisplayName("Selection Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SelctnMtd")]
    #endif
    [IsoXmlTag("SelctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountChoiceMethod1Code? SelectionMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountChoiceMethod1Code? SelectionMethod { get; init; } 
    #else
    public AccountChoiceMethod1Code? SelectionMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_ekmkg4p5EeS3NqNpgnMh2w")]
    [DisplayName("Selected Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SelctdAcctTp")]
    #endif
    [IsoXmlTag("SelctdAcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType2Code? SelectedAccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType2Code? SelectedAccountType { get; init; } 
    #else
    public CardAccountType2Code? SelectedAccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_ekmkhYp5EeS3NqNpgnMh2w")]
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
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_rK5gECq-EeWRf8RNsvC5fQ")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress3? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress3? AccountOwner { get; init; } 
    #else
    public NameAndAddress3? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_ekmkiYp5EeS3NqNpgnMh2w")]
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
    [IsoId("_ekmki4p5EeS3NqNpgnMh2w")]
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
    [IsoId("_zMf1kIp5EeS3NqNpgnMh2w")]
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
    [IsoId("_ekmkj4p5EeS3NqNpgnMh2w")]
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
    [IsoId("__a99kIp5EeS3NqNpgnMh2w")]
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
    [IsoId("_4dUYYCq-EeWRf8RNsvC5fQ")]
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
    [IsoId("_-A1EQCq-EeWRf8RNsvC5fQ")]
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
    
    
    #nullable disable
    
}
