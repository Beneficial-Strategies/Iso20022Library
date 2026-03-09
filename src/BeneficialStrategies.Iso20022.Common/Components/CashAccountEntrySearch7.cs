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
/// Defines the criteria used to search for a cash entry.
/// </summary>
[IsoId("_gZHGOdcZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account Entry Search")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccountEntrySearch7
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
    [IsoId("_gau21dcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; } 
    #else
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the entry amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_gau219cZEeqRFcf2R4bPBw")]
    [DisplayName("Entry Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryAmt")]
    #endif
    [IsoXmlTag("NtryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricAmountRange2Choice_? EntryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricAmountRange2Choice_? EntryAmount { get; init; } 
    #else
    public ActiveOrHistoricAmountRange2Choice_? EntryAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the entry amount.
    /// </summary>
    [IsoId("_gau22dcZEeqRFcf2R4bPBw")]
    [DisplayName("Entry Amount Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryAmtCcy")]
    #endif
    [IsoXmlTag("NtryAmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? EntryAmountCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? EntryAmountCurrency { get; init; } 
    #else
    public string? EntryAmountCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_gau229cZEeqRFcf2R4bPBw")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Status of an entry on the books of the account servicer.
    /// </summary>
    [IsoId("_gau23dcZEeqRFcf2R4bPBw")]
    [DisplayName("Entry Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtrySts")]
    #endif
    [IsoXmlTag("NtrySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EntryStatus1Code? EntryStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntryStatus1Code? EntryStatus { get; init; } 
    #else
    public EntryStatus1Code? EntryStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_gau239cZEeqRFcf2R4bPBw")]
    [DisplayName("Entry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryDt")]
    #endif
    [IsoXmlTag("NtryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch3Choice_? EntryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch3Choice_? EntryDate { get; init; } 
    #else
    public DateAndDateTimeSearch3Choice_? EntryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_gau24dcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? AccountOwner { get; init; } 
    #else
    public PartyIdentification135? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_gau249cZEeqRFcf2R4bPBw")]
    [DisplayName("Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSvcr")]
    #endif
    [IsoXmlTag("AcctSvcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
