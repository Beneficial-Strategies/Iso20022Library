// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instalment amount details
/// </summary>
[IsoId("_h-7gIT2BEfCQAqQ9lolFUg")]
[DisplayName("Instalment Amount Data1")]
public record InstalmentAmountData1
{
    /// <summary>
    /// Instalment amount detail type. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_iBKUwT2BEfCQAqQ9lolFUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InstalmentAmountDetailsType4Code? Type { get; init; }

    /// <summary>
    /// Grace period sub type.
    /// </summary>
    [IsoId("_iBKUxT2BEfCQAqQ9lolFUg")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_iBKUxz2BEfCQAqQ9lolFUg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_iBKUyT2BEfCQAqQ9lolFUg")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Rate expressed as a percentage, that is, in hundredths, example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    [IsoId("_iBKUyz2BEfCQAqQ9lolFUg")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    public IsoPercentageRate? Percentage { get; init; }
}
