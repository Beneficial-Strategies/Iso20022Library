// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each package of currency control records.
/// </summary>
[IsoId("_Zza3wOFQEeSvv6t4Ka7B7A")]
[DisplayName("Currency Control Package Status")]
public record CurrencyControlPackageStatus1
{
    /// <summary>
    /// Unique and unambiguous identification of each package of transactions and optionally the entry/record within the package of transactions.
    /// </summary>
    [IsoId("_Zza3xeFQEeSvv6t4Ka7B7A")]
    [DisplayName("Package Identification")]
    [IsoXmlTag("PackgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PackageIdentification { get; init; }

    /// <summary>
    /// Defines the status of the reported transaction.
    /// </summary>
    [IsoId("_Zza3xOFQEeSvv6t4Ka7B7A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required StatisticalReportingStatus1Code Status { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_DB4cUQtPEeWkxvNyFrBT8Q")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<ValidationStatusReason1> StatusReason { get; init; } = [];

    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_YwSMsW5bEeW1GNjYvtuLyQ")]
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDateTime { get; init; }

    /// <summary>
    /// Provides the status of the individual records in the package.
    /// </summary>
    [IsoId("_12MosAtPEeWkxvNyFrBT8Q")]
    [DisplayName("Record Status")]
    [IsoXmlTag("RcrdSts")]
    public ValueList<CurrencyControlRecordStatus1> RecordStatus { get; init; } = [];
}
