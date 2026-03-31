// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting derivatives on a single name.
/// </summary>
[IsoId("_NdTzAX5fEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Derivative")]
public record CreditDefaultSwapDerivative4
{
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    [IsoId("_Nmrxc35fEea2k7EBUopqxw")]
    [DisplayName("Underlying Name Identification")]
    [IsoXmlTag("UndrlygNmId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? UnderlyingNameIdentification { get; init; }

    /// <summary>
    /// Identification of the reference obligation for a derivative on a credit default swap.
    /// </summary>
    [IsoId("_NmrxdX5fEea2k7EBUopqxw")]
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier ObligationIdentification { get; init; }

    /// <summary>
    /// Describes the single name specific details the derivative is being made on.
    /// </summary>
    [IsoId("_Nmrxd35fEea2k7EBUopqxw")]
    [DisplayName("Single Name")]
    [IsoXmlTag("SnglNm")]
    public required CreditDefaultSwapSingleName2 SingleName { get; init; }
}
