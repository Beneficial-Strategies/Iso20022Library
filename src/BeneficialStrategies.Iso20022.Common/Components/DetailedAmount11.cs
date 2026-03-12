// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fees between acquirer and issuer.
/// </summary>
[IsoId("_YbLAAYKVEeSIRfXNMHH5mQ")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount11
{
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_Trp9AIN-EeSNofOeou9G3A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount7Code Type { get; init; } 
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_YpdTo4KVEeSIRfXNMHH5mQ")]
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalType { get; init; } 
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_YpdTpYKVEeSIRfXNMHH5mQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection41 Amount { get; init; } 
    
    /// <summary>
    /// Original value of the amount.
    /// </summary>
    [IsoId("_YpdTp4KVEeSIRfXNMHH5mQ")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public AmountAndDirection41? OriginalAmount { get; init; } 
    
    
    #nullable disable
    
}
