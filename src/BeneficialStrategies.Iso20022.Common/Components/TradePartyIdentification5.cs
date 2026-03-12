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
[IsoId("_SkxHqQEcEeCQm6a_G2yO_w_1255553988")]
[DisplayName("Trade Party Identification")]
public partial record TradePartyIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Party that submits the foreign exchange trade to the matching system or to the settlement system or to the counterparty.
    /// </summary>
    [IsoId("_SkxHqgEcEeCQm6a_G2yO_w_144642569")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    public required PartyIdentification19Choice_ SubmittingParty { get; init; } 
    
    /// <summary>
    /// Party that originated the foreign exchange trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_SkxHqwEcEeCQm6a_G2yO_w_-343374891")]
    [DisplayName("Trade Party")]
    [IsoXmlTag("TradPty")]
    public required PartyIdentification19Choice_ TradeParty { get; init; } 
    
    /// <summary>
    /// Identifies the fund that is one of the parties in the foreign exchange trade.
    /// </summary>
    [IsoId("_SkxHrAEcEeCQm6a_G2yO_w_669353995")]
    [DisplayName("Fund Identification")]
    [IsoXmlTag("FndId")]
    public FundIdentification3? FundIdentification { get; init; } 
    
    
    #nullable disable
    
}
