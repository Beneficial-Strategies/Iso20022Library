// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the non guaranteed trade details.
/// </summary>
[IsoId("_C9INcWpUEeSgo9vJrfSF_Q")]
[DisplayName("Non Guaranteed Trade")]
public partial record NonGuaranteedTrade3
{
    #nullable enable
    
    /// <summary>
    /// External identification of the member who is the market counterpart member of the current trade leg (in case of non guarantee trades, this field allows buyer and seller to identify each other).
    /// </summary>
    [IsoId("_DallgWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Trade Counterparty Member Identification")]
    [IsoXmlTag("TradCtrPtyMmbId")]
    public required PartyIdentification35Choice_ TradeCounterpartyMemberIdentification { get; init; } 
    
    /// <summary>
    /// External identification of the clearing member of the market couterpart member (in case of non guarantee trades, this field allows buyer and seller to identify each other).
    /// </summary>
    [IsoId("_Dallg2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Trade Counterparty Clearing Member Identification")]
    [IsoXmlTag("TradCtrPtyClrMmbId")]
    public required PartyIdentification35Choice_ TradeCounterpartyClearingMemberIdentification { get; init; } 
    
    /// <summary>
    /// Provides details about the delivering parties involved in the settlement chain.
    /// </summary>
    [IsoId("_DallhWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Delivering Parties")]
    [IsoXmlTag("DlvrgPties")]
    public DeliveringPartiesAndAccount11? DeliveringParties { get; init; } 
    
    /// <summary>
    /// Provides details about the receiving parties involved in the settlement chain.
    /// </summary>
    [IsoId("_Dallh2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Receiving Parties")]
    [IsoXmlTag("RcvgPties")]
    public ReceivingPartiesAndAccount11? ReceivingParties { get; init; } 
    
    
    #nullable disable
    
}
