// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the rejection of the instruction or cancellation request.
/// </summary>
[IsoId("_RDPjttp-Ed-ak6NoX_4Aeg_1264973703")]
[DisplayName("Additional Status")]
public record AdditionalStatus2
{
    /// <summary>
    /// Reason advising the rejection of the instruction cancellation request.
    /// </summary>
    [IsoId("_RDPjt9p-Ed-ak6NoX_4Aeg_1264974188")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancellationRejectionStatus1Choice_ Reason { get; init; }

    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    [IsoId("_RDPjuNp-Ed-ak6NoX_4Aeg_1264973826")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
