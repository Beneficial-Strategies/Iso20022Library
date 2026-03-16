// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net Obligation3.
/// </summary>
[IsoId("_UnyvQUkCEe-KhcStGV4xTg")]
[DisplayName("Net Obligation3")]
public partial record NetObligation3
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Counterparty Netting Identification.
    /// </summary>
    [DisplayName("Counterparty Netting Identification")]
    [IsoXmlTag("CtrPtyNetgId")]
    public required NettingIdentification2Choice_ CounterpartyNettingIdentification { get; init; } 

    /// <summary>
    /// Counterparty Settlement Instructions.
    /// </summary>
    [DisplayName("Counterparty Settlement Instructions")]
    [IsoXmlTag("CtrPtySttlmInstrs")]
    public SettlementParties120? CounterpartySettlementInstructions { get; init; } 

    /// <summary>
    /// Net Service Counterparty Identification.
    /// </summary>
    [DisplayName("Net Service Counterparty Identification")]
    [IsoXmlTag("NetSvcCtrPtyId")]
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 

    /// <summary>
    /// Obligation Direction.
    /// </summary>
    [DisplayName("Obligation Direction")]
    [IsoXmlTag("OblgtnDrctn")]
    public required PaymentReceipt1Code ObligationDirection { get; init; } 

    /// <summary>
    /// Obligation Identification.
    /// </summary>
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    public required IsoMax35Text ObligationIdentification { get; init; } 

    /// <summary>
    /// Participant Netting Identification.
    /// </summary>
    [DisplayName("Participant Netting Identification")]
    [IsoXmlTag("PtcptNetgId")]
    public required NettingIdentification2Choice_ ParticipantNettingIdentification { get; init; } 

    /// <summary>
    /// Payment Clearing Centre.
    /// </summary>
    [DisplayName("Payment Clearing Centre")]
    [IsoXmlTag("PmtClrCentr")]
    public CountryCode? PaymentClearingCentre { get; init; } 

    /// <summary>
    /// Transactions Number.
    /// </summary>
    [DisplayName("Transactions Number")]
    [IsoXmlTag("TxsNb")]
    public IsoMax10NumericText? TransactionsNumber { get; init; } 

    
    #nullable disable
    
}
