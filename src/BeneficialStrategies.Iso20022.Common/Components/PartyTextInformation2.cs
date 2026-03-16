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
[IsoId("_PYi8ftp-Ed-ak6NoX_4Aeg_1769478257")]
[DisplayName("Party Text Information")]
public record PartyTextInformation2
{
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    [IsoId("_PYstcNp-Ed-ak6NoX_4Aeg_1655639191")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DeclarationDetails { get; init; }

    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_PYstcdp-Ed-ak6NoX_4Aeg_658566838")]
    [DisplayName("Party Contact Details")]
    [IsoXmlTag("PtyCtctDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? PartyContactDetails { get; init; }
}
