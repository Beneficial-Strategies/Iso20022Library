// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Account18.
/// </summary>
[IsoId("_C3Y9IZ-QEe-nbM0aSPcoiQ")]
[DisplayName("Card Account18")]
public partial record CardAccount18
{
    #nullable enable

    /// <summary>
    /// Account Identifier.
    /// </summary>
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public AccountIdentification80Choice_? AccountIdentifier { get; init; } 

    /// <summary>
    /// Account Name.
    /// </summary>
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    public IsoMax70Text? AccountName { get; init; } 

    /// <summary>
    /// Account Type.
    /// </summary>
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; } 

    /// <summary>
    /// Account Usage Code.
    /// </summary>
    [DisplayName("Account Usage Code")]
    [IsoXmlTag("AcctUsgCd")]
    public ATMAccountUsage1Code? AccountUsageCode { get; init; } 

    /// <summary>
    /// Allowed Service.
    /// </summary>
    [DisplayName("Allowed Service")]
    [IsoXmlTag("AllwdSvc")]
    public ValueList<ATMService29> AllowedService { get; init; } = [];

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<AmountAndDirection111> Balance { get; init; } = [];

    /// <summary>
    /// Balance Display Flag.
    /// </summary>
    [DisplayName("Balance Display Flag")]
    [IsoXmlTag("BalDispFlg")]
    public IsoTrueFalseIndicator? BalanceDisplayFlag { get; init; } 

    /// <summary>
    /// Credit Reference.
    /// </summary>
    [DisplayName("Credit Reference")]
    [IsoXmlTag("CdtRef")]
    public IsoMax35Text? CreditReference { get; init; } 

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 

    /// <summary>
    /// Default Account Indicator.
    /// </summary>
    [DisplayName("Default Account Indicator")]
    [IsoXmlTag("DfltAcctInd")]
    public IsoTrueFalseIndicator? DefaultAccountIndicator { get; init; } 

    /// <summary>
    /// Servicer.
    /// </summary>
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification177Choice_? Servicer { get; init; } 

    
    #nullable disable
    
}
