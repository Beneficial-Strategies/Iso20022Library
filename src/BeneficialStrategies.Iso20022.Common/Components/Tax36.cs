// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about tax.
/// </summary>
[IsoId("_VpKZIHVYEeiiHo4Gse0d2w")]
[DisplayName("Tax")]
public partial record Tax36
{
    #nullable enable
    
    /// <summary>
    /// Date or quarter of the tax year on which tax for the financial instrument is based or calculated.
    /// </summary>
    [IsoId("_Zlx_sHVYEeiiHo4Gse0d2w")]
    [DisplayName("Date Or Period")]
    [IsoXmlTag("DtOrPrd")]
    public required DateQuarter1Choice_ DateOrPeriod { get; init; } 
    
    /// <summary>
    /// Additional information about tax.
    /// </summary>
    [IsoId("_fQMk0HVYEeiiHo4Gse0d2w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
