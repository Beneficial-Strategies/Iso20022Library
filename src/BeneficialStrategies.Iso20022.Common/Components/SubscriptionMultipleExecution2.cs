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
/// Execution of a subscription order.
/// </summary>
[IsoId("_VVbKktp-Ed-ak6NoX_4Aeg_123428666")]
[DisplayName("Subscription Multiple Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubscriptionMultipleExecution2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubscriptionMultipleExecution2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubscriptionMultipleExecution2( InvestmentAccount13 reqInvestmentAccountDetails )
    {
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VVbKk9p-Ed-ak6NoX_4Aeg_124349998")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfTrade { get; init; } 
    #else
    public string? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VVbKlNp-Ed-ak6NoX_4Aeg_123429129")]
    [DisplayName("Order Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDtTm")]
    #endif
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VVbKldp-Ed-ak6NoX_4Aeg_123429639")]
    [DisplayName("Cancellation Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRght")]
    #endif
    [IsoXmlTag("CxlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1? CancellationRight { get; init; } 
    #else
    public CancellationRight1? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VVbKltp-Ed-ak6NoX_4Aeg_124352824")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_VVbKl9p-Ed-ak6NoX_4Aeg_1956221566")]
    [DisplayName("Beneficiary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryDtls")]
    #endif
    [IsoXmlTag("BnfcryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #else
    public IndividualPerson2? BeneficiaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Execution of a subscription order.
    /// </summary>
    [IsoId("_VVbKmNp-Ed-ak6NoX_4Aeg_125276199")]
    [DisplayName("Individual Execution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvExctnDtls")]
    #endif
    [IsoXmlTag("IndvExctnDtls")]
    public ValueList<SubscriptionExecution4> IndividualExecutionDetails { get; init; } = new ValueList<SubscriptionExecution4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VVbKmNp-Ed-ak6NoX_4Aeg_125276199
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VVbKmdp-Ed-ak6NoX_4Aeg_124350731")]
    [DisplayName("Bulk Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkCshSttlmDtls")]
    #endif
    [IsoXmlTag("BlkCshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction13? BulkCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction13? BulkCashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction13? BulkCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
