// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of other parties.
/// </summary>
[IsoId("_ZdzW2ffXEeiNZp_PtLohLw")]
[DisplayName("Other Parties")]
public partial record OtherParties37
{
    #nullable enable
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_ZdzW3_fXEeiNZp_PtLohLw")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification170? Investor { get; init; } 
    
    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_ZdzW5_fXEeiNZp_PtLohLw")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentification157? QualifiedForeignIntermediary { get; init; } 
    
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_ZdzW7_fXEeiNZp_PtLohLw")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentification157? StockExchange { get; init; } 
    
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_ZdzW9_fXEeiNZp_PtLohLw")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentification157? TradeRegulator { get; init; } 
    
    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_ZdzW__fXEeiNZp_PtLohLw")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification157? TripartyAgent { get; init; } 
    
    
    #nullable disable
    
}
