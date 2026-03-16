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
[IsoId("_8vNzgUQSEealVdmlTDXWkw")]
[DisplayName("Account Management Status And Reason")]
public record AccountManagementStatusAndReason5
{
    /// <summary>
    /// Status of the account management instruction that was previously received.
    /// </summary>
    [IsoId("_9H6nYUQSEealVdmlTDXWkw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status25Choice_ Status { get; init; }

    /// <summary>
    /// Reason for the status of the account management instruction.
    /// </summary>
    [IsoId("_cPlMMGBdEeaR1OOiVxm3Gg")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<AcceptedStatusReason1Choice_> StatusReason { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_9H6nY0QSEealVdmlTDXWkw")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }

    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_9H6nZUQSEealVdmlTDXWkw")]
    [DisplayName("Existing Account Identification")]
    [IsoXmlTag("ExstgAcctId")]
    public ValueList<Account23> ExistingAccountIdentification { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_CTz6oEy9EeafiMTDrtSnyw")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; }

    /// <summary>
    /// Status of the account.
    /// </summary>
    [IsoId("_EJC98Ey9EeafiMTDrtSnyw")]
    [DisplayName("Account Status")]
    [IsoXmlTag("AcctSts")]
    public AccountStatus2? AccountStatus { get; init; }

    /// <summary>
    /// Specifies the account is blocked and other factors for the blocked account.
    /// </summary>
    [IsoId("_2AZVkV1BEeagR5I1rq5oaw")]
    [DisplayName("Blocked Status")]
    [IsoXmlTag("BlckdSts")]
    public BlockedStatusReason2Choice_? BlockedStatus { get; init; }

    /// <summary>
    /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
    /// </summary>
    [IsoId("_tfSXcWBzEeaHEJD5P6-ccw")]
    [DisplayName("FATCA Reporting Date")]
    [IsoXmlTag("FATCARptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FATCAReportingDate { get; init; }

    /// <summary>
    /// Date provided by the account owner to inform the account servicer of the date on which the holdings must be reported before the account is subsequently closed.
    /// </summary>
    [IsoId("_VrHMUXXXEeaH0fB6yD0LBA")]
    [DisplayName("CRS Reporting Date")]
    [IsoXmlTag("CRSRptgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CRSReportingDate { get; init; }
}
