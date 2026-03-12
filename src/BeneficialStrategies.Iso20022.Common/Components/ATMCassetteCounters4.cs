// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Counters of media inside an ATM cassette.
/// </summary>
[IsoId("_5Ns1Qa4MEeWZgJQOa6iKCQ")]
[DisplayName("ATM Cassette Counters")]
public partial record ATMCassetteCounters4
{
    #nullable enable
    
    /// <summary>
    /// Type of counters.
    /// </summary>
    [IsoId("_5Z6sUa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCounterType1Code Type { get; init; } 
    
    /// <summary>
    /// Number of added media during servicing operations.
    /// </summary>
    [IsoId("_5Z6sU64MEeWZgJQOa6iKCQ")]
    [DisplayName("Added Number")]
    [IsoXmlTag("AddedNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? AddedNumber { get; init; } 
    
    /// <summary>
    /// Number of removed media during servicing operations.
    /// </summary>
    [IsoId("_5Z6sVa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Removed Number")]
    [IsoXmlTag("RmvdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RemovedNumber { get; init; } 
    
    /// <summary>
    /// Total number of media out of the cassette.
    /// </summary>
    [IsoId("_5Z6sV64MEeWZgJQOa6iKCQ")]
    [DisplayName("Dispensed Number")]
    [IsoXmlTag("DspnsdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DispensedNumber { get; init; } 
    
    /// <summary>
    /// Total number of media deposited in the cassette.
    /// </summary>
    [IsoId("_5Z6sWa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Deposited Number")]
    [IsoXmlTag("DpstdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DepositedNumber { get; init; } 
    
    /// <summary>
    /// Total number of recycled media from the cassette.
    /// </summary>
    [IsoId("_5Z6sW64MEeWZgJQOa6iKCQ")]
    [DisplayName("Recycled Number")]
    [IsoXmlTag("RcycldNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RecycledNumber { get; init; } 
    
    /// <summary>
    /// Total number of retracted media originating from the cassette.
    /// </summary>
    [IsoId("_5Z6sXa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Retracted Number")]
    [IsoXmlTag("RtrctdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RetractedNumber { get; init; } 
    
    /// <summary>
    /// Total number of media from this cassette which are on the reject bin.
    /// </summary>
    [IsoId("_5Z6sX64MEeWZgJQOa6iKCQ")]
    [DisplayName("Rejected Number")]
    [IsoXmlTag("RjctdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? RejectedNumber { get; init; } 
    
    /// <summary>
    /// Total number of media presented to the customer.
    /// </summary>
    [IsoId("_5Z6sYa4MEeWZgJQOa6iKCQ")]
    [DisplayName("Presented Number")]
    [IsoXmlTag("PresntdNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PresentedNumber { get; init; } 
    
    
    #nullable disable
    
}
