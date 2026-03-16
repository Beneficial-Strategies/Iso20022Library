// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of advice to report back for the transaction.
/// </summary>
[IsoId("_5ZNFsNolEembTrt_WixjyQ")]
[DisplayName("Advice Type")]
public record AdviceType1
{
    /// <summary>
    /// Type of credit advice requested.
    /// </summary>
    [IsoId("_bQTjANomEembTrt_WixjyQ")]
    [DisplayName("Credit Advice")]
    [IsoXmlTag("CdtAdvc")]
    public AdviceType1Choice_? CreditAdvice { get; init; }

    /// <summary>
    /// Type de debit advice requested.
    /// </summary>
    [IsoId("_fU3koNomEembTrt_WixjyQ")]
    [DisplayName("Debit Advice")]
    [IsoXmlTag("DbtAdvc")]
    public AdviceType1Choice_? DebitAdvice { get; init; }
}
