// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price86.
/// </summary>
[IsoId("_DtaJoYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Price86")]
public partial record CorporateActionPrice86
{
    #nullable enable

    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat74Choice_? CashInLieuOfSharePrice { get; init; } 

    /// <summary>
    /// Maximum Cash To Instruct.
    /// </summary>
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 

    /// <summary>
    /// Minimum Cash To Instruct.
    /// </summary>
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 

    /// <summary>
    /// Minimum Multiple Cash To Instruct.
    /// </summary>
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 

    /// <summary>
    /// Over Subscription Deposit Price.
    /// </summary>
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat74Choice_? OverSubscriptionDepositPrice { get; init; } 

    
    #nullable disable
    
}
