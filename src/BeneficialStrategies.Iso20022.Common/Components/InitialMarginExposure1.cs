// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Liability a clearing member has to a central counterparty with respect to potential future exposures.
/// </summary>
[IsoId("_XCK8BapzEeamNLogr5TkIQ")]
[DisplayName("Initial Margin Exposure")]
public record InitialMarginExposure1
{
    /// <summary>
    /// Initial margin requirement for margin account.
    /// </summary>
    [IsoId("_XCK8B6pzEeamNLogr5TkIQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount3 Amount { get; init; }

    /// <summary>
    /// Classification of component used in the calculation of the total initial margin requirement.
    /// </summary>
    [IsoId("_XCK8CKpzEeamNLogr5TkIQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MarginType2Choice_ Type { get; init; }

    /// <summary>
    /// Indicates whether the component is considered a core part of the margin model. Usage: In the context of European central counterparties, if the component is included in backtesting procedures in order to assess the performance of the initial margin model as required by EMIR RTS Article (49)(1).
    /// </summary>
    [IsoId("_XCK8CapzEeamNLogr5TkIQ")]
    [DisplayName("Core Indicator")]
    [IsoXmlTag("CoreInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator CoreIndicator { get; init; }
}
