// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information concerning the identification data that is advised to be modified.
/// </summary>
[IsoId("_QpKPxNp-Ed-ak6NoX_4Aeg_-1017342654")]
[DisplayName("Identification Modification")]
public record IdentificationModification1
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambigiously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_QpKPxdp-Ed-ak6NoX_4Aeg_-1131181720")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_QpKPxtp-Ed-ak6NoX_4Aeg_-2128254073")]
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation1? OriginalPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Provides updated party and/or account identification information.
    /// </summary>
    [IsoId("_QpKPx9p-Ed-ak6NoX_4Aeg_-1480439384")]
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public required IdentificationInformation1 UpdatedPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the modification information.
    /// </summary>
    [IsoId("_QpUAwNp-Ed-ak6NoX_4Aeg_-1894245207")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
