// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer involved in the card payment.
/// </summary>
[IsoId("_Fgq1ARzyEeK5OKMB21JFBg")]
[DisplayName("Acquirer")]
public record Acquirer3
{
    /// <summary>
    /// Identification of the acquirer (for example the bank identification number BIN).
    /// </summary>
    [IsoId("_Fs3d9RzyEeK5OKMB21JFBg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification32 Identification { get; init; }

    /// <summary>
    /// Version of the payment acquirer parameters of the POI.
    /// </summary>
    [IsoId("_Fs3d_BzyEeK5OKMB21JFBg")]
    [DisplayName("Parameters Version")]
    [IsoXmlTag("ParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ParametersVersion { get; init; }
}
