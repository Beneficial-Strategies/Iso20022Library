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
[IsoId("_Urs4Jtp-Ed-ak6NoX_4Aeg_2065837485")]
[DisplayName("Debtor")]
public record Debtor2
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    [IsoId("_Urs4J9p-Ed-ak6NoX_4Aeg_2065837712")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification2Choice_? Debtor { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Urs4KNp-Ed-ak6NoX_4Aeg_2065837762")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentificationAndName3 AccountIdentification { get; init; }

    /// <summary>
    /// Financial institution that receives the payment transaction from the account owner, or other authorised party, and processes the instruction.
    /// </summary>
    [IsoId("_Ur2CENp-Ed-ak6NoX_4Aeg_2065837720")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public required FinancialInstitutionIdentification3Choice_ FirstAgent { get; init; }
}
