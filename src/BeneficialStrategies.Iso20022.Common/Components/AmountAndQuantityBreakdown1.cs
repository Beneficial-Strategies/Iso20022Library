// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a an amount or quantity.
/// </summary>
[IsoId("_qHXhcbFMEeqxQ8-YVgMtLw")]
[DisplayName("Amount And Quantity Breakdown")]
public partial record AmountAndQuantityBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_qJ54EbFMEeqxQ8-YVgMtLw")]
    [DisplayName("Lot Number")]
    [IsoXmlTag("LotNb")]
    public GenericIdentification37? LotNumber { get; init; } 
    
    /// <summary>
    /// Amount of money that is part of the lot described.
    /// </summary>
    [IsoId("_zq6URLFMEeqxQ8-YVgMtLw")]
    [DisplayName("Lot Amount")]
    [IsoXmlTag("LotAmt")]
    public AmountAndDirection5? LotAmount { get; init; } 
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_qJ54GbFMEeqxQ8-YVgMtLw")]
    [DisplayName("Lot Quantity")]
    [IsoXmlTag("LotQty")]
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_qJ54IbFMEeqxQ8-YVgMtLw")]
    [DisplayName("Cash Sub Balance Type")]
    [IsoXmlTag("CshSubBalTp")]
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    
    
    #nullable disable
    
}
