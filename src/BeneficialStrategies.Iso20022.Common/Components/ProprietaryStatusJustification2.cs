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
/// Defines proprietary reason to reject a transaction.
/// </summary>
[IsoId("_hJmDMdEdEei798TPbKJMuw")]
[DisplayName("Proprietary Status Justification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProprietaryStatusJustification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProprietaryStatusJustification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProprietaryStatusJustification2( System.String reqProprietaryStatusReason,System.String reqReason )
    {
        ProprietaryStatusReason = reqProprietaryStatusReason;
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the reason why the system has rejected the transaction.
    /// </summary>
    [IsoId("_hU5UQdEdEei798TPbKJMuw")]
    [DisplayName("Proprietary Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryStsRsn")]
    #endif
    [IsoXmlTag("PrtryStsRsn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText ProprietaryStatusReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProprietaryStatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProprietaryStatusReason { get; init; } 
    #else
    public System.String ProprietaryStatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information about the reason why the  system has rejected the transaction.
    /// </summary>
    [IsoId("_hU5UQ9EdEei798TPbKJMuw")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Reason { get; init; } 
    #else
    public System.String Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
