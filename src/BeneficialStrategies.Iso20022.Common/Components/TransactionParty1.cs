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
/// Set of elements providing information specific to the individual transaction(s) included in the message.
/// </summary>
[IsoId("_PyUuZNp-Ed-ak6NoX_4Aeg_482028635")]
[DisplayName("Transaction Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionParty1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party initiating the payment to an agent. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or a party that initiates the payment on behalf of the debtor or creditor. In the context of treasury, the party that instructs the trading party to execute a treasury deal on its behalf.
    /// </summary>
    [IsoId("_PyUuZdp-Ed-ak6NoX_4Aeg_482951151")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? InitiatingParty { get; init; } 
    #else
    public PartyIdentification8? InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PyUuZtp-Ed-ak6NoX_4Aeg_1473373314")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? Debtor { get; init; } 
    #else
    public PartyIdentification8? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor.
    /// </summary>
    [IsoId("_PyUuZ9p-Ed-ak6NoX_4Aeg_1473373384")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? DebtorAccount { get; init; } 
    #else
    public CashAccount7? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_PyUuaNp-Ed-ak6NoX_4Aeg_482951211")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification8? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_PyefYNp-Ed-ak6NoX_4Aeg_1788291282")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? Creditor { get; init; } 
    #else
    public PartyIdentification8? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor of the payment transaction.
    /// </summary>
    [IsoId("_PyefYdp-Ed-ak6NoX_4Aeg_1788291222")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? CreditorAccount { get; init; } 
    #else
    public CashAccount7? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_PyefYtp-Ed-ak6NoX_4Aeg_482949272")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification8? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that plays an active role in planning and executing the transactions that create or liquidate investments of the investors assets, or that move the investor&apos;s assets from one investment to another. A trading party is a trade instructor, an investment decision-maker, a post trade administrator, or a trader. In the context of treasury, it is the party that negotiates and executes the treasury transaction.
    /// </summary>
    [IsoId("_PyefY9p-Ed-ak6NoX_4Aeg_1518216858")]
    [DisplayName("Trading Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPty")]
    #endif
    [IsoXmlTag("TradgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? TradingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? TradingParty { get; init; } 
    #else
    public PartyIdentification8? TradingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Provides proprietary party information.
    /// </summary>
    [IsoId("_PyefZNp-Ed-ak6NoX_4Aeg_2019612158")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryParty1? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryParty1? Proprietary { get; init; } 
    #else
    public ProprietaryParty1? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
