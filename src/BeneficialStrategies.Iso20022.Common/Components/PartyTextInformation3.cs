// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
/// </summary>
[IsoId("_XLSgAtp-Ed-ak6NoX_4Aeg_-1555366002")]
[DisplayName("Party Text Information")]
public record PartyTextInformation3
{
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    [IsoId("_XLSgA9p-Ed-ak6NoX_4Aeg_1628689875")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? DeclarationDetails { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_XLSgBNp-Ed-ak6NoX_4Aeg_1863065851")]
    [DisplayName("Party Contact Details")]
    [IsoXmlTag("PtyCtctDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? PartyContactDetails { get; init; }

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_XLSgBdp-Ed-ak6NoX_4Aeg_-17239789")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? RegistrationDetails { get; init; }
}
