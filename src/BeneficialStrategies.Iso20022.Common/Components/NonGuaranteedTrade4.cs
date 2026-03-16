// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Non Guaranteed Trade4.
/// </summary>
[IsoId("_eVSbC5IOEe-HRNGM304Vlw")]
[DisplayName("Non Guaranteed Trade4")]
public partial record NonGuaranteedTrade4
{
    #nullable enable

    /// <summary>
    /// Delivering Parties.
    /// </summary>
    [DisplayName("Delivering Parties")]
    [IsoXmlTag("DlvrgPties")]
    public DeliveringPartiesAndAccount22? DeliveringParties { get; init; } 

    /// <summary>
    /// Receiving Parties.
    /// </summary>
    [DisplayName("Receiving Parties")]
    [IsoXmlTag("RcvgPties")]
    public ReceivingPartiesAndAccount22? ReceivingParties { get; init; } 

    /// <summary>
    /// Trade Counterparty Clearing Member Identification.
    /// </summary>
    [DisplayName("Trade Counterparty Clearing Member Identification")]
    [IsoXmlTag("TradCtrPtyClrMmbId")]
    public required PartyIdentification253Choice_ TradeCounterpartyClearingMemberIdentification { get; init; } 

    /// <summary>
    /// Trade Counterparty Member Identification.
    /// </summary>
    [DisplayName("Trade Counterparty Member Identification")]
    [IsoXmlTag("TradCtrPtyMmbId")]
    public required PartyIdentification253Choice_ TradeCounterpartyMemberIdentification { get; init; } 

    
    #nullable disable
    
}
