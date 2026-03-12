// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the requested settlement time(s) of the payment instruction.
/// </summary>
[IsoId("_QIrY6dp-Ed-ak6NoX_4Aeg_2050617089")]
[DisplayName("Settlement Time Request")]
public partial record SettlementTimeRequest2
{
    #nullable enable
    
    /// <summary>
    /// Time by which the amount of money must be credited, with confirmation, to the CLS Bank&apos;s account at the central bank.|Usage: Time must be expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QIrY6tp-Ed-ak6NoX_4Aeg_2050617120")]
    [DisplayName("CLS Time")]
    [IsoXmlTag("CLSTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CLSTime { get; init; } 
    
    /// <summary>
    /// Time until when the payment may be settled.
    /// </summary>
    [IsoId("_QIrY69p-Ed-ak6NoX_4Aeg_2142970270")]
    [DisplayName("Till Time")]
    [IsoXmlTag("TillTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? TillTime { get; init; } 
    
    /// <summary>
    /// Time as from when the payment may be settled.
    /// </summary>
    [IsoId("_QIrY7Np-Ed-ak6NoX_4Aeg_2123575201")]
    [DisplayName("From Time")]
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? FromTime { get; init; } 
    
    /// <summary>
    /// Time by when the payment must be settled to avoid rejection.
    /// </summary>
    [IsoId("_QI1J4Np-Ed-ak6NoX_4Aeg_2138351566")]
    [DisplayName("Reject Time")]
    [IsoXmlTag("RjctTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? RejectTime { get; init; } 
    
    
    #nullable disable
    
}
