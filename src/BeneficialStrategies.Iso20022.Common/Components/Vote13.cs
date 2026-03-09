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
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_d3vDAbqPEemCAOifqHrKJw")]
[DisplayName("Vote")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vote13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vote13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vote13( System.String reqIssuerLabel )
    {
        IssuerLabel = reqIssuerLabel;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_eJb3A7qPEemCAOifqHrKJw")]
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
    [IsoId("_eJb3BbqPEemCAOifqHrKJw")]
    [DisplayName("For")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="For")]
    #endif
    [IsoXmlTag("For")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? For { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? For { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_eJb3B7qPEemCAOifqHrKJw")]
    [DisplayName("Against")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agnst")]
    #endif
    [IsoXmlTag("Agnst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Against { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Against { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes expressed as abstain for one resolution.
    /// </summary>
    [IsoId("_eJb3CbqPEemCAOifqHrKJw")]
    [DisplayName("Abstain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Abstn")]
    #endif
    [IsoXmlTag("Abstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Abstain { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Abstain { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes withheld for one resolution.
    /// </summary>
    [IsoId("_eJb3C7qPEemCAOifqHrKJw")]
    [DisplayName("Withhold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wthhld")]
    #endif
    [IsoXmlTag("Wthhld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Withhold { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Withhold { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in line with the votes of the management.
    /// </summary>
    [IsoId("_eJb3DbqPEemCAOifqHrKJw")]
    [DisplayName("With Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WthMgmt")]
    #endif
    [IsoXmlTag("WthMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? WithManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes against the voting recommendation of the management.
    /// </summary>
    [IsoId("_eJb3D7qPEemCAOifqHrKJw")]
    [DisplayName("Against Management")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgnstMgmt")]
    #endif
    [IsoXmlTag("AgnstMgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? AgainstManagement { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which decision is left to the party that will exercise the voting right.
    /// </summary>
    [IsoId("_eJb3EbqPEemCAOifqHrKJw")]
    [DisplayName("Discretionary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dscrtnry")]
    #endif
    [IsoXmlTag("Dscrtnry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Discretionary { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour for one year for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_eJb3E7qPEemCAOifqHrKJw")]
    [DisplayName("One Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OneYr")]
    #endif
    [IsoXmlTag("OneYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? OneYear { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? OneYear { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of two years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_eJb3FbqPEemCAOifqHrKJw")]
    [DisplayName("Two Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwoYrs")]
    #endif
    [IsoXmlTag("TwoYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? TwoYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes in favour of three years for &quot;say on pay&quot; type of resolution.
    /// </summary>
    [IsoId("_eJb3F7qPEemCAOifqHrKJw")]
    [DisplayName("Three Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThreeYrs")]
    #endif
    [IsoXmlTag("ThreeYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? ThreeYears { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_eJb3GbqPEemCAOifqHrKJw")]
    [DisplayName("No Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoActn")]
    #endif
    [IsoXmlTag("NoActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? NoAction { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? NoAction { get; set; } 
    #endif
    
    /// <summary>
    /// Vote is cast as empty but the vote is counted.
    /// </summary>
    [IsoId("_i8XagLqPEemCAOifqHrKJw")]
    [DisplayName("Blank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Blnk")]
    #endif
    [IsoXmlTag("Blnk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? Blank { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? Blank { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of vote expressed as a proprietary code.
    /// </summary>
    [IsoId("_yEAvELqPEemCAOifqHrKJw")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [MinLength(0)]
    [MaxLength(4)]
    public ValueList<ProprietaryVote2> Proprietary { get; init; } = new ValueList<ProprietaryVote2>(){};
    
    /// <summary>
    /// Indicates the resolution was withdrawn at the meeting.
    /// </summary>
    [IsoId("_eJb3G7qPEemCAOifqHrKJw")]
    [DisplayName("Withdrawn")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wdrwn")]
    #endif
    [IsoXmlTag("Wdrwn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Withdrawn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Withdrawn { get; init; } 
    #else
    public System.String? Withdrawn { get; set; } 
    #endif
    
    
    #nullable disable
    
}
