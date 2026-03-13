// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial instrument cleared by a central counterparty.
/// </summary>
[IsoId("_vcwiQLVNEeadLcJesEbkTQ")]
[DisplayName("Cleared Product")]
public partial record ClearedProduct1
{
    #nullable enable
    
    /// <summary>
    /// Exchange or trading venue where product is traded.
    /// </summary>
    [IsoId("__o5ZsLVNEeadLcJesEbkTQ")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public SimpleValueList<System.String> TradingVenue { get; init; } = [];
    // ID for the above is __o5ZsLVNEeadLcJesEbkTQ
    
    /// <summary>
    /// CCP&apos;s unique identification for product cleared.
    /// </summary>
    [IsoId("_DsqKELVOEeadLcJesEbkTQ")]
    [DisplayName("CCP Product Identification")]
    [IsoXmlTag("CCPPdctId")]
    public required GenericIdentification168 CCPProductIdentification { get; init; } 
    
    /// <summary>
    /// Standard unique identification of product cleared.
    /// </summary>
    [IsoId("__int0MhtEeadgvwNGwK05w")]
    [DisplayName("Universal Product Identification")]
    [IsoXmlTag("UvrslPdctId")]
    public GenericIdentification168? UniversalProductIdentification { get; init; } 
    
    /// <summary>
    /// Choice between the major categories of financial instruments.
    /// </summary>
    [IsoId("__Z5e8LVOEeadLcJesEbkTQ")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public required Product1Choice_ Product { get; init; } 
    
    /// <summary>
    /// Measure of the current stock of a financial instrument that has been traded on an exchange or cleared via a central counterparty.
    /// </summary>
    [IsoId("_Q99nELVZEeadLcJesEbkTQ")]
    [DisplayName("Open Interest")]
    [IsoXmlTag("OpnIntrst")]
    public required OpenInterest1 OpenInterest { get; init; } 
    
    /// <summary>
    /// Number of trades cleared over the reporting period.
    /// </summary>
    [IsoId("_xGV_EPqBEeaQh_7a05rSJQ")]
    [DisplayName("Trades Cleared")]
    [IsoXmlTag("TrdsClrd")]
    [IsoSimpleType(IsoSimpleType.NonNegativeNumber)]
    public IsoNonNegativeNumber? TradesCleared { get; init; } 
    
    
    #nullable disable
    
}
