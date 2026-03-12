// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other parties information.
/// </summary>
[IsoId("_K2Bz_-aOEd-q8fx_Zl_34A")]
[DisplayName("Other Parties")]
public partial record OtherParties10
{
    #nullable enable
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_K2B0AeaOEd-q8fx_Zl_34A")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification37Choice_? Investor { get; init; } 
    
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_K2B0A-aOEd-q8fx_Zl_34A")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification49Choice_? StockExchange { get; init; } 
    
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_K2B0BeaOEd-q8fx_Zl_34A")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification49Choice_? TradeRegulator { get; init; } 
    
    
    #nullable disable
    
}
