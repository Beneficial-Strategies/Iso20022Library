// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details on the payment transaction.
/// </summary>
[IsoId("_CJrfK6HsEeagRbKvRt3LnA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction97
{
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment.
    /// </summary>
    [IsoId("_-H68kaWeEeavY4aEtRQXnw")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public required IsoUUIDv4Identifier UETR { get; init; } 
    
    /// <summary>
    /// Specifies which payment scenario is returned by the search.
    /// </summary>
    [IsoId("_MvpTsT5CEei1cqDe0mKAOg")]
    [DisplayName("Payment Scenario Returned")]
    [IsoXmlTag("PmtScnroRtrd")]
    public required PaymentScenario3Code PaymentScenarioReturned { get; init; } 
    
    /// <summary>
    /// Identifies an institution that is owned by the sender, for which the sender can ask payment transaction details.
    /// </summary>
    [IsoId("_CITdUe4jEeaTc4E2tKngqg")]
    [DisplayName("My Institution")]
    [IsoXmlTag("MyInstn")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier MyInstitution { get; init; } 
    
    /// <summary>
    /// Specifies the role of the party in the payment chain.
    /// </summary>
    [IsoId("_2xsxce4iEeaTc4E2tKngqg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required PaymentsPartyType2Code Role { get; init; } 
    
    /// <summary>
    /// Specifies the time determined by the Role that the entity defined in MyInstitution is playing in this transaction.
    /// </summary>
    [IsoId("_OMSMkO4jEeaTc4E2tKngqg")]
    [DisplayName("Event Time")]
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTime { get; init; } 
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_CJsGNaHsEeagRbKvRt3LnA")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required PaymentStatus5 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Provides details on the status of the cancellation of a payment transaction.
    /// </summary>
    [IsoId("_ENq2IT5DEei1cqDe0mKAOg")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public PaymentTransactionCancellationStatus3? CancellationStatus { get; init; } 
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the debtor. 
    /// Usage:
    /// Debtor Agent in this case only refers to FI to FI Customer Credit Transfers.
    /// </summary>
    [IsoId("_Wvbc4e4kEeaTc4E2tKngqg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? DebtorAgent { get; init; } 
    
    /// <summary>
    /// Identifies the party that owes an amount of money to the (ultimate) creditor.
    /// Usage:
    /// Debtor in this case only refers to Financial Institution Credit Transfer with cover.
    /// </summary>
    [IsoId("_0I9IcD5aEei1cqDe0mKAOg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Debtor { get; init; } 
    
    /// <summary>
    /// Identifies the agent(s) currently participating in a transaction.
    /// </summary>
    [IsoId("_2D-m0bF8EeaMU5WacDgJBg")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public PaymentEvent2? Agent { get; init; } 
    
    /// <summary>
    /// Identifies the financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_CJsGNKHsEeagRbKvRt3LnA")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? CreditorAgent { get; init; } 
    
    /// <summary>
    /// Identifies the party to which an amount of money is due.
    /// Usage:
    /// This role is only to be used in Financial Institution Credit Transfer with cover
    /// </summary>
    [IsoId("_2QJpAD5bEei1cqDe0mKAOg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Creditor { get; init; } 
    
    /// <summary>
    /// Indicates the date and time at which the message enters the Gpi system.
    /// </summary>
    [IsoId("_CJrfLaHsEeagRbKvRt3LnA")]
    [DisplayName("Initiation Time")]
    [IsoXmlTag("InitnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime InitiationTime { get; init; } 
    
    /// <summary>
    /// Contains the time at which the instructed bank reports that the transaction has been completed. 
    /// Usage:
    /// Date and time based on the creation date of the status confirmation containing a final status ACSC.
    /// </summary>
    [IsoId("_CJsGMKHsEeagRbKvRt3LnA")]
    [DisplayName("Completion Time")]
    [IsoXmlTag("CmpltnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CompletionTime { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage:
    /// This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_CJrfLKHsEeagRbKvRt3LnA")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    
    /// <summary>
    /// Specifies the actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.
    /// </summary>
    [IsoId("_6XflcFyZEeewBcMu1EH_Gg")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Specifies the last date and time at which the status of this transaction was updated.
    /// </summary>
    [IsoId("_CJsGN6HsEeagRbKvRt3LnA")]
    [DisplayName("Last Update Time")]
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LastUpdateTime { get; init; } 
    
    /// <summary>
    /// Specifies the payment events related to the underlying cover payment.
    /// </summary>
    [IsoId("_OveT0T76EeiJbZ2wCAV0-w")]
    [DisplayName("Cover Payment Event")]
    [IsoXmlTag("CoverPmtEvt")]
    public CoverPaymentEvent1? CoverPaymentEvent { get; init; } 
    
    
    #nullable disable
    
}
