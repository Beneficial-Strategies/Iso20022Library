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
[IsoId("_TVbBtdp-Ed-ak6NoX_4Aeg_-549688189")]
[DisplayName("Bank Transaction Code Structure")]
public record BankTransactionCodeStructure4
{
    /// <summary>
    /// Set of elements used to provide the domain, the family and the sub-family of the bank transaction code, in a structured and hierarchical format.||Usage: If a specific family or sub-family code cannot be provided, the generic family code defined for the domain or the generic sub-family code defined for the family should be provided.
    /// </summary>
    [IsoId("_TVbBttp-Ed-ak6NoX_4Aeg_-549687856")]
    [DisplayName("Domain")]
    [IsoXmlTag("Domn")]
    public BankTransactionCodeStructure5? Domain { get; init; }

    /// <summary>
    /// Bank transaction code in a proprietary form, as defined by the issuer.
    /// </summary>
    [IsoId("_TVbBt9p-Ed-ak6NoX_4Aeg_-549687485")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryBankTransactionCodeStructure1? Proprietary { get; init; }
}
