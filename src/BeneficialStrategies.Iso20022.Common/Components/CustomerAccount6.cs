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
[IsoId("_xSODMd_iEeWtWuYVXtphhA")]
[DisplayName("Customer Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerAccount6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerAccount6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerAccount6( string reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_xdp3Id_iEeWtWuYVXtphhA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? Identification { get; init; } 
    #else
    public AccountIdentification4Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_xdp3I9_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3Jd_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3J9_iEeWtWuYVXtphhA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountType2Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountType2Choice_? Type { get; init; } 
    #else
    public CashAccountType2Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_xdp3Kd_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3K9_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3Ld_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3L9_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3Md_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3M9_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3Nd_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3N9_iEeWtWuYVXtphhA")]
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
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_ivWkwd_kEeWtWuYVXtphhA")]
    [DisplayName("Statement Frequency And Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtFrqcyAndFrmt")]
    #endif
    [IsoXmlTag("StmtFrqcyAndFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; init; } 
    #else
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_xdp3O9_iEeWtWuYVXtphhA")]
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
    [IsoId("_xdp3Pd_iEeWtWuYVXtphhA")]
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
    
    /// <summary>
    /// Date when the account was opened.
    /// </summary>
    [IsoId("_xdp3P9_iEeWtWuYVXtphhA")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OpeningDate { get; init; } 
    #else
    public System.DateOnly? OpeningDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
