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
[IsoId("_e8g34RzfEeK5OKMB21JFBg")]
[DisplayName("Acquirer")]
public partial record Acquirer2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer (for example the bank identification number BIN).
    /// </summary>
    [IsoId("_fI2qwRzfEeK5OKMB21JFBg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public GenericIdentification32? Identification { get; init; } 
    
    /// <summary>
    /// Version of the payment acquirer parameters of the POI.
    /// </summary>
    [IsoId("_fI2qxRzfEeK5OKMB21JFBg")]
    [DisplayName("Parameters Version")]
    [IsoXmlTag("ParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ParametersVersion { get; init; } 
    
    
    #nullable disable
    
}
