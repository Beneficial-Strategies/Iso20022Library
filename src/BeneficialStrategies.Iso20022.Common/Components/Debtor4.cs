// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the debtor.
/// </summary>
[IsoId("_m_eQEdgxEeipBO1pkKK6zg")]
[DisplayName("Debtor")]
public record Debtor4
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    [IsoId("_nKHZ0dgxEeipBO1pkKK6zg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification178Choice_? Debtor { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_nKIA4dgxEeipBO1pkKK6zg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public CashAccountIdentification7Choice_? AccountIdentification { get; init; }
}
