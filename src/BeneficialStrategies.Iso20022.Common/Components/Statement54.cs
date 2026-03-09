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
/// Characteristics of the statement.
/// </summary>
[IsoId("_8QbA2ZNLEeWGlc8L7oPDIg")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement54
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [IsoId("_8QbA35NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Date Or Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtOrPrd")]
    #endif
    [IsoXmlTag("StmtDtOrPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; init; } 
    #else
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_8QbA55NLEeWGlc8L7oPDIg")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency26Choice_? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency26Choice_? Frequency { get; init; } 
    #else
    public Frequency26Choice_? Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [IsoId("_8QbA75NLEeWGlc8L7oPDIg")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdateType16Choice_? UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdateType16Choice_? UpdateType { get; init; } 
    #else
    public UpdateType16Choice_? UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_8QbA95NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtBsis")]
    #endif
    [IsoXmlTag("StmtBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementBasis9Choice_? StatementBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementBasis9Choice_? StatementBasis { get; init; } 
    #else
    public StatementBasis9Choice_? StatementBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_8QbA_5NLEeWGlc8L7oPDIg")]
    [DisplayName("Statement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtTp")]
    #endif
    [IsoXmlTag("StmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementType6Choice_? StatementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementType6Choice_? StatementType { get; init; } 
    #else
    public StatementType6Choice_? StatementType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
