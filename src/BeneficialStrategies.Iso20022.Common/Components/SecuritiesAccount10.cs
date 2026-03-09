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
/// Provides information about the securities account.
/// </summary>
[IsoId("_QUJpF9p-Ed-ak6NoX_4Aeg_-1770262344")]
[DisplayName("Securities Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccount10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccount10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccount10( CreditDebitCode reqCreditDebitIndicator,System.String reqAccountIdentification )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_QUJpGNp-Ed-ak6NoX_4Aeg_-1509539821")]
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
    [IsoId("_QUJpGdp-Ed-ak6NoX_4Aeg_-1526450863")]
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
    /// Nationality of the account owner.
    /// </summary>
    [IsoId("_QUJpGtp-Ed-ak6NoX_4Aeg_933471459")]
    [DisplayName("Account Owner Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnrNtlty")]
    #endif
    [IsoXmlTag("AcctOwnrNtlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NationalityCode? AccountOwnerNationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AccountOwnerNationality { get; init; } 
    #else
    public string? AccountOwnerNationality { get; set; } 
    #endif
    
    /// <summary>
    /// Idenfitication of the account.
    /// </summary>
    [IsoId("_QUTaENp-Ed-ak6NoX_4Aeg_-1526450862")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountIdentification { get; init; } 
    #else
    public System.String AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of balance.
    /// </summary>
    [IsoId("_QUTaEdp-Ed-ak6NoX_4Aeg_-1526450832")]
    [DisplayName("Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTp")]
    #endif
    [IsoXmlTag("BalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesBalanceType9FormatChoice_? BalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType9FormatChoice_? BalanceType { get; init; } 
    #else
    public SecuritiesBalanceType9FormatChoice_? BalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    [IsoId("_QUTaEtp-Ed-ak6NoX_4Aeg_1158516377")]
    [DisplayName("Security Holding Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyHldgForm")]
    #endif
    [IsoXmlTag("SctyHldgForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? SecurityHoldingForm { get; init; } 
    #else
    public FormOfSecurity1Code? SecurityHoldingForm { get; set; } 
    #endif
    
    
    #nullable disable
    
}
