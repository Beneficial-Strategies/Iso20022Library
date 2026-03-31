// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_QQkwpdp-Ed-ak6NoX_4Aeg_1436918171")]
[DisplayName("Party Identification")]
public record PartyIdentification22
{
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QQkwptp-Ed-ak6NoX_4Aeg_1486788309")]
    [DisplayName("BIC Or BEI")]
    [IsoXmlTag("BICOrBEI")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier BICOrBEI { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_QQkwp9p-Ed-ak6NoX_4Aeg_1555128116")]
    [DisplayName("Alternative Identifier")]
    [IsoXmlTag("AltrntvIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<System.String> AlternativeIdentifier { get; init; } = [];
}
