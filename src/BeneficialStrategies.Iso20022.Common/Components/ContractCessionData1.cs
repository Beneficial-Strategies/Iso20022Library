// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract cession data in structured form.
/// </summary>
[IsoId("_qkawwLb-Eeu9Cp6InX88Vw")]
[DisplayName("Contract Cession Data")]
public record ContractCessionData1
{
    /// <summary>
    /// The party to which the cession is made.
    /// </summary>
    [IsoId("_ON5xsLb_Eeu9Cp6InX88Vw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required TradeParty5 Party { get; init; }

    /// <summary>
    /// Number of the document under which the cession is made.
    /// </summary>
    [IsoId("_YPJNILb_Eeu9Cp6InX88Vw")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DocumentNumber { get; init; }

    /// <summary>
    /// Date of the document under which the cession is made.
    /// </summary>
    [IsoId("_begFELb_Eeu9Cp6InX88Vw")]
    [DisplayName("Document Date")]
    [IsoXmlTag("DocDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DocumentDate { get; init; }
}
