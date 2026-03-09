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
/// Decision of the voting party for one resolution. Several types of decisions can be indicated to allow for split vote specification.
/// </summary>
[IsoId("_iNq0x166EeSjaerr_EM7AQ")]
[DisplayName("Vote")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vote8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vote8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vote8( System.String reqIssuerLabel )
    {
        IssuerLabel = reqIssuerLabel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_ipWEI166EeSjaerr_EM7AQ")]
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
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_ipWEJV66EeSjaerr_EM7AQ")]
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
    [IsoId("_ipWEJ166EeSjaerr_EM7AQ")]
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
    /// Number of votes expressed as abstain for one resolution.
    /// </summary>
    [IsoId("_ipWEKV66EeSjaerr_EM7AQ")]
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
    /// Number of votes withheld for one resolution.
    /// </summary>
    [IsoId("_ipWEK166EeSjaerr_EM7AQ")]
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
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_ipWELV66EeSjaerr_EM7AQ")]
    [DisplayName("With Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WthMgmt")]
    #endif
    [IsoXmlTag("WthMgmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? WithManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WithManagement { get; init; } 
    #else
    public System.UInt64? WithManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_ipWEL166EeSjaerr_EM7AQ")]
    [DisplayName("Against Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgnstMgmt")]
    #endif
    [IsoXmlTag("AgnstMgmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? AgainstManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AgainstManagement { get; init; } 
    #else
    public System.UInt64? AgainstManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_ipWEMV66EeSjaerr_EM7AQ")]
    [DisplayName("Discretionary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dscrtnry")]
    #endif
    [IsoXmlTag("Dscrtnry")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Discretionary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Discretionary { get; init; } 
    #else
    public System.UInt64? Discretionary { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_8KEsYF66EeSjaerr_EM7AQ")]
    [DisplayName("One Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneYr")]
    #endif
    [IsoXmlTag("OneYr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? OneYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OneYear { get; init; } 
    #else
    public System.UInt64? OneYear { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_SgHhUF67EeSjaerr_EM7AQ")]
    [DisplayName("Two Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoYrs")]
    #endif
    [IsoXmlTag("TwoYrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TwoYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TwoYears { get; init; } 
    #else
    public System.UInt64? TwoYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_aA05sF67EeSjaerr_EM7AQ")]
    [DisplayName("Three Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThreeYrs")]
    #endif
    [IsoXmlTag("ThreeYrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ThreeYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ThreeYears { get; init; } 
    #else
    public System.UInt64? ThreeYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_ipWEM166EeSjaerr_EM7AQ")]
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
