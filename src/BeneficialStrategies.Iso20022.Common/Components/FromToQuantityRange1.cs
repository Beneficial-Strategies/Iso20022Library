// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of quantities.
/// </summary>
[IsoId("_jtHuEe5NEeCisYr99QEiWA_674630365")]
[DisplayName("From To Quantity Range")]
public partial record FromToQuantityRange1
{
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of quantity values.
    /// </summary>
    [IsoId("_jtHuEu5NEeCisYr99QEiWA_-621671182")]
    [DisplayName("From Quantity")]
    [IsoXmlTag("FrQty")]
    public required QuantityRangeBoundary1 FromQuantity { get; init; } 
    
    /// <summary>
    /// Upper boundary of a range of quantity values.
    /// </summary>
    [IsoId("_jtHuE-5NEeCisYr99QEiWA_788676247")]
    [DisplayName("To Quantity")]
    [IsoXmlTag("ToQty")]
    public required QuantityRangeBoundary1 ToQuantity { get; init; } 
    
    
    #nullable disable
    
}
