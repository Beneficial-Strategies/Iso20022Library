// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information.
/// </summary>
[IsoId("_tmecgZCkEeiQvr1XXv37hw")]
[DisplayName("Additional Information")]
public record AdditionalInformation15
{
    /// <summary>
    /// Type of additional information.
    /// </summary>
    [IsoId("_t2iRwZCkEeiQvr1XXv37hw")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public required GenericIdentification36 InformationType { get; init; }

    /// <summary>
    /// Value of the additional information.
    /// </summary>
    [IsoId("_t2iRw5CkEeiQvr1XXv37hw")]
    [DisplayName("Information Value")]
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text InformationValue { get; init; }
}
