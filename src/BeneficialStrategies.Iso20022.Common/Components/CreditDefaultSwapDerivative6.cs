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
[IsoId("_sLE8ETGaEeiNp7s-9BkwiQ")]
[DisplayName("Credit Default Swap Derivative")]
public record CreditDefaultSwapDerivative6
{
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    [IsoId("_sdY0EjGaEeiNp7s-9BkwiQ")]
    [DisplayName("Underlying Credit Default Swap Identification")]
    [IsoXmlTag("UndrlygCdtDfltSwpId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? UnderlyingCreditDefaultSwapIdentification { get; init; }

    /// <summary>
    /// Identification of the reference obligation for a derivative on a credit default swap.
    /// </summary>
    [IsoId("_sdY0FDGaEeiNp7s-9BkwiQ")]
    [DisplayName("Obligation Identification")]
    [IsoXmlTag("OblgtnId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier ObligationIdentification { get; init; }

    /// <summary>
    /// Describes the single name specific details the derivative is being made on.
    /// </summary>
    [IsoId("_sdY0FjGaEeiNp7s-9BkwiQ")]
    [DisplayName("Single Name")]
    [IsoXmlTag("SnglNm")]
    public required CreditDefaultSwapSingleName2 SingleName { get; init; }
}
