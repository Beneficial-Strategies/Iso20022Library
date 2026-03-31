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
[IsoId("_SPO1t9p-Ed-ak6NoX_4Aeg_16777197")]
[DisplayName("Cash Account")]
public record CashAccount13
{
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SPO1uNp-Ed-ak6NoX_4Aeg_16777809")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Nature, or use, of the account.
    /// </summary>
    [IsoId("_SPO1udp-Ed-ak6NoX_4Aeg_24163093")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2? Type { get; init; }

    /// <summary>
    /// Identification of the currency in which the account is held.
    /// </summary>
    [IsoId("_SPO1utp-Ed-ak6NoX_4Aeg_16777636")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Name of the account, assigned by the account servicing institution in agreement with the account owner in order to provide an additional means of identification of the account.||Usage: the account name is different from the account owner name. The account name is used in certain user communities to provide a means of identifying the account, in addition to the account owner&apos;s identity and the account number.
    /// </summary>
    [IsoId("_SPYmsNp-Ed-ak6NoX_4Aeg_16777714")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_SPYmsdp-Ed-ak6NoX_4Aeg_180238825")]
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PartyIdentification8? Owner { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SPYmstp-Ed-ak6NoX_4Aeg_502550147")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification3? Servicer { get; init; }
}
