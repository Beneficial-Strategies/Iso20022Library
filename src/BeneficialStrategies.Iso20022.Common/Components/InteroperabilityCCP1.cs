// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Interoperability CCP1.
/// </summary>
[IsoId("_CX1PMFnFEe21_Ij7nUB3IA")]
[DisplayName("Interoperability CCP1")]
public partial record InteroperabilityCCP1
{
    #nullable enable

    /// <summary>
    /// Asset Holding.
    /// </summary>
    [DisplayName("Asset Holding")]
    [IsoXmlTag("AsstHldg")]
    public ValueList<AssetHolding3> AssetHolding { get; init; } = [];

    /// <summary>
    /// Gross Notional Amount.
    /// </summary>
    [DisplayName("Gross Notional Amount")]
    [IsoXmlTag("GrssNtnlAmt")]
    public ValueList<ActiveCurrencyAnd24Amount> GrossNotionalAmount { get; init; } = [];

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification168 Identification { get; init; } 

    /// <summary>
    /// Total Initial Margin.
    /// </summary>
    [DisplayName("Total Initial Margin")]
    [IsoXmlTag("TtlInitlMrgn")]
    public ValueList<ActiveCurrencyAndAmount> TotalInitialMargin { get; init; } = [];

    /// <summary>
    /// Trades Cleared.
    /// </summary>
    [DisplayName("Trades Cleared")]
    [IsoXmlTag("TrdsClrd")]
    public IsoNonNegativeNumber? TradesCleared { get; init; } 

    
    #nullable disable
    
}
