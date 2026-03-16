// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an amount.
/// </summary>
[IsoId("_95C-gXltEeG7BsjMvd1mEw_-215420241")]
[DisplayName("Undertaking Amount")]
public record UndertakingAmount2
{
    /// <summary>
    /// Choice of amounts.
    /// </summary>
    [IsoId("_95C-gnltEeG7BsjMvd1mEw_973191229")]
    [DisplayName("Amount Choice")]
    [IsoXmlTag("AmtChc")]
    public required Amount1Choice_ AmountChoice { get; init; }

    /// <summary>
    /// Additional information concerning the amended amount.
    /// </summary>
    [IsoId("_95C-g3ltEeG7BsjMvd1mEw_-1235765635")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
