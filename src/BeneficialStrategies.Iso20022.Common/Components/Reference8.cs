// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the order.
/// </summary>
[IsoId("_Q_g6SNp-Ed-ak6NoX_4Aeg_-1002805207")]
[DisplayName("Reference")]
public partial record Reference8
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    [IsoId("_Q_qrQNp-Ed-ak6NoX_4Aeg_-963092701")]
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of indication of interest message.
    /// </summary>
    [IsoId("_Q_qrQdp-Ed-ak6NoX_4Aeg_-959397140")]
    [DisplayName("IOI Identification")]
    [IsoXmlTag("IOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IOIIdentification { get; init; } 
    
    /// <summary>
    /// Refers to the identification reference to the order being hit or taken. (Required for counter-order selection / Hit / Take Orders).
    /// </summary>
    [IsoId("_Q_qrQtp-Ed-ak6NoX_4Aeg_-1201889385")]
    [DisplayName("Reference Order Identification")]
    [IsoXmlTag("RefOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReferenceOrderIdentification { get; init; } 
    
    
    #nullable disable
    
}
