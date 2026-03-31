// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the type of place of safekeeping expressed as a code and a BIC.
/// </summary>
[IsoId("_Wjinw7XEEeiTob_PrFFUxA")]
[DisplayName("Safekeeping Place Type And Identification")]
public record SafekeepingPlaceTypeAndIdentification1
{
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_W1QC0bXEEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Place Type")]
    [IsoXmlTag("SfkpgPlcTp")]
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; }

    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    [IsoId("_W1QC07XEEeiTob_PrFFUxA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public required IsoAnyBICDec2014Identifier Identification { get; init; }
}
