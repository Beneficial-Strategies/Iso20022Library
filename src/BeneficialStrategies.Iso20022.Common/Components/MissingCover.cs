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
/// Indicates that the claim for non receipt is effectively a missing cover.
/// </summary>
[IsoId("_T9zQWdp-Ed-ak6NoX_4Aeg_-539916461")]
[DisplayName("Missing Cover")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingCover
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MissingCover instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MissingCover( System.String reqMissingCoverIndication )
    {
        MissingCoverIndication = reqMissingCoverIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    [IsoId("_T9zQWtp-Ed-ak6NoX_4Aeg_1790222510")]
    [DisplayName("Missing Cover Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MssngCoverIndctn")]
    #endif
    [IsoXmlTag("MssngCoverIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MissingCoverIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MissingCoverIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MissingCoverIndication { get; init; } 
    #else
    public System.String MissingCoverIndication { get; set; } 
    #endif
    
    
    #nullable disable
    
}
