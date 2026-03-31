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
[IsoId("_TVRQu9p-Ed-ak6NoX_4Aeg_1515822708")]
[DisplayName("Bank Transaction Code Structure")]
public record BankTransactionCodeStructure6
{
    /// <summary>
    /// Specifies the family within a domain.
    /// </summary>
    [IsoId("_TVbBsNp-Ed-ak6NoX_4Aeg_1515822740")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ExternalBankTransactionFamily1Code Code { get; init; }

    /// <summary>
    /// Specifies the sub-product family within a specific family.
    /// </summary>
    [IsoId("_TVbBsdp-Ed-ak6NoX_4Aeg_1515822800")]
    [DisplayName("Sub Family Code")]
    [IsoXmlTag("SubFmlyCd")]
    public required ExternalBankTransactionSubFamily1Code SubFamilyCode { get; init; }
}
