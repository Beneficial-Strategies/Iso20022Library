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
/// Identifies the underlying (group of) transaction(s) to which the investigation applies.
/// </summary>
[IsoId("_QMXx0bPgEeeppqgHuc69jg")]
[DisplayName("Underlying Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTransaction21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message, to which the cancellation refers.
    /// </summary>
    [IsoId("_QUjdf7PgEeeppqgHuc69jg")]
    [DisplayName("Original Group Information And Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndCxl")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupHeader10? OriginalGroupInformationAndCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader10? OriginalGroupInformationAndCancellation { get; init; } 
    #else
    public OriginalGroupHeader10? OriginalGroupInformationAndCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation request refers.
    /// </summary>
    [IsoId("_QUjdgbPgEeeppqgHuc69jg")]
    [DisplayName("Original Payment Information And Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndCxl")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction29? OriginalPaymentInformationAndCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction29? OriginalPaymentInformationAndCancellation { get; init; } 
    #else
    public OriginalPaymentInstruction29? OriginalPaymentInformationAndCancellation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
