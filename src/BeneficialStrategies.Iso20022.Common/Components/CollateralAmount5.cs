// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Collateral and settlement related amounts.
/// </summary>
[IsoId("__fRWYOCuEei2UYJ62ws-Fw")]
[DisplayName("Collateral Amount")]
public record CollateralAmount5
{
    /// <summary>
    /// Margin amount needed when the instruction reported creates an exposure.
    /// </summary>
    [IsoId("_MMFAMOCvEei2UYJ62ws-Fw")]
    [DisplayName("Required Margin")]
    [IsoXmlTag("ReqrdMrgn")]
    public AmountAndDirection44? RequiredMargin { get; init; }

    /// <summary>
    /// Amount which is collateralised.
    /// Feedback
    /// </summary>
    [IsoId("_Vu8dkOCvEei2UYJ62ws-Fw")]
    [DisplayName("Collateralised")]
    [IsoXmlTag("Collsd")]
    public AmountAndDirection44? Collateralised { get; init; }

    /// <summary>
    /// Outstanding amount to be covered, collateralised.
    /// </summary>
    [IsoId("_eh0ocOCvEei2UYJ62ws-Fw")]
    [DisplayName("Remaining Collateralised")]
    [IsoXmlTag("RmngCollsd")]
    public AmountAndDirection44? RemainingCollateralised { get; init; }

    /// <summary>
    /// Amount effectively settled and which will be credited to/debited from the account owner&apos;s position.
    /// </summary>
    [IsoId("_jsfWgOCvEei2UYJ62ws-Fw")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public AmountAndDirection44? Settled { get; init; }

    /// <summary>
    /// Amount due to be settled.
    /// </summary>
    [IsoId("_sbiKQOCvEei2UYJ62ws-Fw")]
    [DisplayName("Remaining Settlement")]
    [IsoXmlTag("RmngSttlm")]
    public AmountAndDirection44? RemainingSettlement { get; init; }
}
