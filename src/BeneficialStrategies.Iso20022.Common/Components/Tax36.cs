// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about tax.
/// </summary>
[IsoId("_VpKZIHVYEeiiHo4Gse0d2w")]
[DisplayName("Tax")]
public record Tax36
{
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
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
