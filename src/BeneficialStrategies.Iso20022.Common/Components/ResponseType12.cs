// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response Type12.
/// </summary>
[IsoId("_1IgUcZ9REe-nbM0aSPcoiQ")]
[DisplayName("Response Type12")]
public record ResponseType12
{
    /// <summary>
    /// Additional Response Information.
    /// </summary>
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    public IsoMax140Text? AdditionalResponseInformation { get; init; }

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response12Code Response { get; init; }

    /// <summary>
    /// Response Reason.
    /// </summary>
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public ResultDetail5Code? ResponseReason { get; init; }
}
