// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for an account.
/// </summary>
[IsoId("_zn-lF-FgEeWIA4E9cYSxxQ")]
[DisplayName("Collateral Value Search Criteria")]
public partial record CollateralValueSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_zw53k-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_zw53leFgEeWIA4E9cYSxxQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account being queried.
    /// </summary>
    [IsoId("_zw53l-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification71Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, which is being queried.
    /// </summary>
    [IsoId("_zw53meFgEeWIA4E9cYSxxQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification71Choice_? AccountServicer { get; init; } 
    
    /// <summary>
    /// ISIN identification of the related financial instrument into which this security can be converted.
    /// </summary>
    [IsoId("_zw53m-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    [IsoId("_zw53neFgEeWIA4E9cYSxxQ")]
    [DisplayName("Securities Account Owner")]
    [IsoXmlTag("SctiesAcctOwnr")]
    public PartyIdentification71Choice_? SecuritiesAccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    [IsoId("_zw53n-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Securities Account Servicer")]
    [IsoXmlTag("SctiesAcctSvcr")]
    public PartyIdentification71Choice_? SecuritiesAccountServicer { get; init; } 
    
    
    #nullable disable
    
}
