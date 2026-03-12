// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the amount, direction and parties involved in a payment obligation between two participants (and their netting group or trading party) of a netting service.
/// </summary>
[IsoId("_Chfq8QN1Ee2-vqzwMUAewg")]
[DisplayName("Net Obligation")]
public partial record NetObligation2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification for the obligation.
    /// </summary>
    [IsoId("_CnI_9QN1Ee2-vqzwMUAewg")]
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ObligationIdentification { get; init; } 
    
    /// <summary>
    /// Amount of the obligation.
    /// </summary>
    [IsoId("_CnI_9wN1Ee2-vqzwMUAewg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Describes the party or netting group (of the participant receiving the report) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("_CnI_-QN1Ee2-vqzwMUAewg")]
    [DisplayName("Participant Netting Identification")]
    [IsoXmlTag("PtcptNetgId")]
    public required NettingIdentification2Choice_ ParticipantNettingIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the direction of the obligation.
    /// </summary>
    [IsoId("_CnI_-wN1Ee2-vqzwMUAewg")]
    [DisplayName("Obligation Direction")]
    [IsoXmlTag("OblgtnDrctn")]
    public required PaymentReceipt1Code ObligationDirection { get; init; } 
    
    /// <summary>
    /// Describes the party or netting group (of the counterparty in the obligation) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("_CnI__QN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Netting Identification")]
    [IsoXmlTag("CtrPtyNetgId")]
    public required NettingIdentification2Choice_ CounterpartyNettingIdentification { get; init; } 
    
    /// <summary>
    /// Describes the counterparty participant involved in the obligation.
    /// </summary>
    [IsoId("_CnI__wN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Counterparty Identification")]
    [IsoXmlTag("NetSvcCtrPtyId")]
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the standard settlement instructions used to issue a payment to the counterparty in order to settle the obligation.
    /// </summary>
    [IsoId("_CnJAAQN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Settlement Instructions")]
    [IsoXmlTag("CtrPtySttlmInstrs")]
    public SettlementParties120? CounterpartySettlementInstructions { get; init; } 
    
    /// <summary>
    /// Number of transactions used to calculate the obligation. This is used in reconciliation between the net report obligation and the previously provided transaction status updates.
    /// </summary>
    [IsoId("_CnJAAwN1Ee2-vqzwMUAewg")]
    [DisplayName("Transactions Number")]
    [IsoXmlTag("TxsNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionsNumber { get; init; } 
    
    
    #nullable disable
    
}
