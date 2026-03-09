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
/// Defines the criteria used to search for an account.
/// </summary>
[IsoId("_jH3E4-5NEeCisYr99QEiWA_180324541")]
[DisplayName("Collateral Value Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralValueSearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_jH3E5O5NEeCisYr99QEiWA_-1182706230")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentification4Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_jIA14O5NEeCisYr99QEiWA_-280346564")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account being queried.
    /// </summary>
    [IsoId("_A1zFAHglEeGqN5NokjUPnw_-1160234385")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification71Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, which is being queried.
    /// </summary>
    [IsoId("_A182AHglEeGqN5NokjUPnw_2137660558")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? AccountServicer { get; init; } 
    #else
    public PartyIdentification71Choice_? AccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// ISIN identification of the related financial instrument into which this security can be converted.
    /// </summary>
    [IsoId("_jIA14-5NEeCisYr99QEiWA_59295737")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    [IsoId("_A182AXglEeGqN5NokjUPnw_1683003597")]
    [DisplayName("Securities Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctOwnr")]
    #endif
    [IsoXmlTag("SctiesAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? SecuritiesAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? SecuritiesAccountOwner { get; init; } 
    #else
    public PartyIdentification71Choice_? SecuritiesAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    [IsoId("_A182AnglEeGqN5NokjUPnw_685931244")]
    [DisplayName("Securities Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctSvcr")]
    #endif
    [IsoXmlTag("SctiesAcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? SecuritiesAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? SecuritiesAccountServicer { get; init; } 
    #else
    public PartyIdentification71Choice_? SecuritiesAccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
