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
[IsoId("_r8lEoQ4oEeK3IMoVvcTkkg")]
[DisplayName("Customer Account Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerAccountModification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerAccountModification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerAccountModification1( string reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_sRvcVQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    public ValueList<AccountIdentification4Choice_> Identification { get; init; } = new ValueList<AccountIdentification4Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _sRvcVQ4oEeK3IMoVvcTkkg
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_sRvcXA4oEeK3IMoVvcTkkg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameModification1? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameModification1? Name { get; init; } 
    #else
    public NameModification1? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_sRvcYw4oEeK3IMoVvcTkkg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatusModification1? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatusModification1? Status { get; init; } 
    #else
    public AccountStatusModification1? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_sRvcag4oEeK3IMoVvcTkkg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeModification1? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeModification1? Type { get; init; } 
    #else
    public TypeModification1? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_sRvccQ4oEeK3IMoVvcTkkg")]
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
    [IsoId("_sRvceA4oEeK3IMoVvcTkkg")]
    [DisplayName("Monthly Payment Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyPmtVal")]
    #endif
    [IsoXmlTag("MnthlyPmtVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountModification1? MonthlyPaymentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountModification1? MonthlyPaymentValue { get; init; } 
    #else
    public AmountModification1? MonthlyPaymentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_sRvcfw4oEeK3IMoVvcTkkg")]
    [DisplayName("Monthly Received Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyRcvdVal")]
    #endif
    [IsoXmlTag("MnthlyRcvdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountModification1? MonthlyReceivedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountModification1? MonthlyReceivedValue { get; init; } 
    #else
    public AmountModification1? MonthlyReceivedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_sRvchg4oEeK3IMoVvcTkkg")]
    [DisplayName("Monthly Transaction Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnthlyTxNb")]
    #endif
    [IsoXmlTag("MnthlyTxNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberModification1? MonthlyTransactionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberModification1? MonthlyTransactionNumber { get; init; } 
    #else
    public NumberModification1? MonthlyTransactionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_sRvcjQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Average Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgBal")]
    #endif
    [IsoXmlTag("AvrgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountModification1? AverageBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountModification1? AverageBalance { get; init; } 
    #else
    public AmountModification1? AverageBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_sRvclA4oEeK3IMoVvcTkkg")]
    [DisplayName("Account Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctPurp")]
    #endif
    [IsoXmlTag("AcctPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PurposeModification1? AccountPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PurposeModification1? AccountPurpose { get; init; } 
    #else
    public PurposeModification1? AccountPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_sRvcmw4oEeK3IMoVvcTkkg")]
    [DisplayName("Floor Notification Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FlrNtfctnAmt")]
    #endif
    [IsoXmlTag("FlrNtfctnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountModification1? FloorNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountModification1? FloorNotificationAmount { get; init; } 
    #else
    public AmountModification1? FloorNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_sRvcog4oEeK3IMoVvcTkkg")]
    [DisplayName("Ceiling Notification Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClngNtfctnAmt")]
    #endif
    [IsoXmlTag("ClngNtfctnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountModification1? CeilingNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountModification1? CeilingNotificationAmount { get; init; } 
    #else
    public AmountModification1? CeilingNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_sRvcqQ4oEeK3IMoVvcTkkg")]
    [DisplayName("Statement Frequency And Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtFrqcyAndFrmt")]
    #endif
    [IsoXmlTag("StmtFrqcyAndFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementFrequencyAndFormModification1? StatementFrequencyAndFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyAndFormModification1? StatementFrequencyAndFormat { get; init; } 
    #else
    public StatementFrequencyAndFormModification1? StatementFrequencyAndFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_sRvcsA4oEeK3IMoVvcTkkg")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateModification1? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateModification1? ClosingDate { get; init; } 
    #else
    public DateModification1? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_sRvctw4oEeK3IMoVvcTkkg")]
    [DisplayName("Restriction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctn")]
    #endif
    [IsoXmlTag("Rstrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictionModification1? Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictionModification1? Restriction { get; init; } 
    #else
    public RestrictionModification1? Restriction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
