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
[IsoId("_bpDbAEI_EeinU6Cqu8f2Ow")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction100
{
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment, issued by the originator.
    /// </summary>
    [IsoId("_e3BusUJGEeinU6Cqu8f2Ow")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public required IsoUUIDv4Identifier UETR { get; init; } 
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_j1xVEUJQEeinU6Cqu8f2Ow")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required PaymentStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Specifies the time when the related status was reached.
    /// </summary>
    [IsoId("_prt0wUJQEeinU6Cqu8f2Ow")]
    [DisplayName("Event Time")]
    [IsoXmlTag("EvtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime EventTime { get; init; } 
    
    /// <summary>
    /// Specifies the party that issues the status.
    /// </summary>
    [IsoId("_sJJEAUJREeinU6Cqu8f2Ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Originator { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_V7WMIUJREeinU6Cqu8f2Ow")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    
    /// <summary>
    /// Specifies the actual amount that has been paid to the ultimate beneficiary, after all charges etc... have been deducted.
    /// </summary>
    [IsoId("_XKECAUJREeinU6Cqu8f2Ow")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    
    /// <summary>
    /// This groups the information of an event which is a payment message or status confirmation update. It is repeated as many times as there are events to be returned.
    /// </summary>
    [IsoId("__su_cUJREeinU6Cqu8f2Ow")]
    [DisplayName("Payment Event")]
    [IsoXmlTag("PmtEvt")]
    public ValueList<PaymentEvent6> PaymentEvent { get; init; } = new ValueList<PaymentEvent6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is __su_cUJREeinU6Cqu8f2Ow
    
    
    #nullable disable
    
}
