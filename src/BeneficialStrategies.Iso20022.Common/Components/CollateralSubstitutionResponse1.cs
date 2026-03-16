// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the accepted collateral substitution.
/// </summary>
[IsoId("_QnhRANp-Ed-ak6NoX_4Aeg_1142450106")]
[DisplayName("Collateral Substitution Response")]
public record CollateralSubstitutionResponse1
{
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_QnhRAdp-Ed-ak6NoX_4Aeg_-1599404554")]
    [DisplayName("Collateral Substitution Request Identification")]
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; }

    /// <summary>
    /// Provides the accepted collateral substitution amount.
    /// </summary>
    [IsoId("_QnhRAtp-Ed-ak6NoX_4Aeg_492922739")]
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; }
}
