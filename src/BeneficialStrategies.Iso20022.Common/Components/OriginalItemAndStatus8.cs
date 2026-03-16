// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Item And Status8.
/// </summary>
[IsoId("_8iQgrzEsEe6GxLzpkVnWYg")]
[DisplayName("Original Item And Status8")]
public partial record OriginalItemAndStatus8
{
    #nullable enable

    /// <summary>
    /// Additional Status Information.
    /// </summary>
    [DisplayName("Additional Status Information")]
    [IsoXmlTag("AddtlStsInf")]
    public IsoMax105Text? AdditionalStatusInformation { get; init; } 

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Expected Value Date.
    /// </summary>
    [DisplayName("Expected Value Date")]
    [IsoXmlTag("XpctdValDt")]
    public IsoISODate? ExpectedValueDate { get; init; } 

    /// <summary>
    /// Item Status.
    /// </summary>
    [DisplayName("Item Status")]
    [IsoXmlTag("ItmSts")]
    public required NotificationStatus3Code ItemStatus { get; init; } 

    /// <summary>
    /// Original End To End Identification.
    /// </summary>
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 

    /// <summary>
    /// Original Item Identification.
    /// </summary>
    [DisplayName("Original Item Identification")]
    [IsoXmlTag("OrgnlItmId")]
    public required IsoMax35Text OriginalItemIdentification { get; init; } 

    /// <summary>
    /// Original Item Reference.
    /// </summary>
    [DisplayName("Original Item Reference")]
    [IsoXmlTag("OrgnlItmRef")]
    public OriginalItemReference7? OriginalItemReference { get; init; } 

    /// <summary>
    /// Original UETR.
    /// </summary>
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 

    
    #nullable disable
    
}
