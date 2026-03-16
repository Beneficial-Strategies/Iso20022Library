// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a proprietary party.
/// </summary>
[IsoId("_Rp-zl9p-Ed-ak6NoX_4Aeg_1074004060")]
[DisplayName("Proprietary Party")]
public record ProprietaryParty2
{
    /// <summary>
    /// Specifies the type of proprietary party.
    /// </summary>
    [IsoId("_Rp-zmNp-Ed-ak6NoX_4Aeg_1074004062")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Proprietary party.
    /// </summary>
    [IsoId("_RqIkkNp-Ed-ak6NoX_4Aeg_1074004122")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification32 Party { get; init; }
}
