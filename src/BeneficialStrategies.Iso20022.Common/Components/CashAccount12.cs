// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_SP1Sodp-Ed-ak6NoX_4Aeg_-1055683398")]
[DisplayName("Cash Account")]
public record CashAccount12
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SP1Sotp-Ed-ak6NoX_4Aeg_-1055683380")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccountIdentification1Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_SP1So9p-Ed-ak6NoX_4Aeg_-1055683208")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Name { get; init; }

    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    [IsoId("_SP1SpNp-Ed-ak6NoX_4Aeg_-1055683148")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType1Code? Type { get; init; }

    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    [IsoId("_SP1Spdp-Ed-ak6NoX_4Aeg_244741598")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_SP1Sptp-Ed-ak6NoX_4Aeg_-1055683191")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_SP1Sp9p-Ed-ak6NoX_4Aeg_-1055683226")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AccountStatus1Code Status { get; init; }
}
