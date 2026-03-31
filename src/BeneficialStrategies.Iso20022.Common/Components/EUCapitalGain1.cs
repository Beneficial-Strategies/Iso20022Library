// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the EU capital gain.
/// </summary>
[IsoId("_VMU49tp-Ed-ak6NoX_4Aeg_-2038636441")]
[DisplayName("EU Capital Gain")]
public record EUCapitalGain1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VMU499p-Ed-ak6NoX_4Aeg_-1998002835")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required EUCapitalGain1Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VMU4-Np-Ed-ak6NoX_4Aeg_-1998002817")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
