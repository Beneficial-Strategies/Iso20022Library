// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result the output (display, print, input).
/// </summary>
[IsoId("_3CNXIN7EEeiwsev40qZGEQ")]
[DisplayName("Output Result")]
public record OutputResult1
{
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output.
    /// </summary>
    [IsoId("__Gk2MN7EEeiwsev40qZGEQ")]
    [DisplayName("Device Type")]
    [IsoXmlTag("DvcTp")]
    public required UserInterface4Code DeviceType { get; init; }

    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [IsoId("_Eop-sN7FEeiwsev40qZGEQ")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public required InformationQualify1Code InformationQualifier { get; init; }

    /// <summary>
    /// Gives response for each peripheral.
    /// </summary>
    [IsoId("_LYGSMN7FEeiwsev40qZGEQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; }
}
