// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the security pledged as collateral.
/// </summary>
[IsoId("__pEK0IxmEeap1-whlAlpOw")]
[DisplayName("Security Reuse Data")]
public record SecurityReuseData1
{
    /// <summary>
    /// Identifier of the security used as collateral.
    /// </summary>
    [IsoId("_IiLgkIxnEeap1-whlAlpOw")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier ISIN { get; init; }

    /// <summary>
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    [IsoId("_JXFIQIxnEeap1-whlAlpOw")]
    [DisplayName("Reuse Value")]
    [IsoXmlTag("ReuseVal")]
    public required ReuseValue1Choice_ ReuseValue { get; init; }
}
