// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about business parties involved in the transaction.
/// </summary>
[IsoId("_AOPFx9okEeC60axPepSq7g_1209561399")]
[DisplayName("Other Parties")]
public partial record OtherParties18
{
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_AOYPsNokEeC60axPepSq7g_1095722333")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    
    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    [IsoId("_AOYPsdokEeC60axPepSq7g_98649980")]
    [DisplayName("Stock Exchange")]
    [IsoXmlTag("StockXchg")]
    public PartyIdentificationAndAccount87? StockExchange { get; init; } 
    
    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    [IsoId("_AOYPstokEeC60axPepSq7g_-898422373")]
    [DisplayName("Trade Regulator")]
    [IsoXmlTag("TradRgltr")]
    public PartyIdentificationAndAccount87? TradeRegulator { get; init; } 
    
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_AOYPs9okEeC60axPepSq7g_-1895494726")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentificationAndAccount83? TripartyAgent { get; init; } 
    
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_AOYPtNokEeC60axPepSq7g_907764690")]
    [DisplayName("Qualified Foreign Intermediary")]
    [IsoXmlTag("QlfdFrgnIntrmy")]
    public PartyIdentificationAndAccount77? QualifiedForeignIntermediary { get; init; } 
    
    
    #nullable disable
    
}
