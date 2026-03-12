// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_D2EMMAfeEeSLV4FSBR_q6A")]
[DisplayName("Trade Party Identification")]
public partial record TradePartyIdentification7
{
    #nullable enable
    
    /// <summary>
    /// Identifies the fund which is one of the parties in a treasury trade.
    /// </summary>
    [IsoId("_3YpMwAfeEeSLV4FSBR_q6A")]
    [DisplayName("Fund Information")]
    [IsoXmlTag("FndInf")]
    public FundIdentification3? FundInformation { get; init; } 
    
    /// <summary>
    /// Specifies the party which is the buyer or the seller.
    /// </summary>
    [IsoId("_DbIuQAffEeSLV4FSBR_q6A")]
    [DisplayName("Buyer Or Seller Indicator")]
    [IsoXmlTag("BuyrOrSellrInd")]
    public required OptionParty1Code BuyerOrSellerIndicator { get; init; } 
    
    /// <summary>
    /// Specifies if a trade party is a taker or a maker.
    /// </summary>
    [IsoId("_EFezsEVUEeSGWeX3z5zSZQ")]
    [DisplayName("Initiator Indicator")]
    [IsoXmlTag("InitrInd")]
    public required OptionParty3Code InitiatorIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_PLv5kIHFEeSY3ulMDfpmvA")]
    [DisplayName("Trade Party Identification")]
    [IsoXmlTag("TradPtyId")]
    public required PartyIdentification78 TradePartyIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the party which submits a treasury trade to a matching system or to a settlement system or to a counterparty.
    /// </summary>
    [IsoId("_LaETsAffEeSLV4FSBR_q6A")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    public required PartyIdentificationAndAccount119 SubmittingParty { get; init; } 
    
    
    #nullable disable
    
}
