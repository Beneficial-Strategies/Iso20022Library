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
[IsoId("_eTv33x9QEeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Option")]
public record CorporateActionOption192
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_eTv35x9QEeuFz_FaCzCLgQ")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_eTv37x9QEeuFz_FaCzCLgQ")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption43Choice_ OptionType { get; init; }

    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    [IsoId("_eTv39x9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instructed Quantity")]
    [IsoXmlTag("InstdQty")]
    public required Quantity40Choice_ InstructedQuantity { get; init; }
}
