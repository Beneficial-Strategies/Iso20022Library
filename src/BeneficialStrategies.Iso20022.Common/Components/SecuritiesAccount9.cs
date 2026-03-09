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
[IsoId("_QUwGAtp-Ed-ak6NoX_4Aeg_591777960")]
[DisplayName("Securities Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccount9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccount9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccount9( CreditDebitCode reqCreditDebitIndicator,System.String reqAccountIdentification )
    {
        CreditDebitIndicator = reqCreditDebitIndicator;
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_QUwGA9p-Ed-ak6NoX_4Aeg_-1405183503")]
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
    [IsoId("_QUwGBNp-Ed-ak6NoX_4Aeg_617635713")]
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
    /// Idenfitication of the account.
    /// </summary>
    [IsoId("_QUwGBdp-Ed-ak6NoX_4Aeg_617635743")]
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
    [IsoId("_QUwGBtp-Ed-ak6NoX_4Aeg_617635744")]
    [DisplayName("Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalTp")]
    #endif
    [IsoXmlTag("BalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesBalanceType10FormatChoice_? BalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType10FormatChoice_? BalanceType { get; init; } 
    #else
    public SecuritiesBalanceType10FormatChoice_? BalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_QUwGB9p-Ed-ak6NoX_4Aeg_-34603986")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_QUwGCNp-Ed-ak6NoX_4Aeg_-34603677")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the form of the financial instrument.
    /// </summary>
    [IsoId("_QUwGCdp-Ed-ak6NoX_4Aeg_537320662")]
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
