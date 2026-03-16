// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
[IsoId("_QQkwqNp-Ed-ak6NoX_4Aeg_-647119755")]
[DisplayName("Party Identification")]
public record PartyIdentification23
{
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QQuhoNp-Ed-ak6NoX_4Aeg_-647119753")]
    [DisplayName("BIC Or BEI")]
    [IsoXmlTag("BICOrBEI")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier BICOrBEI { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_QQuhodp-Ed-ak6NoX_4Aeg_-647119738")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public required GenericIdentification1 ProprietaryIdentification { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QQuhotp-Ed-ak6NoX_4Aeg_-647119720")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress5? NameAndAddress { get; init; }
}
