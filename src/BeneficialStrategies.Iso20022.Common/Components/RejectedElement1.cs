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
/// Provides information on the rejection reason of an individual element.
/// </summary>
[IsoId("_RJy3pdp-Ed-ak6NoX_4Aeg_2106998089")]
[DisplayName("Rejected Element")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectedElement1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectedElement1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectedElement1( System.UInt64 reqElementSequenceNumber,System.String reqIndividualRejectionReason )
    {
        ElementSequenceNumber = reqElementSequenceNumber;
        IndividualRejectionReason = reqIndividualRejectionReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequence number that allows to easily identify the element that is rejected.
    /// </summary>
    [IsoId("_RJy3ptp-Ed-ak6NoX_4Aeg_-1803784041")]
    [DisplayName("Element Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElmtSeqNb")]
    #endif
    [IsoXmlTag("ElmtSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ElementSequenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ElementSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ElementSequenceNumber { get; init; } 
    #else
    public System.UInt64 ElementSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for rejecting an individual element.
    /// </summary>
    [IsoId("_RJy3p9p-Ed-ak6NoX_4Aeg_1481340627")]
    [DisplayName("Individual Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvRjctnRsn")]
    #endif
    [IsoXmlTag("IndvRjctnRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text IndividualRejectionReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IndividualRejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IndividualRejectionReason { get; init; } 
    #else
    public System.String IndividualRejectionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
