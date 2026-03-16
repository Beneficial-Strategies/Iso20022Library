// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the processing request.
/// </summary>
[IsoId("_6f_egQR4Ee29PP19jELcvQ")]
[DisplayName("Request Details")]
public record RequestDetails30
{
    /// <summary>
    /// Type of data being requested, for example, a sub-member BIC.
    /// </summary>
    [IsoId("_6nOu8QR4Ee29PP19jELcvQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Identificates the requestor.
    /// </summary>
    [IsoId("_6nOu8wR4Ee29PP19jELcvQ")]
    [DisplayName("Requestor Identification")]
    [IsoXmlTag("RqstrId")]
    public PartyIdentification242Choice_? RequestorIdentification { get; init; }

    /// <summary>
    /// Additional information to support the processing request.
    /// </summary>
    [IsoId("_6nOu9QR4Ee29PP19jELcvQ")]
    [DisplayName("Additional Request Information")]
    [IsoXmlTag("AddtlReqInf")]
    public SimpleValueList<IsoMax35Text> AdditionalRequestInformation { get; init; } = [];
}
