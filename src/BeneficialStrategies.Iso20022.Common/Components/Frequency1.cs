// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details to specify the frequency, pattern and other items to allow for the communication of a series of payments to be made to the same recipient over a period of time.
/// </summary>
[IsoId("_QUNr4Q2lEeSNWNtJlXOAhg")]
[DisplayName("Frequency")]
public partial record Frequency1
{
    #nullable enable
    
    /// <summary>
    /// Technical identifier of a Credit Transfer as part of a series of Credit Transfers within a single Payment Instruction. Assists the transfer of complex variable future payment schedules, associated with a single act of customer consent, within a single Payment Instruction.
    /// </summary>
    [IsoId("_eeziUA2lEeSNWNtJlXOAhg")]
    [DisplayName("Sequence")]
    [IsoXmlTag("Seq")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? Sequence { get; init; } 
    
    /// <summary>
    /// The date of the first payment to be made for this payment schedule.
    /// </summary>
    [IsoId("_g4fWgA2lEeSNWNtJlXOAhg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; } 
    
    /// <summary>
    /// Information about when the payment arrangement will end.
    /// </summary>
    [IsoId("_2-aEwA2lEeSNWNtJlXOAhg")]
    [DisplayName("End Point Choice")]
    [IsoXmlTag("EndPtChc")]
    public required EndPoint1Choice_ EndPointChoice { get; init; } 
    
    /// <summary>
    /// Payment schedule frequency pattern which indicates how frequently a payment is made.
    /// </summary>
    [IsoId("_7pukYA2lEeSNWNtJlXOAhg")]
    [DisplayName("Requested Frequency Pattern")]
    [IsoXmlTag("ReqdFrqcyPttrn")]
    public Frequency37Choice_? RequestedFrequencyPattern { get; init; } 
    
    /// <summary>
    /// Adjustment indicator for a non-working day to enable payment to be made on the next working day.
    /// </summary>
    [IsoId("_qsJo8A2lEeSNWNtJlXOAhg")]
    [DisplayName("Non Working Day Adjustment")]
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    
    
    #nullable disable
    
}
