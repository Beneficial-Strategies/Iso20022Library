// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details to specify the frequency, pattern and other items to allow for the communication of a series of payments to be made to the same recipient over a period of time.
/// </summary>
[IsoId("_auNAsbpVEfCPZvweyV2nEg")]
[DisplayName("Frequency2")]
public record Frequency2
{
    /// <summary>
    /// Technical identifier of a Credit Transfer as part of a series of Credit Transfers within a single Payment Instruction.
    /// </summary>
    [IsoId("_a2kSgbpVEfCPZvweyV2nEg")]
    [DisplayName("Sequence")]
    [IsoXmlTag("Seq")]
    public IsoMax3NumericText? Sequence { get; init; }

    /// <summary>
    /// The date of the first payment to be made for this payment schedule.
    /// </summary>
    [IsoId("_a2kSg7pVEfCPZvweyV2nEg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public required IsoISODate StartDate { get; init; }

    /// <summary>
    /// Information about when the payment arrangement will end.
    /// </summary>
    [IsoId("_a2kShbpVEfCPZvweyV2nEg")]
    [DisplayName("End Point Choice")]
    [IsoXmlTag("EndPtChc")]
    public required EndPoint2Choice EndPointChoice { get; init; }

    /// <summary>
    /// Payment schedule frequency pattern which indicates how frequently a payment is made.
    /// </summary>
    [IsoId("_a2kSh7pVEfCPZvweyV2nEg")]
    [DisplayName("Requested Frequency Pattern")]
    [IsoXmlTag("ReqdFrqcyPttrn")]
    public Frequency37Choice? RequestedFrequencyPattern { get; init; }

    /// <summary>
    /// Adjustment indicator for a non-working day to enable payment to be made on the next working day.
    /// </summary>
    [IsoId("_a2kSibpVEfCPZvweyV2nEg")]
    [DisplayName("Non Working Day Adjustment")]
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    public BusinessDayConvention2Code? NonWorkingDayAdjustment { get; init; }
}
