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
/// Specifies the type of change to statement frequency and form.
/// </summary>
[IsoId("_5U5pQA4rEeK3IMoVvcTkkg")]
[DisplayName("Statement Frequency And Form Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementFrequencyAndFormModification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatementFrequencyAndFormModification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementFrequencyAndFormModification1( StatementFrequencyAndForm1 reqStatementFrequencyAndForm )
    {
        StatementFrequencyAndForm = reqStatementFrequencyAndForm;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_CBMrAA4sEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModCd")]
    #endif
    [IsoXmlTag("ModCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? ModificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? ModificationCode { get; init; } 
    #else
    public Modification1Code? ModificationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the statement frequency, format, delivery address.
    /// </summary>
    [IsoId("_H3PRUA4sEeK3IMoVvcTkkg")]
    [DisplayName("Statement Frequency And Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtFrqcyAndForm")]
    #endif
    [IsoXmlTag("StmtFrqcyAndForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementFrequencyAndForm1 StatementFrequencyAndForm { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementFrequencyAndForm1 StatementFrequencyAndForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyAndForm1 StatementFrequencyAndForm { get; init; } 
    #else
    public StatementFrequencyAndForm1 StatementFrequencyAndForm { get; set; } 
    #endif
    
    
    #nullable disable
    
}
