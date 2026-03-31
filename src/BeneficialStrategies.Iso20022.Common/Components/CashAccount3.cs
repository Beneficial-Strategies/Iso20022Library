// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used for identifying an account.
/// </summary>
[IsoId("_SOo_09p-Ed-ak6NoX_4Aeg_1883841237")]
[DisplayName("Cash Account")]
public record CashAccount3
{
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOo_1Np-Ed-ak6NoX_4Aeg_-2145149427")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Nature, or use, of the account.
    /// </summary>
    [IsoId("_SOo_1dp-Ed-ak6NoX_4Aeg_-2145149041")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType3Code? Type { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held. ||Usage: Currency should only be used in case one and the same account number covers several currencies and the initiating party needs to identify which currency needs to be used for settlement on the account.
    /// </summary>
    [IsoId("_SOo_1tp-Ed-ak6NoX_4Aeg_-2145149859")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Name of the account, assigned by the account servicing institution in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: the account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_SOo_19p-Ed-ak6NoX_4Aeg_-2145149504")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
