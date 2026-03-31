// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reason for which the contract has not been cleared.
/// </summary>
[IsoId("_Ak0bdZPuEey0rJ3Gl6WZVA")]
[DisplayName("Non Clearing Reason")]
public record NonClearingReason2
{
    /// <summary>
    /// Specifies the reason for a clearing exemption or exception.
    /// </summary>
    [IsoId("_AmE_sZPuEey0rJ3Gl6WZVA")]
    [DisplayName("Clearing Exemption Exception")]
    [IsoXmlTag("ClrXmptnXcptn")]
    public SimpleValueList<ClearingExemptionException1Code> ClearingExemptionException { get; init; } =
        [];

    // ID for the above is _AmE_sZPuEey0rJ3Gl6WZVA

    /// <summary>
    /// Indicates the reason for which the contract has not been cleared.
    /// </summary>
    [IsoId("_AmE_s5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Non Clearing Reason Information")]
    [IsoXmlTag("NonClrRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonClearingReasonInformation { get; init; }
}
