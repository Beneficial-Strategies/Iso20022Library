// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of each package of currency control records.
/// </summary>
[IsoId("_9WLb9248EeiU9cctagi5ow")]
[DisplayName("Currency Control Package Status")]
public partial record CurrencyControlPackageStatus2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of each package of transactions and optionally the entry/record within the package of transactions.
    /// </summary>
    [IsoId("_9gw7UW48EeiU9cctagi5ow")]
    [DisplayName("Package Identification")]
    [IsoXmlTag("PackgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text PackageIdentification { get; init; } 
    
    /// <summary>
    /// Defines the status of the reported transaction.
    /// </summary>
    [IsoId("_9gw7U248EeiU9cctagi5ow")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required StatisticalReportingStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_9gw7VW48EeiU9cctagi5ow")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValidationStatusReason2? StatusReason { get; init; } 
    
    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_9gw7V248EeiU9cctagi5ow")]
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDateTime { get; init; } 
    
    /// <summary>
    /// Provides the status of the individual records in the package.
    /// </summary>
    [IsoId("_9gw7WW48EeiU9cctagi5ow")]
    [DisplayName("Record Status")]
    [IsoXmlTag("RcrdSts")]
    public CurrencyControlRecordStatus2? RecordStatus { get; init; } 
    
    
    #nullable disable
    
}
