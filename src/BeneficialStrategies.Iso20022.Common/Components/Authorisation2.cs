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
/// Autorisation of the mandate holder.
/// </summary>
[IsoId("_xZZNIw3wEeKGXqvMN6jpiw")]
[DisplayName("Authorisation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Authorisation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum amount allowed by the mandate for each transaction.
    /// </summary>
    [IsoId("_xujkxQ3wEeKGXqvMN6jpiw")]
    [DisplayName("Maximum Amount By Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmtByTx")]
    #endif
    [IsoXmlTag("MaxAmtByTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByTransaction { get; init; } 
    #else
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount allowed over a specific period of time.
    /// </summary>
    [IsoId("_xujkyQ3wEeKGXqvMN6jpiw")]
    [DisplayName("Maximum Amount By Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmtByPrd")]
    #endif
    [IsoXmlTag("MaxAmtByPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; init; } 
    #else
    public MaximumAmountByPeriod1? MaximumAmountByPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the maximum amount for each bulk submission.
    /// </summary>
    [IsoId("_RK4zUA3yEeKGXqvMN6jpiw")]
    [DisplayName("Maximum Amount By Bulk Submission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmtByBlkSubmissn")]
    #endif
    [IsoXmlTag("MaxAmtByBlkSubmissn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByBulkSubmission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByBulkSubmission { get; init; } 
    #else
    public FixedAmountOrUnlimited1Choice_? MaximumAmountByBulkSubmission { get; set; } 
    #endif
    
    
    #nullable disable
    
}
