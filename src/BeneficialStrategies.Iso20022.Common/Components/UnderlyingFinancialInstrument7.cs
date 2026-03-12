// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying financial instrument to which an trade confirmation is related.
/// </summary>
[IsoId("_2C-80QhLEe2fOITqoTnSLQ")]
[DisplayName("Underlying Financial Instrument")]
public partial record UnderlyingFinancialInstrument7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the underlying security by an ISIN.
    /// </summary>
    [IsoId("_2VwH0QhLEe2fOITqoTnSLQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification19 Identification { get; init; } 
    
    /// <summary>
    /// Underlying financial instrument attributes to which an trade confirmation is related.
    /// </summary>
    [IsoId("_2VwH2QhLEe2fOITqoTnSLQ")]
    [DisplayName("Attributes")]
    [IsoXmlTag("Attrbts")]
    public FinancialInstrumentAttributes124? Attributes { get; init; } 
    
    
    #nullable disable
    
}
