// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer account information.
/// </summary>
[IsoId("_eW6GEa4ZEeW_TaP-ygI0SQ")]
[DisplayName("Card Account")]
public partial record CardAccount12
{
    #nullable enable
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_ehflca4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; } 
    
    /// <summary>
    /// Name of the account, as assigned by the account servicing institution, in agreement with the account owner in order to provide an additional means of identification of the account.
    /// Usage: The account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_ehflc64ZEeW_TaP-ygI0SQ")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AccountName { get; init; } 
    
    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_ehflda4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Unique identifier of the account, as assigned by the account servicer.
    /// </summary>
    [IsoId("_ehfld64ZEeW_TaP-ygI0SQ")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification31Choice_? AccountIdentifier { get; init; } 
    
    /// <summary>
    /// Internal account reference in case of credit account.
    /// </summary>
    [IsoId("_ehflea4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CreditReference { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_ehfle64ZEeW_TaP-ygI0SQ")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification72Choice_? Servicer { get; init; } 
    
    /// <summary>
    /// Balance of the account.
    /// </summary>
    [IsoId("_ehflfa4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection43? Balance { get; init; } 
    
    /// <summary>
    /// Indicates if the balance must be displayed to the customer on the ATM.
    /// </summary>
    [IsoId("_ehflf64ZEeW_TaP-ygI0SQ")]
    [DisplayName("Balance Display Flag")]
    [IsoXmlTag("BalDispFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; } 
    
    /// <summary>
    /// Indicates if this is the default account.
    /// </summary>
    [IsoId("_ehflga4ZEeW_TaP-ygI0SQ")]
    [DisplayName("Default Account Indicator")]
    [IsoXmlTag("DfltAcctInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; } 
    
    /// <summary>
    /// Service allowed on the account.
    /// </summary>
    [IsoId("_ehflg64ZEeW_TaP-ygI0SQ")]
    [DisplayName("Allowed Service")]
    [IsoXmlTag("AllwdSvc")]
    public ATMService19? AllowedService { get; init; } 
    
    
    #nullable disable
    
}
