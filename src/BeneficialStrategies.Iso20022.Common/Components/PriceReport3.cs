// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a price report.
/// </summary>
[IsoId("_brky0RmCEeKxsrht2duUcg")]
[DisplayName("Price Report")]
public partial record PriceReport3
{
    #nullable enable
    
    /// <summary>
    /// Information related to the price valuation of a financial instrument.
    /// </summary>
    [IsoId("_cAvKhRmCEeKxsrht2duUcg")]
    [DisplayName("Price Valuation Details")]
    [IsoXmlTag("PricValtnDtls")]
    public ValueList<PriceValuation4> PriceValuationDetails { get; init; } = new ValueList<PriceValuation4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _cAvKhRmCEeKxsrht2duUcg
    
    
    #nullable disable
    
}
