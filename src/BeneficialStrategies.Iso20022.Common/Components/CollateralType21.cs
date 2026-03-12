// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information for the first side of the transaction on the type of collateral.
/// </summary>
[IsoId("_C8NGHcg5Eeu4ecZgAYuz5w")]
[DisplayName("Collateral Type")]
public partial record CollateralType21
{
    #nullable enable
    
    /// <summary>
    /// Data specific to securities and related fields used as a collateral.
    /// </summary>
    [IsoId("_C9k_E8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public Security52? Security { get; init; } 
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_C9k_Fcg5Eeu4ecZgAYuz5w")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public AmountHaircutMargin1? Cash { get; init; } 
    
    /// <summary>
    /// Data specific to commodities and related fields used as a collateral.
    /// </summary>
    [IsoId("_C9k_F8g5Eeu4ecZgAYuz5w")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public Commodity43? Commodity { get; init; } 
    
    
    #nullable disable
    
}
