// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option240.
/// </summary>
[IsoId("_oWlmK5BPEe-COKgew96POA")]
[DisplayName("Corporate Action Option240")]
public record CorporateActionOption240
{
    /// <summary>
    /// Cash Movement Details.
    /// </summary>
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption109> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Option Number.
    /// </summary>
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption33Choice_ OptionType { get; init; }

    /// <summary>
    /// Securities Movement Details.
    /// </summary>
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption80> SecuritiesMovementDetails { get; init; } = [];
}
