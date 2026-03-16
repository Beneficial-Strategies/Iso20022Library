// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the reversal of the transaction.
/// </summary>
[IsoId("_TRGiYtp-Ed-ak6NoX_4Aeg_-494855858")]
[DisplayName("Reversal Reason Information")]
public record ReversalReasonInformation6
{
    /// <summary>
    /// Party that issues the reversal.
    /// </summary>
    [IsoId("_TRGiY9p-Ed-ak6NoX_4Aeg_1648049638")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_TRGiZNp-Ed-ak6NoX_4Aeg_-494855505")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ReversalReason4Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_TRGiZdp-Ed-ak6NoX_4Aeg_-494855849")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
