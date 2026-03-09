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
/// Specifies the securities order transmission attributes.
/// </summary>
[IsoId("_gW374OqLEeSsk6KxwbYJ9w")]
[DisplayName("Securities Transaction Transmission")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTransactionTransmission2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTransactionTransmission2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTransactionTransmission2( System.String reqTransmissionIndicator )
    {
        TransmissionIndicator = reqTransmissionIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication as to whether the transaction results from an order transmitted by the reporting of a client to a third party.
    /// Usage: Only applicable when the conditions for transmission are not satisfied.
    /// </summary>
    [IsoId("_N4TSUOqMEeSsk6KxwbYJ9w")]
    [DisplayName("Transmission Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmssnInd")]
    #endif
    [IsoXmlTag("TrnsmssnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator TransmissionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransmissionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransmissionIndicator { get; init; } 
    #else
    public System.String TransmissionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the buyer transmitting the order to the reporting firm. 
    /// Usage: Only required for reporting firms reporting transactions on behalf of order transmitting firm.
    /// </summary>
    [IsoId("_9VEUEeqMEeSsk6KxwbYJ9w")]
    [DisplayName("Transmitting Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmttgBuyr")]
    #endif
    [IsoXmlTag("TrnsmttgBuyr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? TransmittingBuyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransmittingBuyer { get; init; } 
    #else
    public System.String? TransmittingBuyer { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the seller transmitting the order to the reporting firm. 
    /// Usage: Only required for reporting firms reporting transactions on behalf of order transmitting firm.
    /// </summary>
    [IsoId("_1GQfkOqMEeSsk6KxwbYJ9w")]
    [DisplayName("Transmitting Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmttgSellr")]
    #endif
    [IsoXmlTag("TrnsmttgSellr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? TransmittingSeller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransmittingSeller { get; init; } 
    #else
    public System.String? TransmittingSeller { get; set; } 
    #endif
    
    
    #nullable disable
    
}
