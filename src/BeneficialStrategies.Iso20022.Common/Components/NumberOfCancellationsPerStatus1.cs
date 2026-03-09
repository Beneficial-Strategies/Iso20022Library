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
/// Set of elements used to provide detailed information on the number of transactions that are reported with a specific cancellation status.
/// </summary>
[IsoId("_Rquaddp-Ed-ak6NoX_4Aeg_847606645")]
[DisplayName("Number Of Cancellations Per Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfCancellationsPerStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfCancellationsPerStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfCancellationsPerStatus1( System.String reqDetailedNumberOfTransactions,CancellationIndividualStatus1Code reqDetailedStatus )
    {
        DetailedNumberOfTransactions = reqDetailedNumberOfTransactions;
        DetailedStatus = reqDetailedStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of individual cancellation requests contained in the message, detailed per status.
    /// </summary>
    [IsoId("_Rquadtp-Ed-ak6NoX_4Aeg_847606677")]
    [DisplayName("Detailed Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldNbOfTxs")]
    #endif
    [IsoXmlTag("DtldNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText DetailedNumberOfTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DetailedNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DetailedNumberOfTransactions { get; init; } 
    #else
    public System.String DetailedNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Common cancellation request status for all individual cancellation requests reported.
    /// </summary>
    [IsoId("_Rquad9p-Ed-ak6NoX_4Aeg_847606923")]
    [DisplayName("Detailed Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldSts")]
    #endif
    [IsoXmlTag("DtldSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationIndividualStatus1Code DetailedStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationIndividualStatus1Code DetailedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationIndividualStatus1Code DetailedStatus { get; init; } 
    #else
    public CancellationIndividualStatus1Code DetailedStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies, detailed per status.
    /// </summary>
    [IsoId("_RquaeNp-Ed-ak6NoX_4Aeg_847606954")]
    [DisplayName("Detailed Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldCtrlSum")]
    #endif
    [IsoXmlTag("DtldCtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? DetailedControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DetailedControlSum { get; init; } 
    #else
    public System.UInt64? DetailedControlSum { get; set; } 
    #endif
    
    
    #nullable disable
    
}
