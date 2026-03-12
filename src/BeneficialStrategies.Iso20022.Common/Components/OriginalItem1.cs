// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the original notification item, to which the cancellation advice refers.
/// </summary>
[IsoId("_P9gDptp-Ed-ak6NoX_4Aeg_1213364330")]
[DisplayName("Original Item")]
public partial record OriginalItem1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the original notification item.
    /// </summary>
    [IsoId("_P9gDp9p-Ed-ak6NoX_4Aeg_1213364361")]
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalItemIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification as assigned by the debtor to unambiguously identify the original underlying transaction to the creditor.
    /// </summary>
    [IsoId("_P9gDqNp-Ed-ak6NoX_4Aeg_1213364452")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    
    /// <summary>
    /// Amount of money expected to be credited to the account, as per the original notification to receive.
    /// </summary>
    [IsoId("_P9p0oNp-Ed-ak6NoX_4Aeg_1213364513")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Value date on which the account was originally expected to be credited.
    /// </summary>
    [IsoId("_P9p0odp-Ed-ak6NoX_4Aeg_1213364792")]
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedValueDate { get; init; } 
    
    
    #nullable disable
    
}
