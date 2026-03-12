// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key elements used to identify the original transaction(s) that is being referred to.
/// </summary>
[IsoId("_XaBDNfWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Payment Transaction")]
public partial record TrackerPaymentTransaction3
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_XaBDN_WfEemtd4wHZYvFUQ")]
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; init; } 
    
    /// <summary>
    /// Party that provides information on the status and related details of a transaction.
    /// </summary>
    [IsoId("_XaBqMfWfEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public required TrackerPartyIdentification1 TrackerInformingParty { get; init; } 
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_XaBqNfWfEemtd4wHZYvFUQ")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification11 PaymentIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_XaBqOfWfEemtd4wHZYvFUQ")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction10? SettlementInformation { get; init; } 
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_XaBqPfWfEemtd4wHZYvFUQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public TrackerFinancialInstitutionIdentification1? InstructedAgent { get; init; } 
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_XaBqP_WfEemtd4wHZYvFUQ")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public RestrictedFINActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    
    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_XaBqT_WfEemtd4wHZYvFUQ")]
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange16? ExchangeRateData { get; init; } 
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_XaBqUfWfEemtd4wHZYvFUQ")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType4Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    [IsoId("_XaBqU_WfEemtd4wHZYvFUQ")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public TrackerCharges1? ChargesInformation { get; init; } 
    
    /// <summary>
    /// Provides information on the tracking of the interbank transaction related to the payment.
    /// </summary>
    [IsoId("_XaBqVfWfEemtd4wHZYvFUQ")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    public TrackerData3? TrackerData { get; init; } 
    
    
    #nullable disable
    
}
