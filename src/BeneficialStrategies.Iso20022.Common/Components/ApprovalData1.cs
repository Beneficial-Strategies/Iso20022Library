// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data pertaining to the approval of the transaction.
/// </summary>
[IsoId("_7fkbkEVSEeea-M6VZkEPUw")]
[DisplayName("Approval Data")]
public record ApprovalData1
{
    /// <summary>
    /// Entity that has delivered or declined the card payment authorisation (the party may be unidentified).
    /// </summary>
    [IsoId("_QLClEEVTEeea-M6VZkEPUw")]
    [DisplayName("Approval Entity")]
    [IsoXmlTag("ApprvlNtty")]
    public ApprovalEntity1? ApprovalEntity { get; init; }

    /// <summary>
    /// Value assigned by the approval entity indicating approval.
    /// ISO 8583:93/2003 bit 38
    /// </summary>
    [IsoId("_cvMpMEVTEeea-M6VZkEPUw")]
    [DisplayName("Approval Code")]
    [IsoXmlTag("ApprvlCd")]
    [IsoSimpleType(IsoSimpleType.Exact6AlphaNumericText)]
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; }
}
