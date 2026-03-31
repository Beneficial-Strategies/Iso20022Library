// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[IsoId("_TbaaYa2AEeWMg5rOByfExw")]
[DisplayName("Response Type")]
public record ResponseType7
{
    /// <summary>
    /// Result of the requested transaction.
    /// </summary>
    [IsoId("_Tn7zca2AEeWMg5rOByfExw")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response4Code Response { get; init; }

    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_Tn7zc62AEeWMg5rOByfExw")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public ResultDetail4Code? ResponseReason { get; init; }

    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_Tn7zda2AEeWMg5rOByfExw")]
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalResponseInformation { get; init; }
}
