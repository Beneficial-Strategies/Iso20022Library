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
/// Details of the triparty collateral transaction deal.
/// </summary>
[IsoId("_b2hQgRIlEeyLzJfz3xPQNA")]
[DisplayName("Deal Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DealTransactionDetails7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DealTransactionDetails7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DealTransactionDetails7( ClosingDate4Choice_ reqClosingDate )
    {
        ClosingDate = reqClosingDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_cQTCcRIlEeyLzJfz3xPQNA")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingDate4Choice_ ClosingDate { get; init; } 
    #else
    public ClosingDate4Choice_ ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provide deal amount details.
    /// </summary>
    [IsoId("_cQTCcxIlEeyLzJfz3xPQNA")]
    [DisplayName("Deal Details Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealDtlsAmt")]
    #endif
    [IsoXmlTag("DealDtlsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralAmount14? DealDetailsAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAmount14? DealDetailsAmount { get; init; } 
    #else
    public CollateralAmount14? DealDetailsAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
