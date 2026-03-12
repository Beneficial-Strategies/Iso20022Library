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
[IsoId("_7NnNsJUuEeaYkf5FCqYMeA")]
[DisplayName("Net Obligation")]
public partial record NetObligation1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification for the obligation.
    /// </summary>
    [IsoId("_UmlBEJUvEeaYkf5FCqYMeA")]
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ObligationIdentification { get; init; } 
    
    /// <summary>
    /// Amount and currency of the obligation.
    /// </summary>
    [IsoId("_ZGoE0JUvEeaYkf5FCqYMeA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Describes the party or netting group (of the participant receiving the report) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("_CKbZYJUwEeaYkf5FCqYMeA")]
    [DisplayName("Participant Netting Identification")]
    [IsoXmlTag("PtcptNetgId")]
    public required NettingIdentification1Choice_ ParticipantNettingIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the direction of the obligation.
    /// </summary>
    [IsoId("_917B0JUwEeaYkf5FCqYMeA")]
    [DisplayName("Obligation Direction")]
    [IsoXmlTag("OblgtnDrctn")]
    public required PaymentReceipt1Code ObligationDirection { get; init; } 
    
    /// <summary>
    /// Describes the party or netting group (of the counterparty in the obligation) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("_aoexwJUyEeaYkf5FCqYMeA")]
    [DisplayName("Counterparty Netting Identification")]
    [IsoXmlTag("CtrPtyNetgId")]
    public required NettingIdentification1Choice_ CounterpartyNettingIdentification { get; init; } 
    
    /// <summary>
    /// Describes the counterparty participant involved in the obligation.
    /// </summary>
    [IsoId("_ADbwUJUzEeaYkf5FCqYMeA")]
    [DisplayName("Net Service Counterparty Identification")]
    [IsoXmlTag("NetSvcCtrPtyId")]
    public PartyIdentification73Choice_? NetServiceCounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the standard settlement instructions used to issue payment to the counterparty in order to settle the obligation.
    /// </summary>
    [IsoId("_puxmAJUzEeaYkf5FCqYMeA")]
    [DisplayName("Counterparty Settlement Instructions")]
    [IsoXmlTag("CtrPtySttlmInstrs")]
    public SettlementParties29? CounterpartySettlementInstructions { get; init; } 
    
    /// <summary>
    /// Number of transactions used to calculate the obligation. This is used in reconciliation between the net report obligation and the previously provided transaction status updates.
    /// </summary>
    [IsoId("_ivg4YJU0EeaYkf5FCqYMeA")]
    [DisplayName("Transactions Number")]
    [IsoXmlTag("TxsNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TransactionsNumber { get; init; } 
    
    
    #nullable disable
    
}
