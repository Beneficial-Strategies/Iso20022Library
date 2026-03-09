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
/// Type of movement preliminary advice document.
/// </summary>
[IsoId("_QE2AMTQSEe2o-K1dwNg8Gg")]
[DisplayName("Corporate Action Preliminary Advice Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPreliminaryAdviceType3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionPreliminaryAdviceType3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionPreliminaryAdviceType3( CorporateActionPreliminaryAdviceType1Code reqType,CorporateActionMovementPreliminaryAdviceFunction1Code reqFunction )
    {
        Type = reqType;
        Function = reqFunction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of movement preliminary advice, for example. new or replacement.
    /// </summary>
    [IsoId("_Qcr4cTQSEe2o-K1dwNg8Gg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPreliminaryAdviceType1Code Type { get; init; } 
    #else
    public CorporateActionPreliminaryAdviceType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the message advises about the final eligible balance and entitlements or about an upcoming posting or reversal of securities and/or cash postings.
    /// </summary>
    [IsoId("_97CFsDQSEe2o-K1dwNg8Gg")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMovementPreliminaryAdviceFunction1Code Function { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMovementPreliminaryAdviceFunction1Code Function { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMovementPreliminaryAdviceFunction1Code Function { get; init; } 
    #else
    public CorporateActionMovementPreliminaryAdviceFunction1Code Function { get; set; } 
    #endif
    
    
    #nullable disable
    
}
