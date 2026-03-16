// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Code of the underlying bank transaction.
/// </summary>
[IsoId("_TVRQuNp-Ed-ak6NoX_4Aeg_-1028115455")]
[DisplayName("Bank Transaction Code Structure")]
public record BankTransactionCodeStructure3
{
    /// <summary>
    /// Specifies the family within a domain.
    /// </summary>
    [IsoId("_TVRQudp-Ed-ak6NoX_4Aeg_-1028115424")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ExternalBankTransactionFamilyCode Code { get; init; }

    /// <summary>
    /// Specifies the sub-product family within a specific family.
    /// </summary>
    [IsoId("_TVRQutp-Ed-ak6NoX_4Aeg_-1028115394")]
    [DisplayName("Sub Family Code")]
    [IsoXmlTag("SubFmlyCd")]
    public required ExternalBankTransactionSubFamilyCode SubFamilyCode { get; init; }
}
