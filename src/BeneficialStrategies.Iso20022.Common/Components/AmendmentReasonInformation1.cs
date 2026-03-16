// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the amendment of the mandate.
/// </summary>
[IsoId("_TOt8wdp-Ed-ak6NoX_4Aeg_-588729591")]
[DisplayName("Amendment Reason Information")]
public record AmendmentReasonInformation1
{
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [IsoId("_TOt8wtp-Ed-ak6NoX_4Aeg_-1482635343")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [IsoId("_TOt8w9p-Ed-ak6NoX_4Aeg_640498191")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [IsoId("_TOt8xNp-Ed-ak6NoX_4Aeg_-1877900838")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
