// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trace of response by the entities in the path from the issuer to the ATM.
/// </summary>
[IsoId("_sqO24IqDEeS3NqNpgnMh2w")]
[DisplayName("Response Type")]
public record ResponseType4
{
    /// <summary>
    /// Identification of the responder.
    /// </summary>
    [IsoId("_-DS0cIqDEeS3NqNpgnMh2w")]
    [DisplayName("Responder Identification")]
    [IsoXmlTag("RspndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ResponderIdentification { get; init; }

    /// <summary>
    /// Codification of the response (for instance ISO 8583, IFX).
    /// </summary>
    [IsoId("_gQ530IqFEeSRT5rEzcAHEw")]
    [DisplayName("Codification")]
    [IsoXmlTag("Cdfctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Codification { get; init; }

    /// <summary>
    /// Result of the request withdrawal message.
    /// </summary>
    [IsoId("_jEnVkIqFEeSRT5rEzcAHEw")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Response { get; init; }

    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_liKWEIqFEeSRT5rEzcAHEw")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_oknacIqFEeSRT5rEzcAHEw")]
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalResponseInformation { get; init; }
}
