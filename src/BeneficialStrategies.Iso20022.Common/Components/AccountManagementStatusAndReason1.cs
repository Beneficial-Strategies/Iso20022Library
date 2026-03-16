// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of a account opening instruction or account modification instruction that was previously received.
/// </summary>
[IsoId("_RElAd9p-Ed-ak6NoX_4Aeg_-169847202")]
[DisplayName("Account Management Status And Reason")]
public record AccountManagementStatusAndReason1
{
    /// <summary>
    /// Status of the account opening instruction or account modification instruction.
    /// </summary>
    [IsoId("_REuxcNp-Ed-ak6NoX_4Aeg_-169845816")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountManagementStatus1Code Status { get; init; }

    /// <summary>
    /// Status of the order is rejected.
    /// </summary>
    [IsoId("_REuxcdp-Ed-ak6NoX_4Aeg_-168925198")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus5 Rejected { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_REuxctp-Ed-ak6NoX_4Aeg_58059420")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }
}
