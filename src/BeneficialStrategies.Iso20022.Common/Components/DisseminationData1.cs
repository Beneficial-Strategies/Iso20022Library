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
/// Information regarding the dissemination of data.
/// </summary>
[IsoId("_S9HpkCJmEe2zWP9pqvmqdw")]
[DisplayName("Dissemination Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisseminationData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DisseminationData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DisseminationData1( System.String reqDisseminationIdentifier,System.DateTime reqTimeStamp )
    {
        DisseminationIdentifier = reqDisseminationIdentifier;
        TimeStamp = reqTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Trade repository generated unique and random identifier for each publicly disseminated message.
    /// </summary>
    [IsoId("_n3PTECJmEe2zWP9pqvmqdw")]
    [DisplayName("Dissemination Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DssmntnIdr")]
    #endif
    [IsoXmlTag("DssmntnIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text DisseminationIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DisseminationIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DisseminationIdentifier { get; init; } 
    #else
    public System.String DisseminationIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Trade repository generated unique and random identifier of the original, publicly-disseminated swap transaction and pricing data.
    /// Usage: OriginalDisseminationIdentifier is applicable only for action types other than New.
    /// </summary>
    [IsoId("_u_-QUCJmEe2zWP9pqvmqdw")]
    [DisplayName("Original Dissemination Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDssmntnIdr")]
    #endif
    [IsoXmlTag("OrgnlDssmntnIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? OriginalDisseminationIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalDisseminationIdentifier { get; init; } 
    #else
    public System.String? OriginalDisseminationIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time, to the nearest second, that a trade repository publicly disseminates trade data.
    /// </summary>
    [IsoId("_wu1l4CJmEe2zWP9pqvmqdw")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TimeStamp { get; init; } 
    #else
    public System.DateTime TimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
