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
/// Set of elements used to provide additional cover details for the claim non receipt.
/// </summary>
[IsoId("_T9zQW9p-Ed-ak6NoX_4Aeg_-1690835638")]
[DisplayName("Missing Cover")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingCover2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MissingCover2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MissingCover2( System.String reqMissingCoverIndicator )
    {
        MissingCoverIndicator = reqMissingCoverIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the claim is related to a missing cover.
    /// </summary>
    [IsoId("_T9zQXNp-Ed-ak6NoX_4Aeg_-1690835576")]
    [DisplayName("Missing Cover Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MssngCoverInd")]
    #endif
    [IsoXmlTag("MssngCoverInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MissingCoverIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MissingCoverIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MissingCoverIndicator { get; init; } 
    #else
    public System.String MissingCoverIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements provided to update incorrect settlement information for the cover related to the received payment instruction.
    /// </summary>
    [IsoId("_T99BUNp-Ed-ak6NoX_4Aeg_-1317732569")]
    [DisplayName("Cover Correction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverCrrctn")]
    #endif
    [IsoXmlTag("CoverCrrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInformation15? CoverCorrection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInformation15? CoverCorrection { get; init; } 
    #else
    public SettlementInformation15? CoverCorrection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
