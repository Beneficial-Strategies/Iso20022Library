// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contain information related promotion program applied to the transaction.
/// </summary>
[IsoId("_PaoEcXn7EfCmC4yYaU27Kg")]
[DisplayName("Promotion Data1")]
public record PromotionData1
{
    /// <summary>
    /// Identify the type of entity offering the promotion.
    /// </summary>
    [IsoId("_ya0bUHn8EfCmC4yYaU27Kg")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public ATICAPartyType1Code? Provider { get; init; }

    /// <summary>
    /// Type of promotion.
    /// </summary>
    [IsoId("_PdFikXn7EfCmC4yYaU27Kg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Detail description of the promotion.
    /// </summary>
    [IsoId("_PdFilXn7EfCmC4yYaU27Kg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Unique code assigned to the promotion.
    /// </summary>
    [IsoId("_PdFimXn7EfCmC4yYaU27Kg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public IsoMax35Text? Code { get; init; }

    /// <summary>
    /// Date and time when promotion begins.
    /// </summary>
    [IsoId("_92rlMHn9EfCmC4yYaU27Kg")]
    [DisplayName("Start")]
    [IsoXmlTag("Start")]
    public IsoISODateTime? Start { get; init; }

    /// <summary>
    /// Date and time when promotion ends.
    /// </summary>
    [IsoId("_M-9L4Hn-EfCmC4yYaU27Kg")]
    [DisplayName("End")]
    [IsoXmlTag("End")]
    public IsoISODateTime? End { get; init; }

    /// <summary>
    /// Contains amount of the promotion.
    /// </summary>
    [IsoId("_PdFinXn7EfCmC4yYaU27Kg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Describes how the promotion is applied to the transaction.
    /// </summary>
    [IsoId("_FLyDIHoBEfCmC4yYaU27Kg")]
    [DisplayName("Redemption Method")]
    [IsoXmlTag("RedMtd")]
    public IsoMax35Text? RedemptionMethod { get; init; }

    /// <summary>
    /// The channel through which the promotion is offered.
    /// </summary>
    [IsoId("_weI58HoBEfCmC4yYaU27Kg")]
    [DisplayName("Channel")]
    [IsoXmlTag("Chanl")]
    public IsoMax35Text? Channel { get; init; }

    /// <summary>
    /// A classification of the promotion based on the type of goods or services involved.
    /// </summary>
    [IsoId("_5FETgHoBEfCmC4yYaU27Kg")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public IsoMax35Text? Category { get; init; }

    /// <summary>
    /// Specifies whether this promotion can be combined with other promotions in the same transaction.
    /// </summary>
    [IsoId("__zCAUHoBEfCmC4yYaU27Kg")]
    [DisplayName("Stackable")]
    [IsoXmlTag("Stckbl")]
    public IsoTrueFalseIndicator? Stackable { get; init; }

    /// <summary>
    /// A URL linking to the rules or full terms and conditions of the promotion.
    /// </summary>
    [IsoId("_HrTkIHoCEfCmC4yYaU27Kg")]
    [DisplayName("Terms URL")]
    [IsoXmlTag("TermsURL")]
    public IsoMax256Text? TermsURL { get; init; }
}
