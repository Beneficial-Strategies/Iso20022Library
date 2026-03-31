// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_Rzq7G9p-Ed-ak6NoX_4Aeg_2054866212")]
[DisplayName("Investment Account")]
public record InvestmentAccount20
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Rzq7HNp-Ed-ak6NoX_4Aeg_2054866231")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification1? AccountIdentification { get; init; }

    /// <summary>
    /// Account type.
    /// </summary>
    [IsoId("_Rzq7Hdp-Ed-ak6NoX_4Aeg_2054866247")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public FundCashAccount2Code? Type { get; init; }

    /// <summary>
    /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
    /// </summary>
    [IsoId("_Rzq7Htp-Ed-ak6NoX_4Aeg_-1711849455")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; }
}
