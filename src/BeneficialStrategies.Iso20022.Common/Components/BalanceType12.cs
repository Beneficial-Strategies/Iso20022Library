// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the balance type and sub-type.
/// </summary>
[IsoId("_SYoCRtp-Ed-ak6NoX_4Aeg_833472278")]
[DisplayName("Balance Type")]
public record BalanceType12
{
    /// <summary>
    /// Coded or proprietary format balance type.
    /// </summary>
    [IsoId("_SYoCR9p-Ed-ak6NoX_4Aeg_833472741")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required BalanceType5Choice_ CodeOrProprietary { get; init; }

    /// <summary>
    /// Specifies the balance sub-type.
    /// </summary>
    [IsoId("_SYoCSNp-Ed-ak6NoX_4Aeg_834396694")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public BalanceSubType1Choice_? SubType { get; init; }
}
