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
[IsoId("_SQINk9p-Ed-ak6NoX_4Aeg_-1116675143")]
[DisplayName("Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAccount17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAccount17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAccount17( CashAccountIdentification1Choice_ reqAccountIdentification,string reqPaymentCurrency,System.String reqCorrespondentBankIdentification )
    {
        AccountIdentification = reqAccountIdentification;
        PaymentCurrency = reqPaymentCurrency;
        CorrespondentBankIdentification = reqCorrespondentBankIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the cash account.
    /// </summary>
    [IsoId("_SQINlNp-Ed-ak6NoX_4Aeg_-521005462")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccountIdentification1Choice_ AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccountIdentification1Choice_ AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification1Choice_ AccountIdentification { get; init; } 
    #else
    public CashAccountIdentification1Choice_ AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the payment.
    /// </summary>
    [IsoId("_SQINldp-Ed-ak6NoX_4Aeg_1500837063")]
    [DisplayName("Payment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCcy")]
    #endif
    [IsoXmlTag("PmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode PaymentCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string PaymentCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string PaymentCurrency { get; init; } 
    #else
    public string PaymentCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_SQINltp-Ed-ak6NoX_4Aeg_781895629")]
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
    /// Identification of the cash correspondent back.
    /// </summary>
    [IsoId("_SQINl9p-Ed-ak6NoX_4Aeg_-1046488323")]
    [DisplayName("Correspondent Bank Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrspdtBkId")]
    #endif
    [IsoXmlTag("CrspdtBkId")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBICIdentifier CorrespondentBankIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CorrespondentBankIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CorrespondentBankIdentification { get; init; } 
    #else
    public System.String CorrespondentBankIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
