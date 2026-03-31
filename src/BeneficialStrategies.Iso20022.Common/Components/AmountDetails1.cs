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
[IsoId("_lw9aNPPrEeihCvvpsmGI2w")]
[DisplayName("Amount Details")]
public record AmountDetails1
{
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    [IsoId("_0bKk0PPrEeihCvvpsmGI2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TypeOfAmount18Code? Type { get; init; }

    /// <summary>
    /// Description of other type of amount or fee.
    /// </summary>
    [IsoId("_4W6osPPrEeihCvvpsmGI2w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_lw9aNvPrEeihCvvpsmGI2w")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether or not the amount is a credit or debit.
    /// </summary>
    [IsoId("_lw9aNfPrEeihCvvpsmGI2w")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_pYjpAP4dEeix6ug6HlF6IQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax33> Tax { get; init; } = [];
}
