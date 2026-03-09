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
/// This component define the type of financial services to be used with this message of Reconciliation. There is only one service : ReconciliationRequest.
/// </summary>
[IsoId("_KEpZgU6uEeyGi9JAv6wq7Q")]
[DisplayName("Reconciliation Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationRequest5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationRequest5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationRequest5( CardPaymentEnvironment78 reqEnvironment,CardPaymentContext29 reqContext,ReconciliationRequestData1 reqReconciliationRequestData )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        ReconciliationRequestData = reqReconciliationRequestData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_KKuMUU6uEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment78 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment78 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment78 Environment { get; init; } 
    #else
    public CardPaymentEnvironment78 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_KKuMU06uEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext29 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext29 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext29 Context { get; init; } 
    #else
    public CardPaymentContext29 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the Reconciliation Request message.
    /// </summary>
    [IsoId("_KKuMVU6uEeyGi9JAv6wq7Q")]
    [DisplayName("Reconciliation Request Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnReqData")]
    #endif
    [IsoXmlTag("RcncltnReqData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationRequestData1 ReconciliationRequestData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationRequestData1 ReconciliationRequestData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationRequestData1 ReconciliationRequestData { get; init; } 
    #else
    public ReconciliationRequestData1 ReconciliationRequestData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_KKuMV06uEeyGi9JAv6wq7Q")]
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
