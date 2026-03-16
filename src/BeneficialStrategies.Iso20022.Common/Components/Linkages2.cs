// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_Qr1wU9p-Ed-ak6NoX_4Aeg_2141729136")]
[DisplayName("Linkages")]
public record Linkages2
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction.
    /// </summary>
    [IsoId("_Qr1wVNp-Ed-ak6NoX_4Aeg_2141729161")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition1Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_Qr1wVdp-Ed-ak6NoX_4Aeg_2141729178")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; }

    /// <summary>
    /// Reference to the linked transaction.
    /// </summary>
    [IsoId("_Qr1wVtp-Ed-ak6NoX_4Aeg_2142649246")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References1Choice_ Reference { get; init; }
}
