// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the settlement failure reason as defined in the relevant regulation.
/// </summary>
[IsoId("_MQiA0TOmEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Daily Failure Reason")]
public record SettlementDailyFailureReason3
{
    /// <summary>
    /// Fails due to lack of securities.
    /// </summary>
    [IsoId("_MRbYsTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Failed Securities")]
    [IsoXmlTag("FaildScties")]
    public required SettlementTotalData1Choice_ FailedSecurities { get; init; }

    /// <summary>
    /// Fails due to lack of cash.
    /// </summary>
    [IsoId("_MRbYszOmEeqX8uoQQ3KffQ")]
    [DisplayName("Failed Cash")]
    [IsoXmlTag("FaildCsh")]
    public required SettlementTotalData1Choice_ FailedCash { get; init; }
}
