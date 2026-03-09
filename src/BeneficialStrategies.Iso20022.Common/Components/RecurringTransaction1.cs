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
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_SpYh7gEcEeCQm6a_G2yO_w_-569860423")]
[DisplayName("Recurring Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RecurringTransaction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RecurringTransaction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RecurringTransaction1( System.String reqSequenceNumber,Frequency4Code reqPeriodUnit,System.UInt64 reqInstalmentPeriod,System.UInt64 reqTotalNumberOfPayments )
    {
        SequenceNumber = reqSequenceNumber;
        PeriodUnit = reqPeriodUnit;
        InstalmentPeriod = reqInstalmentPeriod;
        TotalNumberOfPayments = reqTotalNumberOfPayments;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_SpiS4AEcEeCQm6a_G2yO_w_295359691")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2NumericText SequenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SequenceNumber { get; init; } 
    #else
    public System.String SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_SpiS4QEcEeCQm6a_G2yO_w_1632462586")]
    [DisplayName("Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdUnit")]
    #endif
    [IsoXmlTag("PrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency4Code PeriodUnit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency4Code PeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency4Code PeriodUnit { get; init; } 
    #else
    public Frequency4Code PeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_SpiS4gEcEeCQm6a_G2yO_w_-377494272")]
    [DisplayName("Instalment Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtPrd")]
    #endif
    [IsoXmlTag("InstlmtPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber InstalmentPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 InstalmentPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 InstalmentPeriod { get; init; } 
    #else
    public System.UInt64 InstalmentPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_SpiS4wEcEeCQm6a_G2yO_w_-1926232913")]
    [DisplayName("Total Number Of Payments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfPmts")]
    #endif
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumberOfPayments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberOfPayments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberOfPayments { get; init; } 
    #else
    public System.UInt64 TotalNumberOfPayments { get; set; } 
    #endif
    
    /// <summary>
    /// Interest charged in percentage for the total amount of payments.
    /// </summary>
    [IsoId("_SpiS5AEcEeCQm6a_G2yO_w_993672809")]
    [DisplayName("Interest Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstChrgs")]
    #endif
    [IsoXmlTag("IntrstChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InterestCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InterestCharges { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InterestCharges { get; set; } 
    #endif
    
    
    #nullable disable
    
}
