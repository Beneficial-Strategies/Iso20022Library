// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details to specify the frequency, pattern and other items to allow for the communication of a series of payments to be made to the same recipient over a period of time.
/// </summary>
[IsoId("_QUNr4Q2lEeSNWNtJlXOAhg")]
[DisplayName("Frequency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Frequency1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Frequency1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Frequency1( System.DateOnly reqStartDate,EndPoint1Choice_ reqEndPointChoice )
    {
        StartDate = reqStartDate;
        EndPointChoice = reqEndPointChoice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Technical identifier of a Credit Transfer as part of a series of Credit Transfers within a single Payment Instruction. Assists the transfer of complex variable future payment schedules, associated with a single act of customer consent, within a single Payment Instruction.
    /// </summary>
    [IsoId("_eeziUA2lEeSNWNtJlXOAhg")]
    [DisplayName("Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Seq")]
    #endif
    [IsoXmlTag("Seq")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? Sequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sequence { get; init; } 
    #else
    public System.String? Sequence { get; set; } 
    #endif
    
    /// <summary>
    /// The date of the first payment to be made for this payment schedule.
    /// </summary>
    [IsoId("_g4fWgA2lEeSNWNtJlXOAhg")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate StartDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly StartDate { get; init; } 
    #else
    public System.DateOnly StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Information about when the payment arrangement will end.
    /// </summary>
    [IsoId("_2-aEwA2lEeSNWNtJlXOAhg")]
    [DisplayName("End Point Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndPtChc")]
    #endif
    [IsoXmlTag("EndPtChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EndPoint1Choice_ EndPointChoice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EndPoint1Choice_ EndPointChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EndPoint1Choice_ EndPointChoice { get; init; } 
    #else
    public EndPoint1Choice_ EndPointChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Payment schedule frequency pattern which indicates how frequently a payment is made.
    /// </summary>
    [IsoId("_7pukYA2lEeSNWNtJlXOAhg")]
    [DisplayName("Requested Frequency Pattern")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdFrqcyPttrn")]
    #endif
    [IsoXmlTag("ReqdFrqcyPttrn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency37Choice_? RequestedFrequencyPattern { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency37Choice_? RequestedFrequencyPattern { get; init; } 
    #else
    public Frequency37Choice_? RequestedFrequencyPattern { get; set; } 
    #endif
    
    /// <summary>
    /// Adjustment indicator for a non-working day to enable payment to be made on the next working day.
    /// </summary>
    [IsoId("_qsJo8A2lEeSNWNtJlXOAhg")]
    [DisplayName("Non Working Day Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonWorkgDayAdjstmnt")]
    #endif
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    #else
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
