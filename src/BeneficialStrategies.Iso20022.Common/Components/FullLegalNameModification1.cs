// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to the full legal name.
/// </summary>
[IsoId("_c8xsMA4iEeK3IMoVvcTkkg")]
[DisplayName("Full Legal Name Modification")]
public record FullLegalNameModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_owJzoA4iEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_uXcMQA4iEeK3IMoVvcTkkg")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text FullLegalName { get; init; }
}
