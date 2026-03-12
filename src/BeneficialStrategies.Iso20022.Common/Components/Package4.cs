// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Combination of two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement.
/// </summary>
[IsoId("_8GlqARZtEe27wrM4RUjLog")]
[DisplayName("Package")]
public partial record Package4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the identifier determined by the reporting counterparty to connect:|- two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement,|- or two or more reports pertaining to the same transaction whenever jurisdictional reporting requirement does not allow the transaction to be reported with a single report to TRs.||Usage:|Where the package identifier is not known when a new transaction is reported, the package identifier is updated as it becomes available.
    /// |
    /// </summary>
    [IsoId("_8IV9gRZtEe27wrM4RUjLog")]
    [DisplayName("Complex Trade Identification")]
    [IsoXmlTag("CmplxTradId")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? ComplexTradeIdentification { get; init; } 
    
    /// <summary>
    /// Identifier which is used to link the near leg and far leg of an FX swap per current industry practice. This identifier could distingish FX swap from other packaged transactions identified by ComplexTradeIdentification.
    /// </summary>
    [IsoId("_A9OBwBZuEe27wrM4RUjLog")]
    [DisplayName("FX Swap Link Identification")]
    [IsoXmlTag("FxSwpLkId")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? FXSwapLinkIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the traded price of the entire package in which the reported derivative transaction is a component.
    /// </summary>
    [IsoId("_8IV9gxZtEe27wrM4RUjLog")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    
    /// <summary>
    /// Indicates the traded price (expressed as a difference between two reference prices) of the entire package in which the reported derivative transaction is a component.
    /// </summary>
    [IsoId("_8IV9hxZtEe27wrM4RUjLog")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public SecuritiesTransactionPrice20Choice_? Spread { get; init; } 
    
    
    #nullable disable
    
}
