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
/// Contains the details on the payment transaction.
/// </summary>
[IsoId("_CJrfK6HsEeagRbKvRt3LnA")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction97
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransaction97 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransaction97( System.String reqUETR,PaymentScenario3Code reqPaymentScenarioReturned,System.String reqMyInstitution,PaymentsPartyType2Code reqRole,System.DateTime reqEventTime,PaymentStatus5 reqTransactionStatus,System.DateTime reqInitiationTime,System.DateTime reqLastUpdateTime )
    {
        UETR = reqUETR;
        PaymentScenarioReturned = reqPaymentScenarioReturned;
        MyInstitution = reqMyInstitution;
        Role = reqRole;
        EventTime = reqEventTime;
        TransactionStatus = reqTransactionStatus;
        InitiationTime = reqInitiationTime;
        LastUpdateTime = reqLastUpdateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment.
    /// </summary>
    [IsoId("_-H68kaWeEeavY4aEtRQXnw")]
    [DisplayName("UETR")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UETR")]
    #endif
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoUUIDv4Identifier UETR { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UETR { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UETR { get; init; } 
    #else
    public System.String UETR { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which payment scenario is returned by the search.
    /// </summary>
    [IsoId("_MvpTsT5CEei1cqDe0mKAOg")]
    [DisplayName("Payment Scenario Returned")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtScnroRtrd")]
    #endif
    [IsoXmlTag("PmtScnroRtrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentScenario3Code PaymentScenarioReturned { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentScenario3Code PaymentScenarioReturned { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentScenario3Code PaymentScenarioReturned { get; init; } 
    #else
    public PaymentScenario3Code PaymentScenarioReturned { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies an institution that is owned by the sender, for which the sender can ask payment transaction details.
    /// </summary>
    [IsoId("_CITdUe4jEeaTc4E2tKngqg")]
    [DisplayName("My Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MyInstn")]
    #endif
    [IsoXmlTag("MyInstn")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier MyInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MyInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MyInstitution { get; init; } 
    #else
    public System.String MyInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the party in the payment chain.
    /// </summary>
    [IsoId("_2xsxce4iEeaTc4E2tKngqg")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentsPartyType2Code Role { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentsPartyType2Code Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentsPartyType2Code Role { get; init; } 
    #else
    public PaymentsPartyType2Code Role { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time determined by the Role that the entity defined in MyInstitution is playing in this transaction.
    /// </summary>
    [IsoId("_OMSMkO4jEeaTc4E2tKngqg")]
    [DisplayName("Event Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTm")]
    #endif
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime EventTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime EventTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime EventTime { get; init; } 
    #else
    public System.DateTime EventTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_CJsGNaHsEeagRbKvRt3LnA")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentStatus5 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentStatus5 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatus5 TransactionStatus { get; init; } 
    #else
    public PaymentStatus5 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the status of the cancellation of a payment transaction.
    /// </summary>
    [IsoId("_ENq2IT5DEei1cqDe0mKAOg")]
    [DisplayName("Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlSts")]
    #endif
    [IsoXmlTag("CxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionCancellationStatus3? CancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionCancellationStatus3? CancellationStatus { get; init; } 
    #else
    public PaymentTransactionCancellationStatus3? CancellationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the debtor. 
    /// Usage:
    /// Debtor Agent in this case only refers to FI to FI Customer Credit Transfers.
    /// </summary>
    [IsoId("_Wvbc4e4kEeaTc4E2tKngqg")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DebtorAgent { get; init; } 
    #else
    public System.String? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that owes an amount of money to the (ultimate) creditor.
    /// Usage:
    /// Debtor in this case only refers to Financial Institution Credit Transfer with cover.
    /// </summary>
    [IsoId("_0I9IcD5aEei1cqDe0mKAOg")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Debtor { get; init; } 
    #else
    public System.String? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the agent(s) currently participating in a transaction.
    /// </summary>
    [IsoId("_2D-m0bF8EeaMU5WacDgJBg")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentEvent2? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentEvent2? Agent { get; init; } 
    #else
    public PaymentEvent2? Agent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_CJsGNKHsEeagRbKvRt3LnA")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorAgent { get; init; } 
    #else
    public System.String? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party to which an amount of money is due.
    /// Usage:
    /// This role is only to be used in Financial Institution Credit Transfer with cover
    /// </summary>
    [IsoId("_2QJpAD5bEei1cqDe0mKAOg")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Creditor { get; init; } 
    #else
    public System.String? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time at which the message enters the Gpi system.
    /// </summary>
    [IsoId("_CJrfLaHsEeagRbKvRt3LnA")]
    [DisplayName("Initiation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitnTm")]
    #endif
    [IsoXmlTag("InitnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime InitiationTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime InitiationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime InitiationTime { get; init; } 
    #else
    public System.DateTime InitiationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the time at which the instructed bank reports that the transaction has been completed. 
    /// Usage:
    /// Date and time based on the creation date of the status confirmation containing a final status ACSC.
    /// </summary>
    [IsoId("_CJsGMKHsEeagRbKvRt3LnA")]
    [DisplayName("Completion Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnTm")]
    #endif
    [IsoXmlTag("CmpltnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CompletionTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CompletionTime { get; init; } 
    #else
    public System.DateTime? CompletionTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage:
    /// This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_CJrfLKHsEeagRbKvRt3LnA")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.
    /// </summary>
    [IsoId("_6XflcFyZEeewBcMu1EH_Gg")]
    [DisplayName("Confirmed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdAmt")]
    #endif
    [IsoXmlTag("ConfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the last date and time at which the status of this transaction was updated.
    /// </summary>
    [IsoId("_CJsGN6HsEeagRbKvRt3LnA")]
    [DisplayName("Last Update Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdTm")]
    #endif
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime LastUpdateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime LastUpdateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime LastUpdateTime { get; init; } 
    #else
    public System.DateTime LastUpdateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the payment events related to the underlying cover payment.
    /// </summary>
    [IsoId("_OveT0T76EeiJbZ2wCAV0-w")]
    [DisplayName("Cover Payment Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverPmtEvt")]
    #endif
    [IsoXmlTag("CoverPmtEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CoverPaymentEvent1? CoverPaymentEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CoverPaymentEvent1? CoverPaymentEvent { get; init; } 
    #else
    public CoverPaymentEvent1? CoverPaymentEvent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
