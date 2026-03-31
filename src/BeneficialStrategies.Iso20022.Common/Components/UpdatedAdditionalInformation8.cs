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
[IsoId("_xIm7YUEJEeWVgfuHGaKtRQ")]
[DisplayName("Updated Additional Information")]
public record UpdatedAdditionalInformation8
{
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_xWSyFUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Update Description")]
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? UpdateDescription { get; init; }

    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_xWSyF0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Update Date")]
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? UpdateDate { get; init; }

    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    [IsoId("_xWSyGUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    // ID for the above is _xWSyGUEJEeWVgfuHGaKtRQ
}
