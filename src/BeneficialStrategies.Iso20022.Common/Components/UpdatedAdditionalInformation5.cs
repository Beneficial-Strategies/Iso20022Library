// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information with update description and date.
/// </summary>
[IsoId("_XWm_Mtp-Ed-ak6NoX_4Aeg_-2064696205")]
[DisplayName("Updated Additional Information")]
public record UpdatedAdditionalInformation5
{
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_XWm_M9p-Ed-ak6NoX_4Aeg_-1385400513")]
    [DisplayName("Update Description")]
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? UpdateDescription { get; init; }

    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_XWm_NNp-Ed-ak6NoX_4Aeg_1029261143")]
    [DisplayName("Update Date")]
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UpdateDate { get; init; }

    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    [IsoId("_XWm_Ndp-Ed-ak6NoX_4Aeg_-81650276")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    // ID for the above is _XWm_Ndp-Ed-ak6NoX_4Aeg_-81650276
}
