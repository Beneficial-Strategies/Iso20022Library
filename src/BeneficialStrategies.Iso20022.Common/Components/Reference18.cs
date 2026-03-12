// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// References linked to the trade leg notification cancellation message.
/// </summary>
[IsoId("_QllXVdp-Ed-ak6NoX_4Aeg_2009700024")]
[DisplayName("Reference")]
public partial record Reference18
{
    #nullable enable
    
    /// <summary>
    /// Allocated by the central counterparty - central counterparty trade leg reference identification that uniquely identifies the trade.
    /// </summary>
    [IsoId("_QllXVtp-Ed-ak6NoX_4Aeg_705272339")]
    [DisplayName("Trade Leg Identification")]
    [IsoXmlTag("TradLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeLegIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the message previously sent by the central counterparty.
    /// </summary>
    [IsoId("_QllXV9p-Ed-ak6NoX_4Aeg_545464198")]
    [DisplayName("Previous Message Identification")]
    [IsoXmlTag("PrvsMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PreviousMessageIdentification { get; init; } 
    
    
    #nullable disable
    
}
