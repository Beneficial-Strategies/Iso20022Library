// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer involved in the card payment.
/// </summary>
[IsoId("_rUynIQumEeqw5uEXxQ9H4g")]
[DisplayName("Acquirer")]
public partial record Acquirer10
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer (for example the bank identification number BIN).
    /// </summary>
    [IsoId("_rge5wQumEeqw5uEXxQ9H4g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public GenericIdentification177? Identification { get; init; } 
    
    /// <summary>
    /// Version of the payment acquirer parameters of the POI.
    /// </summary>
    [IsoId("_rge5wwumEeqw5uEXxQ9H4g")]
    [DisplayName("Parameters Version")]
    [IsoXmlTag("ParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? ParametersVersion { get; init; } 
    
    
    #nullable disable
    
}
