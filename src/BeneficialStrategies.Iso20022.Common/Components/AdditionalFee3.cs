// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional Fee3.
/// </summary>
[IsoId("_jAIIcG6VEe6DxcrvCrq6hQ")]
[DisplayName("Additional Fee3")]
public record AdditionalFee3
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType32Code? Assigner { get; init; }

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Descriptor.
    /// </summary>
    [DisplayName("Descriptor")]
    [IsoXmlTag("Dscrptr")]
    public IsoMax35Text? Descriptor { get; init; }

    /// <summary>
    /// Other Assigner.
    /// </summary>
    [DisplayName("Other Assigner")]
    [IsoXmlTag("OthrAssgnr")]
    public IsoMax35Text? OtherAssigner { get; init; }

    /// <summary>
    /// Other Type.
    /// </summary>
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Program.
    /// </summary>
    [DisplayName("Program")]
    [IsoXmlTag("Prgm")]
    public IsoMax35Text? Program { get; init; }

    /// <summary>
    /// Reconciliation Amount.
    /// </summary>
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; }

    /// <summary>
    /// Reconciliation Currency.
    /// </summary>
    [DisplayName("Reconciliation Currency")]
    [IsoXmlTag("RcncltnCcy")]
    public ISO3NumericCurrencyCode? ReconciliationCurrency { get; init; }

    /// <summary>
    /// Reconciliation Effective Exchange Rate.
    /// </summary>
    [DisplayName("Reconciliation Effective Exchange Rate")]
    [IsoXmlTag("RcncltnFctvXchgRate")]
    public IsoBaseOne25Rate? ReconciliationEffectiveExchangeRate { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount21Code Type { get; init; }
}
