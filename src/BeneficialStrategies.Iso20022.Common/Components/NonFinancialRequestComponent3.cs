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
[IsoId("_YkhCEXJWEe299ZbWCkdR_w")]
[DisplayName("Non Financial Request Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialRequestComponent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonFinancialRequestComponent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonFinancialRequestComponent3( CardPaymentEnvironment79 reqEnvironment,CardPaymentContext30 reqContext,NonFinancialRequestContentComponent3 reqNonFinancialRequestContent )
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
    [IsoId("_Yq-2cXJWEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment79 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment79 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment79 Environment { get; init; } 
    #else
    public CardPaymentEnvironment79 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_Yq-2c3JWEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext30 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext30 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext30 Context { get; init; } 
    #else
    public CardPaymentContext30 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Aim of the non financial request.
    /// </summary>
    [IsoId("_Yq-2dXJWEe299ZbWCkdR_w")]
    [DisplayName("Non Financial Request Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFinReqCntt")]
    #endif
    [IsoXmlTag("NonFinReqCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonFinancialRequestContentComponent3 NonFinancialRequestContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonFinancialRequestContentComponent3 NonFinancialRequestContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialRequestContentComponent3 NonFinancialRequestContent { get; init; } 
    #else
    public NonFinancialRequestContentComponent3 NonFinancialRequestContent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_Yq-2d3JWEe299ZbWCkdR_w")]
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
