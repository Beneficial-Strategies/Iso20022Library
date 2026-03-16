// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status information.
/// </summary>
[IsoId("_pxVPYSGaEeWKAaDJcYGKLw")]
[DisplayName("Account Management Status And Reason")]
public record AccountManagementStatusAndReason4
{
    /// <summary>
    /// Status of the account opening instruction or account modification instruction.
    /// </summary>
    [IsoId("_qOyAYSGaEeWKAaDJcYGKLw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status20Choice_ Status { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_qOyAYyGaEeWKAaDJcYGKLw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_koqw0VxQEeW8MLuBzR10cg")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ExistingAccountIdentification { get; init; }
}
