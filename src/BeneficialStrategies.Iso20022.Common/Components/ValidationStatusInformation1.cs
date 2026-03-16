// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a specific message.
/// </summary>
[IsoId("_RXzec9p-Ed-ak6NoX_4Aeg_714459273")]
[DisplayName("Validation Status Information")]
public record ValidationStatusInformation1
{
    /// <summary>
    /// The result of the technical validation (e.g. Accepted, Reception error) executed on the request message.
    /// </summary>
    [IsoId("_RXzedNp-Ed-ak6NoX_4Aeg_1118960492")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TechnicalValidationStatus1Code Status { get; init; }

    /// <summary>
    /// The reason for the validation status.
    /// </summary>
    [IsoId("_RXzeddp-Ed-ak6NoX_4Aeg_1535469525")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReason4Choice_? StatusReason { get; init; }

    /// <summary>
    /// Further details on the validation status reason.
    /// </summary>
    [IsoId("_RXzedtp-Ed-ak6NoX_4Aeg_1617662894")]
    [DisplayName("Additional Status Reason Information")]
    [IsoXmlTag("AddtlStsRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalStatusReasonInformation { get; init; }
}
