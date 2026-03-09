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
/// Indicates the number of voting rights cast to a resolution.
/// </summary>
[IsoId("_T5VABdp-Ed-ak6NoX_4Aeg_-129713306")]
[DisplayName("Vote")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vote5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vote5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vote5( System.String reqIssuerLabel,System.String reqAccepted )
    {
        IssuerLabel = reqIssuerLabel;
        Accepted = reqAccepted;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_T5VABtp-Ed-ak6NoX_4Aeg_-129712899")]
    [DisplayName("Issuer Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrLabl")]
    #endif
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IssuerLabel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerLabel { get; init; } 
    #else
    public System.String IssuerLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether a resolution is accepted or not.
    /// </summary>
    [IsoId("_T5VAB9p-Ed-ak6NoX_4Aeg_-129712548")]
    [DisplayName("Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Accptd")]
    #endif
    [IsoXmlTag("Accptd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Accepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Accepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Accepted { get; init; } 
    #else
    public System.String Accepted { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_T5VACNp-Ed-ak6NoX_4Aeg_-129712633")]
    [DisplayName("For")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="For")]
    #endif
    [IsoXmlTag("For")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? For { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? For { get; init; } 
    #else
    public System.UInt64? For { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_T5VACdp-Ed-ak6NoX_4Aeg_-129712608")]
    [DisplayName("Against")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agnst")]
    #endif
    [IsoXmlTag("Agnst")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Against { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Against { get; init; } 
    #else
    public System.UInt64? Against { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes expressed as abstain.
    /// </summary>
    [IsoId("_T5VACtp-Ed-ak6NoX_4Aeg_-129712591")]
    [DisplayName("Abstain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Abstn")]
    #endif
    [IsoXmlTag("Abstn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Abstain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Abstain { get; init; } 
    #else
    public System.UInt64? Abstain { get; set; } 
    #endif
    
    /// <summary>
    /// Total votes withheld, eg in the case where a shareholder wishes not to endorse the election of a board member.
    /// </summary>
    [IsoId("_T5exANp-Ed-ak6NoX_4Aeg_-129712573")]
    [DisplayName("Withhold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wthhld")]
    #endif
    [IsoXmlTag("Wthhld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Withhold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Withhold { get; init; } 
    #else
    public System.UInt64? Withhold { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_T5exAdp-Ed-ak6NoX_4Aeg_223997005")]
    [DisplayName("No Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoActn")]
    #endif
    [IsoXmlTag("NoActn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NoAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NoAction { get; init; } 
    #else
    public System.UInt64? NoAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
