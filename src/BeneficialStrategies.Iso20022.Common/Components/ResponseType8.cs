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
[IsoId("_QBsiAa1_EeWMg5rOByfExw")]
[DisplayName("Response Type")]
public record ResponseType8
{
    /// <summary>
    /// Identification of the responder.
    /// </summary>
    [IsoId("_QNdtIa1_EeWMg5rOByfExw")]
    [DisplayName("Responder Identification")]
    [IsoXmlTag("RspndrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ResponderIdentification { get; init; }

    /// <summary>
    /// Codification of the response (for instance ISO 8583, IFX).
    /// </summary>
    [IsoId("_QNdtI61_EeWMg5rOByfExw")]
    [DisplayName("Codification")]
    [IsoXmlTag("Cdfctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Codification { get; init; }

    /// <summary>
    /// Result of the request.
    /// </summary>
    [IsoId("_QNdtJa1_EeWMg5rOByfExw")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Response { get; init; }

    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_QNdtJ61_EeWMg5rOByfExw")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_QNdtKa1_EeWMg5rOByfExw")]
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalResponseInformation { get; init; }
}
