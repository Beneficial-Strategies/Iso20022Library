// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cleared Product2.
/// </summary>
[IsoId("_kJGBQUThEe-J4uL5kPsWHg")]
[DisplayName("Cleared Product2")]
public partial record ClearedProduct2
{
    #nullable enable

    /// <summary>
    /// CCP Product Identification.
    /// </summary>
    [DisplayName("CCP Product Identification")]
    [IsoXmlTag("CCPPdctId")]
    public required GenericIdentification168 CCPProductIdentification { get; init; } 

    /// <summary>
    /// Cleared Gross Notional Amount.
    /// </summary>
    [DisplayName("Cleared Gross Notional Amount")]
    [IsoXmlTag("ClrdGrssNtnlAmt")]
    public required ActiveCurrencyAnd24Amount ClearedGrossNotionalAmount { get; init; } 

    /// <summary>
    /// Open Interest.
    /// </summary>
    [DisplayName("Open Interest")]
    [IsoXmlTag("OpnIntrst")]
    public required OpenInterest1 OpenInterest { get; init; } 

    /// <summary>
    /// Product.
    /// </summary>
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public required Product1Choice_ Product { get; init; } 

    /// <summary>
    /// Trades Cleared.
    /// </summary>
    [DisplayName("Trades Cleared")]
    [IsoXmlTag("TrdsClrd")]
    public IsoNonNegativeNumber? TradesCleared { get; init; } 

    /// <summary>
    /// Trading Venue.
    /// </summary>
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public ValueList<IsoMICIdentifier> TradingVenue { get; init; } = [];

    /// <summary>
    /// Universal Product Identification.
    /// </summary>
    [DisplayName("Universal Product Identification")]
    [IsoXmlTag("UvrslPdctId")]
    public GenericIdentification168? UniversalProductIdentification { get; init; } 

    
    #nullable disable
    
}
