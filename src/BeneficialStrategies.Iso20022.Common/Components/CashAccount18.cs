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
/// Provides information about the cash account.
/// </summary>
[IsoId("_SQINmNp-Ed-ak6NoX_4Aeg_-1249584584")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccount18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccount18( CreditDebitCode reqCreditDebitIndicator,AccountIdentification2Choice_ reqAccountIdentification )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_SQR-kNp-Ed-ak6NoX_4Aeg_-965587415")]
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
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_SQR-kdp-Ed-ak6NoX_4Aeg_-1212642935")]
    [DisplayName("Account Owner Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrId")]
    #endif
    [IsoXmlTag("AcctOwnrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cash account or the securities account from which the cash account is derived.
    /// </summary>
    [IsoId("_SQR-ktp-Ed-ak6NoX_4Aeg_-1212642934")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification2Choice_ AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification2Choice_ AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification2Choice_ AccountIdentification { get; init; } 
    #else
    public AccountIdentification2Choice_ AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// The cash balance type.
    /// </summary>
    [IsoId("_SQR-k9p-Ed-ak6NoX_4Aeg_-1823469392")]
    [DisplayName("Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTp")]
    #endif
    [IsoXmlTag("BalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalanceType1FormatType? BalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalanceType1FormatType? BalanceType { get; init; } 
    #else
    public CashBalanceType1FormatType? BalanceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
