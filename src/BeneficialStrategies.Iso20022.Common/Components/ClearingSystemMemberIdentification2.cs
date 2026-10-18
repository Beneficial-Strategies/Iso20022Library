// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IClearingSystemMemberIdentification2"/>
[IsoId("_TMehHNp-Ed-ak6NoX_4Aeg_151445359")]
[DisplayName("Clearing System Member Identification")]
public partial record ClearingSystemMemberIdentification2
{
    /// <inheritdoc cref="IClearingSystemMemberIdentification2.ClearingSystemIdentification"/>
    [IsoId("_TMehHdp-Ed-ak6NoX_4Aeg_-1082144614")]
    [DisplayName("Clearing System Identification")]
    [IsoXmlTag("ClrSysId")]
    public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; }

    /// <inheritdoc cref="IClearingSystemMemberIdentification2.MemberIdentification"/>
    [IsoId("_TMehHtp-Ed-ak6NoX_4Aeg_151445420")]
    [DisplayName("Member Identification")]
    [IsoXmlTag("MmbId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MemberIdentification { get; init; }
}
