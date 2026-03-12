// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed ownership information about the shareholding quantity to be disclosed,  or the shareholding quantity not to be disclosed and the shareholding quantity below threshold.
/// </summary>
[IsoId("_6J90MMAOEembi_x1QDJfxw")]
[DisplayName("Account Sublevel")]
public partial record AccountSublevel21
{
    #nullable enable
    
    /// <summary>
    /// Quantity of shares for which shareholding details are not disclosed.
    /// </summary>
    [IsoId("_EjvrcMAPEembi_x1QDJfxw")]
    [DisplayName("Non Disclosed Shareholding Quantity")]
    [IsoXmlTag("NonDscldShrhldgQty")]
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of shares for which shareholding details are not reported as the quantity of shares owned by the shareholder is under the threshold limit.
    /// </summary>
    [IsoId("_M8FH0cJeEemAX8h_sVjY5g")]
    [DisplayName("Below Threshold Shareholding Quantity")]
    [IsoXmlTag("BlwThrshldShrhldgQty")]
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; init; } 
    
    /// <summary>
    /// Details of the account sub-levels and holdings.
    /// </summary>
    [IsoId("_KKnNUMAPEembi_x1QDJfxw")]
    [DisplayName("Disclosure")]
    [IsoXmlTag("Dsclsr")]
    public AccountSubLevel20? Disclosure { get; init; } 
    
    
    #nullable disable
    
}
