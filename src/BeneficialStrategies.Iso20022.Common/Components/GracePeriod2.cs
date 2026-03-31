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
[IsoId("_CPcywZJMEeuuktRxxQZoNQ")]
[DisplayName("Grace Period")]
public record GracePeriod2
{
    /// <summary>
    /// Grace period time relative to the grace period unit type.
    /// </summary>
    [IsoId("_CWyJ0ZJMEeuuktRxxQZoNQ")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? Time { get; init; }

    /// <summary>
    /// Grace period unit type.
    /// </summary>
    [IsoId("_CWyJ05JMEeuuktRxxQZoNQ")]
    [DisplayName("Unit Type")]
    [IsoXmlTag("UnitTp")]
    public GracePeriodUnitType1Code? UnitType { get; init; }

    /// <summary>
    /// Grace period other unit type.
    /// </summary>
    [IsoId("_CWyJ1ZJMEeuuktRxxQZoNQ")]
    [DisplayName("Other Unit Type")]
    [IsoXmlTag("OthrUnitTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherUnitType { get; init; }

    /// <summary>
    /// Indicates a customer selected grace period
    /// </summary>
    [IsoId("_oMntkJJMEeuuktRxxQZoNQ")]
    [DisplayName("Customer Selected Grace Period")]
    [IsoXmlTag("CstmrSelctdGracePrd")]
    [IsoSimpleType(IsoSimpleType.boolean)]
    public Isoboolean? CustomerSelectedGracePeriod { get; init; }
}
