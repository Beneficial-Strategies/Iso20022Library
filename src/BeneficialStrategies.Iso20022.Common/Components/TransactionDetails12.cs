// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_Ub5hltp-Ed-ak6NoX_4Aeg_1658880948")]
[DisplayName("Transaction Details")]
public record TransactionDetails12
{
    /// <summary>
    /// Reference to the message advised to be cancelled by the account servicer.
    /// </summary>
    [IsoId("_Ub5hl9p-Ed-ak6NoX_4Aeg_1874113211")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References3Choice_ Reference { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Ub5hmNp-Ed-ak6NoX_4Aeg_-731795310")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Ub5hmdp-Ed-ak6NoX_4Aeg_-2104744963")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }
}
