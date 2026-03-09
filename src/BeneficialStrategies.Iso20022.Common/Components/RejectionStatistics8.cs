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
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
/// </summary>
[IsoId("_x9xzwVyGEe24CqbZJK5XxA")]
[DisplayName("Rejection Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionStatistics8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionStatistics8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionStatistics8( CounterpartyData92 reqCounterpartyIdentification,DetailedReportStatistics6 reqReportStatistics,DetailedTransactionStatistics6Choice_ reqDerivativeStatistics )
    {
        CounterpartyIdentification = reqCounterpartyIdentification;
        ReportStatistics = reqReportStatistics;
        DerivativeStatistics = reqDerivativeStatistics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_x-ovYVyGEe24CqbZJK5XxA")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData92 CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyData92 CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData92 CounterpartyIdentification { get; init; } 
    #else
    public CounterpartyData92 CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information about accepted and rejected reports and the reasons of rejection.
    /// </summary>
    [IsoId("_x-ovY1yGEe24CqbZJK5XxA")]
    [DisplayName("Report Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptSttstcs")]
    #endif
    [IsoXmlTag("RptSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailedReportStatistics6 ReportStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailedReportStatistics6 ReportStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedReportStatistics6 ReportStatistics { get; init; } 
    #else
    public DetailedReportStatistics6 ReportStatistics { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
    /// </summary>
    [IsoId("_x-ovZVyGEe24CqbZJK5XxA")]
    [DisplayName("Derivative Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivSttstcs")]
    #endif
    [IsoXmlTag("DerivSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailedTransactionStatistics6Choice_ DerivativeStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailedTransactionStatistics6Choice_ DerivativeStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedTransactionStatistics6Choice_ DerivativeStatistics { get; init; } 
    #else
    public DetailedTransactionStatistics6Choice_ DerivativeStatistics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
