// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment fund transactions that result in cash movements into a fund, eg, subscription, switch-in.
/// </summary>
[IsoId("_UwBXdNp-Ed-ak6NoX_4Aeg_-452894639")]
[DisplayName("Investment Fund Transaction In Type")]
public record InvestmentFundTransactionInType1
{
    /// <summary>
    /// Type of transaction, expressed as a code.
    /// </summary>
    [IsoId("_UwBXddp-Ed-ak6NoX_4Aeg_19951473")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required InvestmentFundTransactionInType3Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of transaction.
    /// </summary>
    [IsoId("_UwBXdtp-Ed-ak6NoX_4Aeg_63354155")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
