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
/// Identification of a payment instruction by its relative position in a queue of payment transactions managed by the clearing agent.
/// </summary>
[IsoId("_X0ioAZlQEee-Zps0fZQaFQ")]
[DisplayName("Queue Transaction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QueueTransactionIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QueueTransactionIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QueueTransactionIdentification1( System.String reqQueueIdentification,System.String reqPositionInQueue )
    {
        QueueIdentification = reqQueueIdentification;
        PositionInQueue = reqPositionInQueue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the payment queue where the payment instruction resides.
    /// </summary>
    [IsoId("_X8kioZlQEee-Zps0fZQaFQ")]
    [DisplayName("Queue Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QId")]
    #endif
    [IsoXmlTag("QId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text QueueIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueueIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueueIdentification { get; init; } 
    #else
    public System.String QueueIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Position of the payment instruction within the identified queue.
    /// </summary>
    [IsoId("_X8kio5lQEee-Zps0fZQaFQ")]
    [DisplayName("Position In Queue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosInQ")]
    #endif
    [IsoXmlTag("PosInQ")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text PositionInQueue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PositionInQueue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PositionInQueue { get; init; } 
    #else
    public System.String PositionInQueue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
