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
/// Account owned by a customer.
/// </summary>
[IsoId("_SN5Y99p-Ed-ak6NoX_4Aeg_-1328700496")]
[DisplayName("Customer Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerAccount1( AccountIdentification4Choice_ reqIdentification,string reqCurrency )
    {
        Identification = reqIdentification;
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_SOCi4Np-Ed-ak6NoX_4Aeg_-366390676")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification4Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification4Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_ Identification { get; init; } 
    #else
    public AccountIdentification4Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_SOCi4dp-Ed-ak6NoX_4Aeg_920076371")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_SOCi4tp-Ed-ak6NoX_4Aeg_1282094215")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatus3Code? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatus3Code? Status { get; init; } 
    #else
    public AccountStatus3Code? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_SOCi49p-Ed-ak6NoX_4Aeg_-1326458544")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountType2? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountType2? Type { get; init; } 
    #else
    public CashAccountType2? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_SOCi5Np-Ed-ak6NoX_4Aeg_-208999236")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_SOCi5dp-Ed-ak6NoX_4Aeg_1019281789")]
    [DisplayName("Monthly Payment Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyPmtVal")]
    #endif
    [IsoXmlTag("MnthlyPmtVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MonthlyPaymentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_SOCi5tp-Ed-ak6NoX_4Aeg_2114328915")]
    [DisplayName("Monthly Received Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyRcvdVal")]
    #endif
    [IsoXmlTag("MnthlyRcvdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MonthlyReceivedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_SOCi59p-Ed-ak6NoX_4Aeg_1908632472")]
    [DisplayName("Monthly Transaction Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyTxNb")]
    #endif
    [IsoXmlTag("MnthlyTxNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? MonthlyTransactionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MonthlyTransactionNumber { get; init; } 
    #else
    public System.String? MonthlyTransactionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_SOCi6Np-Ed-ak6NoX_4Aeg_-161243707")]
    [DisplayName("Average Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgBal")]
    #endif
    [IsoXmlTag("AvrgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AverageBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AverageBalance { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AverageBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_SOCi6dp-Ed-ak6NoX_4Aeg_-508141557")]
    [DisplayName("Account Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPurp")]
    #endif
    [IsoXmlTag("AcctPurp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AccountPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountPurpose { get; init; } 
    #else
    public System.String? AccountPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_SOMT4Np-Ed-ak6NoX_4Aeg_-1030613327")]
    [DisplayName("Floor Notification Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlrNtfctnAmt")]
    #endif
    [IsoXmlTag("FlrNtfctnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FloorNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_SOMT4dp-Ed-ak6NoX_4Aeg_-317591359")]
    [DisplayName("Ceiling Notification Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClngNtfctnAmt")]
    #endif
    [IsoXmlTag("ClngNtfctnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CeilingNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent.
    /// </summary>
    [IsoId("_SOMT4tp-Ed-ak6NoX_4Aeg_-401791891")]
    [DisplayName("Statement Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtCycl")]
    #endif
    [IsoXmlTag("StmtCycl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency3Code? StatementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency3Code? StatementCycle { get; init; } 
    #else
    public Frequency3Code? StatementCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_SOMT49p-Ed-ak6NoX_4Aeg_-1192136833")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClosingDate { get; init; } 
    #else
    public System.DateOnly? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_SOMT5Np-Ed-ak6NoX_4Aeg_-693438831")]
    [DisplayName("Restriction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctn")]
    #endif
    [IsoXmlTag("Rstrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction1? Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction1? Restriction { get; init; } 
    #else
    public Restriction1? Restriction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
