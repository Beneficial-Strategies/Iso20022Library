// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the service to be billed.
/// </summary>
[IsoId("_6PWmxpqlEeGSON8vddiWzQ_-1512913674")]
[DisplayName("Billing Service Identification")]
public partial record BillingServiceIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Financial institution&apos;s own, internal service identification code, different from the common code.|Usage: The financial institution own code is used to uniquely identify the service within the financial institution.
    /// </summary>
    [IsoId("_6PWmx5qlEeGSON8vddiWzQ_1784981269")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Defines the financial institution sub-service identification if the financial institution service identification code is used for more than one service.
    /// </summary>
    [IsoId("_6PWmyJqlEeGSON8vddiWzQ_674069850")]
    [DisplayName("Sub Service")]
    [IsoXmlTag("SubSvc")]
    public BillingSubServiceIdentification1? SubService { get; init; } 
    
    /// <summary>
    /// Specifies further details to describe the financial institution service description, which is not the standard description related to the common code.
    /// </summary>
    [IsoId("_6PgXwJqlEeGSON8vddiWzQ_559746653")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Description { get; init; } 
    
    
    #nullable disable
    
}
