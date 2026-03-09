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
/// Acceptor parameters dedicated to the acquirer protocol.
/// </summary>
[IsoId("_UN6X5Au2Eeq4I6UJxZQ2Qw")]
[DisplayName("Acquirer Protocol Exchange Behavior")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcquirerProtocolExchangeBehavior1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcquirerProtocolExchangeBehavior1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcquirerProtocolExchangeBehavior1( FinancialCapture1Code reqFinancialCapture )
    {
        FinancialCapture = reqFinancialCapture;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Mode for the financial capture of the transaction by the acquirer.
    /// </summary>
    [IsoId("_UN6-8wu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Financial Capture")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinCaptr")]
    #endif
    [IsoXmlTag("FinCaptr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialCapture1Code FinancialCapture { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialCapture1Code FinancialCapture { get; init; } 
    #else
    public FinancialCapture1Code FinancialCapture { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the batch transfers.
    /// </summary>
    [IsoId("_UN6-8Qu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Batch Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchTrf")]
    #endif
    [IsoXmlTag("BtchTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration8? BatchTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration8? BatchTransfer { get; init; } 
    #else
    public ExchangeConfiguration8? BatchTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters of completion exchanges.
    /// </summary>
    [IsoId("_UN6-8Au2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Completion Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnXchg")]
    #endif
    [IsoXmlTag("CmpltnXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExchangeConfiguration8? CompletionExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangeConfiguration8? CompletionExchange { get; init; } 
    #else
    public ExchangeConfiguration8? CompletionExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration of the cancellation exchanges.
    /// </summary>
    [IsoId("_UN6-8gu2Eeq4I6UJxZQ2Qw")]
    [DisplayName("Cancellation Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlXchg")]
    #endif
    [IsoXmlTag("CxlXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationProcess2Code? CancellationExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationProcess2Code? CancellationExchange { get; init; } 
    #else
    public CancellationProcess2Code? CancellationExchange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
