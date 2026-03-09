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
/// Provides information about the cash option.
/// </summary>
[IsoId("_3gCOec3xEee5nJBZsW8MFQ")]
[DisplayName("Cash Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOption62
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOption62 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOption62( CreditDebitCode reqCreditDebitIndicator,DateAndDateTime2Choice_ reqPostingDate,RestrictedFINActiveCurrencyAndAmount reqPostingAmount )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        PostingDate = reqPostingDate;
        PostingAmount = reqPostingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_3gCOe83xEee5nJBZsW8MFQ")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_3gCOg83xEee5nJBZsW8MFQ")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account9Choice_? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account9Choice_? Account { get; init; } 
    #else
    public Account9Choice_? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_3gCOi83xEee5nJBZsW8MFQ")]
    [DisplayName("Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngDt")]
    #endif
    [IsoXmlTag("PstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ PostingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTime2Choice_ PostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ PostingDate { get; init; } 
    #else
    public DateAndDateTime2Choice_ PostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_3gCOk83xEee5nJBZsW8MFQ")]
    [DisplayName("Original Posting Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPstngDt")]
    #endif
    [IsoXmlTag("OrgnlPstngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? OriginalPostingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? OriginalPostingDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? OriginalPostingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_3gCOlc3xEee5nJBZsW8MFQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_3gCOnc3xEee5nJBZsW8MFQ")]
    [DisplayName("Posting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngAmt")]
    #endif
    [IsoXmlTag("PstngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount PostingAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount PostingAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
