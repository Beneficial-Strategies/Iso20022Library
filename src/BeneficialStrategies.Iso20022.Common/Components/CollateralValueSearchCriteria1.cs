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
[IsoId("_jH3E4-5NEeCisYr99QEiWA_180324541")]
[DisplayName("Collateral Value Search Criteria")]
public partial record CollateralValueSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jH3E5O5NEeCisYr99QEiWA_-1182706230")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_jIA14O5NEeCisYr99QEiWA_-280346564")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account being queried.
    /// </summary>
    [IsoId("_A1zFAHglEeGqN5NokjUPnw_-1160234385")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification71Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, which is being queried.
    /// </summary>
    [IsoId("_A182AHglEeGqN5NokjUPnw_2137660558")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification71Choice_? AccountServicer { get; init; } 
    
    /// <summary>
    /// ISIN identification of the related financial instrument into which this security can be converted.
    /// </summary>
    [IsoId("_jIA14-5NEeCisYr99QEiWA_59295737")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    [IsoId("_A182AXglEeGqN5NokjUPnw_1683003597")]
    [DisplayName("Securities Account Owner")]
    [IsoXmlTag("SctiesAcctOwnr")]
    public PartyIdentification71Choice_? SecuritiesAccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    [IsoId("_A182AnglEeGqN5NokjUPnw_685931244")]
    [DisplayName("Securities Account Servicer")]
    [IsoXmlTag("SctiesAcctSvcr")]
    public PartyIdentification71Choice_? SecuritiesAccountServicer { get; init; } 
    
    
    #nullable disable
    
}
