// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_SVDJ0dp-Ed-ak6NoX_4Aeg_-76711377")]
[DisplayName("Value")]
public partial record Value
{
    #nullable enable
    
    /// <summary>
    /// Specifies the amount in the base currency of the receiver.
    /// </summary>
    [IsoId("_SVDJ0tp-Ed-ak6NoX_4Aeg_-37000375")]
    [DisplayName("Base Currency Item")]
    [IsoXmlTag("BaseCcyItm")]
    public required ActiveOrHistoricCurrencyAndAmount BaseCurrencyItem { get; init; } 
    
    /// <summary>
    /// Specifies the amount in another currency.
    /// </summary>
    [IsoId("_SVDJ09p-Ed-ak6NoX_4Aeg_249291013")]
    [DisplayName("Alternate Currency Item")]
    [IsoXmlTag("AltrnCcyItm")]
    public ValueList<ActiveOrHistoricCurrencyAndAmount> AlternateCurrencyItem { get; init; } = new ValueList<ActiveOrHistoricCurrencyAndAmount>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SVDJ09p-Ed-ak6NoX_4Aeg_249291013
    
    
    #nullable disable
    
}
