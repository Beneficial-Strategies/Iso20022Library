// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report of the breakdown of the components for the capital requirement for central counterparty.
/// </summary>
[IsoId("_ltqioLIfEeaYqc4G3TTwhA")]
[DisplayName("Capital Requirement")]
public record CapitalRequirement1
{
    /// <summary>
    /// Indicates the capital necessary to cover the winding down or restructuring of activities.
    /// </summary>
    [IsoId("_xYZEYLIfEeaYqc4G3TTwhA")]
    [DisplayName("Winding Down Or Restructuring Risk")]
    [IsoXmlTag("WndgDwnOrRstrgRsk")]
    public required ActiveCurrencyAndAmount WindingDownOrRestructuringRisk { get; init; }

    /// <summary>
    /// Indicates the capital necessary to cover the overall operational and legal risks.
    /// </summary>
    [IsoId("_5dimkLIfEeaYqc4G3TTwhA")]
    [DisplayName("Operational And Legal Risk")]
    [IsoXmlTag("OprlAndLglRsk")]
    public required ActiveCurrencyAndAmount OperationalAndLegalRisk { get; init; }

    /// <summary>
    /// Indicates the capital necessary to cover credit risks not already covered by other financial resources, such as risks stemming from clearing activity.
    /// </summary>
    [IsoId("_9K1-wLIfEeaYqc4G3TTwhA")]
    [DisplayName("Credit Risk")]
    [IsoXmlTag("CdtRsk")]
    public required ActiveCurrencyAndAmount CreditRisk { get; init; }

    /// <summary>
    /// Indicates the capital necessary to cover counterparty credit risks not already covered by other financial resources, such as risks stemming from clearing activity.
    /// </summary>
    [IsoId("_Bn5Y4LIgEeaYqc4G3TTwhA")]
    [DisplayName("Counter Party Risk")]
    [IsoXmlTag("CntrPtyRsk")]
    public required ActiveCurrencyAndAmount CounterPartyRisk { get; init; }

    /// <summary>
    /// Indicates the capital necessary to cover counterparty market risks not already covered by other financial resources, such as risks stemming from clearing activity.
    /// </summary>
    [IsoId("_ELG8gLIgEeaYqc4G3TTwhA")]
    [DisplayName("Market Risk")]
    [IsoXmlTag("MktRsk")]
    public required ActiveCurrencyAndAmount MarketRisk { get; init; }

    /// <summary>
    /// Indicates the capital necessary to cover business risk.
    /// </summary>
    [IsoId("_GmI0gLIgEeaYqc4G3TTwhA")]
    [DisplayName("Business Risk")]
    [IsoXmlTag("BizRsk")]
    public required ActiveCurrencyAndAmount BusinessRisk { get; init; }

    /// <summary>
    /// Indicates the percentage above 100 percent of the CCP’s required capital requiring notification to the CCP’s National Competent Authority threshold.
    /// </summary>
    [IsoId("_bslp0LIgEeaYqc4G3TTwhA")]
    [DisplayName("Notification Buffer")]
    [IsoXmlTag("NtfctnBffr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? NotificationBuffer { get; init; }
}
