// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the securities account processed in the system.
/// </summary>
[IsoId("_102h8eGEEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Status")]
public record SecuritiesAccountStatus2
{
    /// <summary>
    /// Unique identification of the securities account referenced by a request.
    /// </summary>
    [IsoId("_2DI1leGEEeWCAvUNsZ5u6g")]
    [DisplayName("Related Securities Account")]
    [IsoXmlTag("RltdSctiesAcct")]
    public SecuritiesAccount19? RelatedSecuritiesAccount { get; init; }

    /// <summary>
    /// Status of the securities account maintenance instruction.
    /// </summary>
    [IsoId("_2DI1l-GEEeWCAvUNsZ5u6g")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status6Code Status { get; init; }

    /// <summary>
    /// Reason for the status of a securities account maintenance instruction.
    /// </summary>
    [IsoId("_2DI1meGEEeWCAvUNsZ5u6g")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<StatusReasonInformation10> StatusReason { get; init; } = [];
}
