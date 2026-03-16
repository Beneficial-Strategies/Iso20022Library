// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_TX3lwb5aEeexmbB7KsjCwA")]
[DisplayName("Corporate Action SD")]
public record CorporateActionSD19
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_ToajMb5aEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Date at which positions are stuck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date. DTC (The Depository Trust Corporation) and its Participants may use this as a reference.
    /// </summary>
    [IsoId("_ToajM75aEeexmbB7KsjCwA")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RecordDate { get; init; }

    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_ToajO75aEeexmbB7KsjCwA")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat48Choice_? PaymentDate { get; init; }

    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_TobKQr5aEeexmbB7KsjCwA")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LotteryDate { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_TobKSr5aEeexmbB7KsjCwA")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryType1Code? LotteryType { get; init; }
}
