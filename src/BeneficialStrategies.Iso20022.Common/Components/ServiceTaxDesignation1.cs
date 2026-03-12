// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Designates the tax calculation to be applied on a service.
/// </summary>
[IsoId("_6RJWjpqlEeGSON8vddiWzQ_-263337197")]
[DisplayName("Service Tax Designation")]
public partial record ServiceTaxDesignation1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the taxable status of the service.
    /// </summary>
    [IsoId("_6RJWj5qlEeGSON8vddiWzQ_1442912136")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ServiceTaxDesignation1Code Code { get; init; } 
    
    /// <summary>
    /// Defines the tax region associated with the service. This element must be present if taxes are involved with any portion of the statement.
    /// </summary>
    [IsoId("_6RJWkJqlEeGSON8vddiWzQ_115283382")]
    [DisplayName("Region")]
    [IsoXmlTag("Rgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Region { get; init; } 
    
    /// <summary>
    /// Provides free form explanations of the various tax codes used within the statement.
    /// </summary>
    [IsoId("_6RSgcJqlEeGSON8vddiWzQ_1740386990")]
    [DisplayName("Tax Reason")]
    [IsoXmlTag("TaxRsn")]
    public TaxReason1? TaxReason { get; init; } 
    
    
    #nullable disable
    
}
