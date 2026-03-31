// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action quantities.
/// </summary>
[IsoId("_KBVBYdBnEee0mNiKMkpGNQ")]
[DisplayName("Corporate Action Quantity")]
public record CorporateActionQuantity10
{
    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_KSlwg9BnEee0mNiKMkpGNQ")]
    [DisplayName("Base Denomination")]
    [IsoXmlTag("BaseDnmtn")]
    public FinancialInstrumentQuantity22Choice_? BaseDenomination { get; init; }

    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_KSlwi9BnEee0mNiKMkpGNQ")]
    [DisplayName("Incremental Denomination")]
    [IsoXmlTag("IncrmtlDnmtn")]
    public FinancialInstrumentQuantity22Choice_? IncrementalDenomination { get; init; }
}
