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
/// Results of backtesting analysis used to test the performance of a risk model.
/// </summary>
[IsoId("_9ZdcILC3EeaSl6vJk5Bd8w")]
[DisplayName("Monthly Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MonthlyResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MonthlyResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MonthlyResult1( System.UInt64 reqNumberOfObservations,System.UInt64 reqNumberOfExceptions,System.Decimal reqCoverage,ActiveCurrencyAndAmount reqLargestException,ActiveCurrencyAndAmount reqAverageException )
    {
        NumberOfObservations = reqNumberOfObservations;
        NumberOfExceptions = reqNumberOfExceptions;
        Coverage = reqCoverage;
        LargestException = reqLargestException;
        AverageException = reqAverageException;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of accounts subject to backtesting in the month.
    /// </summary>
    [IsoId("_I2UhALC4EeaSl6vJk5Bd8w")]
    [DisplayName("Number Of Observations")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfObsrvtns")]
    #endif
    [IsoXmlTag("NbOfObsrvtns")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPositiveNumber NumberOfObservations { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfObservations { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfObservations { get; init; } 
    #else
    public System.UInt64 NumberOfObservations { get; set; } 
    #endif
    
    /// <summary>
    /// Number of times that margin coverage held against any account fell below the marked‐to‐market exposure of that member account, based on the backtesting results.
    /// </summary>
    [IsoId("_4jSh8LC4EeaSl6vJk5Bd8w")]
    [DisplayName("Number Of Exceptions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfXcptns")]
    #endif
    [IsoXmlTag("NbOfXcptns")]
    [IsoSimpleType(IsoSimpleType.NonNegativeNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNonNegativeNumber NumberOfExceptions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfExceptions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfExceptions { get; init; } 
    #else
    public System.UInt64 NumberOfExceptions { get; set; } 
    #endif
    
    /// <summary>
    /// Achieved coverage level.
    /// </summary>
    [IsoId("_Y4uYMLC5EeaSl6vJk5Bd8w")]
    [DisplayName("Coverage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cvrg")]
    #endif
    [IsoXmlTag("Cvrg")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate Coverage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Coverage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Coverage { get; init; } 
    #else
    public System.Decimal Coverage { get; set; } 
    #endif
    
    /// <summary>
    /// Largest marked-to-market exposure on any account that exceeds the margin coverage held against that account. The difference between the size of the exposure and the margin held.
    /// </summary>
    [IsoId("_p424YLC5EeaSl6vJk5Bd8w")]
    [DisplayName("Largest Exception")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LrgstXcptn")]
    #endif
    [IsoXmlTag("LrgstXcptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount LargestException { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount LargestException { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount LargestException { get; init; } 
    #else
    public ActiveCurrencyAndAmount LargestException { get; set; } 
    #endif
    
    /// <summary>
    /// Average marked‐to‐market exposure on accounts that exceeds the margin coverage held against those accounts.
    /// </summary>
    [IsoId("_wM63cLC5EeaSl6vJk5Bd8w")]
    [DisplayName("Average Exception")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgXcptn")]
    #endif
    [IsoXmlTag("AvrgXcptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount AverageException { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount AverageException { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount AverageException { get; init; } 
    #else
    public ActiveCurrencyAndAmount AverageException { get; set; } 
    #endif
    
    /// <summary>
    /// Unique internal identifier for the backtested account experiencing the largest exception.
    /// </summary>
    [IsoId("_AOalILC6EeaSl6vJk5Bd8w")]
    [DisplayName("Largest Exception Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LrgstXcptnId")]
    #endif
    [IsoXmlTag("LrgstXcptnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification165? LargestExceptionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165? LargestExceptionIdentification { get; init; } 
    #else
    public GenericIdentification165? LargestExceptionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
