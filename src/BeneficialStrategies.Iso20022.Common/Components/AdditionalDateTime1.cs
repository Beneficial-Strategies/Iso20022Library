// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional Date Time1.
/// </summary>
[IsoId("_e2UX0G9ZEe-Mlpx0N5T4gg")]
[DisplayName("Additional Date Time1")]
public partial record AdditionalDateTime1
{
    #nullable enable

    /// <summary>
    /// Acceptance Date Time.
    /// </summary>
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; } 

    /// <summary>
    /// Expiry Date Time.
    /// </summary>
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public IsoISODateTime? ExpiryDateTime { get; init; } 

    /// <summary>
    /// Pooling Adjustment Date.
    /// </summary>
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    public IsoISODate? PoolingAdjustmentDate { get; init; } 

    
    #nullable disable
    
}
