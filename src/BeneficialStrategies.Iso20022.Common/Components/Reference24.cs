// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference24.
/// </summary>
[IsoId("_Pw59aYcSEe-U27oWwgmhCQ")]
[DisplayName("Reference24")]
public partial record Reference24
{
    #nullable enable

    /// <summary>
    /// Net Position Identification.
    /// </summary>
    [DisplayName("Net Position Identification")]
    [IsoXmlTag("NetPosId")]
    public IsoMax35Text? NetPositionIdentification { get; init; } 

    /// <summary>
    /// Trade Leg Notification Identification.
    /// </summary>
    [DisplayName("Trade Leg Notification Identification")]
    [IsoXmlTag("TradLegNtfctnId")]
    public ValueList<TradeLegNotificationIdentification1Choice_> TradeLegNotificationIdentification { get; init; } = [];

    
    #nullable disable
    
}
