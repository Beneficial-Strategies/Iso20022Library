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
/// Information provided when the message is a copy of a previous message.
/// </summary>
[IsoId("_WIPHktp-Ed-ak6NoX_4Aeg_849600101")]
[DisplayName("Copy Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CopyInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CopyInformation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CopyInformation3( System.String reqCopyIndicator )
    {
        CopyIndicator = reqCopyIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the message is a copy.
    /// </summary>
    [IsoId("_WIPHk9p-Ed-ak6NoX_4Aeg_849600111")]
    [DisplayName("Copy Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyInd")]
    #endif
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CopyIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CopyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CopyIndicator { get; init; } 
    #else
    public System.String CopyIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
