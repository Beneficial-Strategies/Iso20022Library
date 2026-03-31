// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Counters of media inside an ATM cassette.
/// </summary>
[IsoId("_2nkHEYqhEeS4a4abTJTSSw")]
[DisplayName("ATM Cassette Counters")]
public record ATMCassetteCounters2
{
    /// <summary>
    /// Type of counters.
    /// </summary>
    [IsoId("_GUVFcIqjEeS4a4abTJTSSw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCounterType1Code Type { get; init; }

    /// <summary>
    /// Number of added media during servicing operations.
    /// </summary>
    [IsoId("_ON_wYIqjEeS4a4abTJTSSw")]
    [DisplayName("Added Number")]
    [IsoXmlTag("AddedNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AddedNumber { get; init; }

    /// <summary>
    /// Number of removed media during servicing operations.
    /// </summary>
    [IsoId("_RFb3kIqjEeS4a4abTJTSSw")]
    [DisplayName("Removed Number")]
    [IsoXmlTag("RmvdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RemovedNumber { get; init; }

    /// <summary>
    /// Total number of media out of the cassette.
    /// </summary>
    [IsoId("_UN3BEIqjEeS4a4abTJTSSw")]
    [DisplayName("Dispensed Number")]
    [IsoXmlTag("DspnsdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DispensedNumber { get; init; }

    /// <summary>
    /// Total number of media deposited in the cassette.
    /// </summary>
    [IsoId("_XPbUoIqjEeS4a4abTJTSSw")]
    [DisplayName("Deposit Number")]
    [IsoXmlTag("DpstNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DepositNumber { get; init; }

    /// <summary>
    /// Total number of recycled media from the cassette.
    /// </summary>
    [IsoId("_aA59wIqjEeS4a4abTJTSSw")]
    [DisplayName("Recycled Number")]
    [IsoXmlTag("RcycldNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RecycledNumber { get; init; }

    /// <summary>
    /// Total number of retracted media originating from the cassette.
    /// </summary>
    [IsoId("_dBk5cIqjEeS4a4abTJTSSw")]
    [DisplayName("Retracted Number")]
    [IsoXmlTag("RtrctdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RetractedNumber { get; init; }

    /// <summary>
    /// Total number of media from this cassette which are on the reject bin.
    /// </summary>
    [IsoId("_gIzwIIqjEeS4a4abTJTSSw")]
    [DisplayName("Rejected Number")]
    [IsoXmlTag("RjctdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RejectedNumber { get; init; }

    /// <summary>
    /// Total number of media presented to the customer.
    /// </summary>
    [IsoId("_jF-r4IqjEeS4a4abTJTSSw")]
    [DisplayName("Presented Number")]
    [IsoXmlTag("PresntdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PresentedNumber { get; init; }
}
