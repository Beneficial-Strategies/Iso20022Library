// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the two largest assumed defaulting entities under a particular scenario.
/// </summary>
[IsoId("_hs1wsLJPEeaYqc4G3TTwhA")]
[DisplayName("Cover Two Defaulters")]
public record CoverTwoDefaulters1
{
    /// <summary>
    /// Identifies the member whose default would generate the largest liquidity exposure for the CCP under the scenario and for the relevant currency.
    /// </summary>
    [IsoId("_mgMyALJPEeaYqc4G3TTwhA")]
    [DisplayName("Cover 1 Identification")]
    [IsoXmlTag("Cover1Id")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier Cover1Identification { get; init; }

    /// <summary>
    /// Identifies the member whose default would generate the second largest liquidity exposure for the CCP under the scenario and for the relevant currency.
    /// </summary>
    [IsoId("_ox2EgLJPEeaYqc4G3TTwhA")]
    [DisplayName("Cover 2 Identification")]
    [IsoXmlTag("Cover2Id")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier Cover2Identification { get; init; }
}
