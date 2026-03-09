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
/// Provides further details related to the duration of the mandate and the occurrence of the underlying transactions.
/// </summary>
[IsoId("_VlU0kWZVEeuQ__SOdbf47A")]
[DisplayName("Mandate Occurrences")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateOccurrences5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateOccurrences5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateOccurrences5( SequenceType2Code reqSequenceType )
    {
        SequenceType = reqSequenceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the underlying transaction sequence as either recurring or one-off.
    /// </summary>
    [IsoId("_V7Cl42ZVEeuQ__SOdbf47A")]
    [DisplayName("Sequence Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqTp")]
    #endif
    [IsoXmlTag("SeqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SequenceType2Code SequenceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SequenceType2Code SequenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SequenceType2Code SequenceType { get; init; } 
    #else
    public SequenceType2Code SequenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Regularity with which instructions are to be created and processed.
    /// </summary>
    [IsoId("_V7Cl5WZVEeuQ__SOdbf47A")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency36Choice_? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency36Choice_? Frequency { get; init; } 
    #else
    public Frequency36Choice_? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Length of time for which the mandate remains valid.
    /// </summary>
    [IsoId("_V7Cl52ZVEeuQ__SOdbf47A")]
    [DisplayName("Duration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drtn")]
    #endif
    [IsoXmlTag("Drtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriod3? Duration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriod3? Duration { get; init; } 
    #else
    public DatePeriod3? Duration { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_V7Cl6WZVEeuQ__SOdbf47A")]
    [DisplayName("First Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstColltnDt")]
    #endif
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FirstCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FirstCollectionDate { get; init; } 
    #else
    public System.DateOnly? FirstCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_V7Cl62ZVEeuQ__SOdbf47A")]
    [DisplayName("Final Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlColltnDt")]
    #endif
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FinalCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FinalCollectionDate { get; init; } 
    #else
    public System.DateOnly? FinalCollectionDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
