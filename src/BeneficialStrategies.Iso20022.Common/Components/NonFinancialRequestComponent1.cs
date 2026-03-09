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
/// Information related to the non financial request.
/// </summary>
[IsoId("_MeptkC_nEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Request Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialRequestComponent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonFinancialRequestComponent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonFinancialRequestComponent1( CardPaymentEnvironment77 reqEnvironment,CardPaymentContext28 reqContext,NonFinancialRequestContentComponent1 reqNonFinancialRequestContent )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        NonFinancialRequestContent = reqNonFinancialRequestContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_NlxRNC_oEeugIJ3Gvoevmg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment77 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment77 Environment { get; init; } 
    #else
    public CardPaymentEnvironment77 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_NlxRNS_oEeugIJ3Gvoevmg")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext28 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext28 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext28 Context { get; init; } 
    #else
    public CardPaymentContext28 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Aim of the non financial request.
    /// </summary>
    [IsoId("_dkTxgC_oEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFinReqCntt")]
    #endif
    [IsoXmlTag("NonFinReqCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonFinancialRequestContentComponent1 NonFinancialRequestContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonFinancialRequestContentComponent1 NonFinancialRequestContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialRequestContentComponent1 NonFinancialRequestContent { get; init; } 
    #else
    public NonFinancialRequestContentComponent1 NonFinancialRequestContent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_NlxRNy_oEeugIJ3Gvoevmg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
