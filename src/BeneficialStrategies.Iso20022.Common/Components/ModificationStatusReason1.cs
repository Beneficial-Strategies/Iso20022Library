// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status of the cancellation request.
/// </summary>
[IsoId("_LyqLI4lsEeePr-EGJjGYzQ")]
[DisplayName("Modification Status Reason")]
public record ModificationStatusReason1
{
    /// <summary>
    /// Party that issues the cancellation status.
    /// </summary>
    [IsoId("_L89Wg4lsEeePr-EGJjGYzQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification125? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    [IsoId("_L89WhYlsEeePr-EGJjGYzQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ModificationStatusReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    [IsoId("_L89Wh4lsEeePr-EGJjGYzQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
