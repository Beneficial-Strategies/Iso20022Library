// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_jbRUkVN1EfC0lMwgjvMClw")]
[DisplayName("Amount And Tax1")]
public record AmountAndTax1
{
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    [IsoId("_jd_RYVN1EfC0lMwgjvMClw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TypeOfAmount24Code? Type { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_jd_RZVN1EfC0lMwgjvMClw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit.
    /// </summary>
    [IsoId("_jd_RZ1N1EfC0lMwgjvMClw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_jd_RaVN1EfC0lMwgjvMClw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];
}
