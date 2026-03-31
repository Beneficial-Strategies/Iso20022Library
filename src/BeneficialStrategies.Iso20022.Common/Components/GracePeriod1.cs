// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Grace period applicable to an instalment plan.
/// </summary>
[IsoId("_SDCRMEVCEeea-M6VZkEPUw")]
[DisplayName("Grace Period")]
public record GracePeriod1
{
    /// <summary>
    /// Grace period time relative to the grace period unit type.
    /// </summary>
    [IsoId("_mEDvgEVCEeea-M6VZkEPUw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText Time { get; init; }

    /// <summary>
    /// Grace period unit type.
    /// </summary>
    [IsoId("_tgcBgEVCEeea-M6VZkEPUw")]
    [DisplayName("Unit Type")]
    [IsoXmlTag("UnitTp")]
    public required GracePeriodUnitType1Code UnitType { get; init; }

    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    [IsoId("_7tjAcEVCEeea-M6VZkEPUw")]
    [DisplayName("Other Unit Type")]
    [IsoXmlTag("OthrUnitTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherUnitType { get; init; }
}
