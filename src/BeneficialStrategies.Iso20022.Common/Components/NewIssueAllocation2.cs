// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
/// </summary>
[IsoId("_0BdZcQgpEeSUG-8hqXsVMQ")]
[DisplayName("New Issue Allocation")]
public record NewIssueAllocation2
{
    /// <summary>
    /// Indicates whether the investor is eligible to participate in the profits and losses from a new issue.
    /// </summary>
    [IsoId("_0cGHAwgpEeSUG-8hqXsVMQ")]
    [DisplayName("Restricted")]
    [IsoXmlTag("Rstrctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Restricted { get; init; }

    /// <summary>
    /// Reason for exemption.
    /// </summary>
    [IsoId("_0cGHBQgpEeSUG-8hqXsVMQ")]
    [DisplayName("Exempt Person Reason")]
    [IsoXmlTag("XmptPrsnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ExemptPersonReason { get; init; }

    /// <summary>
    /// Conditions applicable when the investor is covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_7u93sAgpEeSUG-8hqXsVMQ")]
    [DisplayName("De Minimus")]
    [IsoXmlTag("DeMnms")]
    public DeMinimus1Choice_? DeMinimus { get; init; }
}
