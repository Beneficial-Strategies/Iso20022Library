// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM cassette counter per unit value or globally.
/// </summary>
[IsoId("_k0cdIa4MEeWZgJQOa6iKCQ")]
[DisplayName("ATM Cassette Counters")]
public partial record ATMCassetteCounters3
{
    #nullable enable
    
    /// <summary>
    /// Amount of one media unit, if the media type is valued.
    /// </summary>
    [IsoId("_lAXZQa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public ImpliedCurrencyAndAmount? UnitValue { get; init; } 
    
    /// <summary>
    /// Currency of the media, if the media type is valued and different from the currency of the requested amount.
    /// </summary>
    [IsoId("_lAXZQ64MEeWZgJQOa6iKCQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Category of media items.
    /// </summary>
    [IsoId("_lAXZRa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Media Category")]
    [IsoXmlTag("MdiaCtgy")]
    public ATMMediaType3Code? MediaCategory { get; init; } 
    
    /// <summary>
    /// Current number of media present in the cassette.
    /// </summary>
    [IsoId("_lAXZSa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Current Number")]
    [IsoXmlTag("CurNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber CurrentNumber { get; init; } 
    
    /// <summary>
    /// Current amount in the cassette.
    /// </summary>
    [IsoId("_lAXZS64MEeWZgJQOa6iKCQ")]
    [DisplayName("Current Amount")]
    [IsoXmlTag("CurAmt")]
    public ImpliedCurrencyAndAmount? CurrentAmount { get; init; } 
    
    /// <summary>
    /// Counters of media inside the cassette.
    /// </summary>
    [IsoId("_lAXZR64MEeWZgJQOa6iKCQ")]
    [DisplayName("Flow Totals")]
    [IsoXmlTag("FlowTtls")]
    public ATMCassetteCounters4? FlowTotals { get; init; } 
    
    
    #nullable disable
    
}
