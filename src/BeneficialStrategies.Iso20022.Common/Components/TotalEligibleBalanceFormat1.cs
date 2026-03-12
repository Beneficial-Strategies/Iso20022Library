// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total eligible balance for the corporate action and full and part way period units.
/// </summary>
[IsoId("_DfqegCqcEeObprHJy8Zrxg")]
[DisplayName("Total Eligible Balance Format")]
public partial record TotalEligibleBalanceFormat1
{
    #nullable enable
    
    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_n9E2wCqcEeObprHJy8Zrxg")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public Quantity3Choice_? Balance { get; init; } 
    
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    [IsoId("_x_DSAiqcEeObprHJy8Zrxg")]
    [DisplayName("Full Period Units")]
    [IsoXmlTag("FullPrdUnits")]
    public SignedQuantityFormat2? FullPeriodUnits { get; init; } 
    
    /// <summary>
    /// Number of units of a fund that were purchased part way throughout a distribution period, for example Group II Units in the U.K.
    /// </summary>
    [IsoId("_x_DSAyqcEeObprHJy8Zrxg")]
    [DisplayName("Part Way Period Units")]
    [IsoXmlTag("PartWayPrdUnits")]
    public SignedQuantityFormat2? PartWayPeriodUnits { get; init; } 
    
    
    #nullable disable
    
}
