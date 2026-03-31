// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the type or operations code of a transaction entry.
/// </summary>
[IsoId("_TVbBstp-Ed-ak6NoX_4Aeg_-1809965694")]
[DisplayName("Bank Transaction Code Structure")]
public record BankTransactionCodeStructure5
{
    /// <summary>
    /// Specifies the business area of the underlying transaction.
    /// </summary>
    [IsoId("_TVbBs9p-Ed-ak6NoX_4Aeg_-1809965664")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ExternalBankTransactionDomain1Code Code { get; init; }

    /// <summary>
    /// Specifies the family and the sub-family of the bank transaction code, within a specific domain, in a structured and hierarchical format.
    /// </summary>
    [IsoId("_TVbBtNp-Ed-ak6NoX_4Aeg_-1809965570")]
    [DisplayName("Family")]
    [IsoXmlTag("Fmly")]
    public required BankTransactionCodeStructure6 Family { get; init; }
}
