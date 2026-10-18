// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAdditionalDateTime1"/>
[Description(@"Series of additional dates related to the payment.")]
[IsoId("_e2UX0G9ZEe-Mlpx0N5T4gg")]
[DisplayName("Additional Date Time1")]
public partial record AdditionalDateTime1
{
    /// <inheritdoc cref="IAdditionalDateTime1.AcceptanceDateTime"/>
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IAdditionalDateTime1.ExpiryDateTime"/>
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public IsoISODateTime? ExpiryDateTime { get; init; }

    /// <inheritdoc cref="IAdditionalDateTime1.PoolingAdjustmentDate"/>
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    public IsoISODate? PoolingAdjustmentDate { get; init; }
}
