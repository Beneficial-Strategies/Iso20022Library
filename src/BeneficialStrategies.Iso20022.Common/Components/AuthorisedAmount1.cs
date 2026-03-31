// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the amount reserved to cover the anticipated charges associated with the lodging stay.
/// </summary>
[IsoId("_jl_RBPcYEeiW-auGnDPZIw")]
[DisplayName("Authorised Amount")]
public record AuthorisedAmount1
{
    /// <summary>
    /// Date and time of the amount authorized
    /// </summary>
    [IsoId("_jl_RBvcYEeiW-auGnDPZIw")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_jl_RBfcYEeiW-auGnDPZIw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Contains additional information about the authorized amount.
    /// </summary>
    [IsoId("_jl_RB_cYEeiW-auGnDPZIw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
