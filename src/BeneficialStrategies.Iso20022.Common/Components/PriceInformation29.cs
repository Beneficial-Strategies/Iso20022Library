// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price Information29.
/// </summary>
[IsoId("_XMZxYYVYEe-Pv9KR9bv9IA")]
[DisplayName("Price Information29")]
public partial record PriceInformation29
{
    #nullable enable

    /// <summary>
    /// Quotation Date.
    /// </summary>
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    public DateAndDateTime2Choice_? QuotationDate { get; init; } 

    /// <summary>
    /// Source Of Price.
    /// </summary>
    [DisplayName("Source Of Price")]
    [IsoXmlTag("SrcOfPric")]
    public MarketIdentification98? SourceOfPrice { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice28Choice_ Type { get; init; } 

    /// <summary>
    /// Value.
    /// </summary>
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceRateOrAmountOrUnknown2Choice_ Value { get; init; } 

    /// <summary>
    /// Value Type.
    /// </summary>
    [DisplayName("Value Type")]
    [IsoXmlTag("ValTp")]
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 

    
    #nullable disable
    
}
