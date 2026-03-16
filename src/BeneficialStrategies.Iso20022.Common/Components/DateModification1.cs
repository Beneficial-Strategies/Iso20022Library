// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to a date.
/// </summary>
[IsoId("_8KJNgA4qEeK3IMoVvcTkkg")]
[DisplayName("Date Modification")]
public record DateModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_EcNKUA4rEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Date.
    /// </summary>
    [IsoId("_H0vMYA4rEeK3IMoVvcTkkg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; }
}
