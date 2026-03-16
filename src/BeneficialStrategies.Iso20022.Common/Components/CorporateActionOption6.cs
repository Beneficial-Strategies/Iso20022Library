// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_UFZtINp-Ed-ak6NoX_4Aeg_-404360191")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption6
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UFZtIdp-Ed-ak6NoX_4Aeg_-404360189")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UFZtItp-Ed-ak6NoX_4Aeg_-404360138")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption4Choice_ OptionType { get; init; }

    /// <summary>
    /// Specifies whether the quantity of financial instrument is a quantity of securities instructed or a quantity to receive.
    /// </summary>
    [IsoId("_UFZtI9p-Ed-ak6NoX_4Aeg_1387568741")]
    [DisplayName("Instructed Or Quantity To Receive")]
    [IsoXmlTag("InstdOrQtyToRcv")]
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; }
}
