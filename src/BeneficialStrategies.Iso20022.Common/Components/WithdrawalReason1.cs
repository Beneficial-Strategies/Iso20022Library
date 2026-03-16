// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the withdrawal reason code and optionally a withdrawal reason sub code.
/// </summary>
[IsoId("_t1jau4xnEeKdxfnzD2sqyA")]
[DisplayName("Withdrawal Reason")]
public record WithdrawalReason1
{
    /// <summary>
    /// Withdrawal reason expressed as a code.
    /// </summary>
    [IsoId("_t1jaxYxnEeKdxfnzD2sqyA")]
    [DisplayName("Withdrawal Reason Code")]
    [IsoXmlTag("WdrwlRsnCd")]
    public required WithdrawalReason1Code WithdrawalReasonCode { get; init; }

    /// <summary>
    /// Further withdrawal reason information expressed as a code.
    /// </summary>
    [IsoId("_t1javoxnEeKdxfnzD2sqyA")]
    [DisplayName("Withdrawal Reason Sub Code")]
    [IsoXmlTag("WdrwlRsnSubCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? WithdrawalReasonSubCode { get; init; }
}
