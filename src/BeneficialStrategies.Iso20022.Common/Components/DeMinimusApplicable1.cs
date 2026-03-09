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
/// Conditions applicable when the investor is covered by the &quot;de minimis&quot; exemption.
/// </summary>
[IsoId("_RSSsUNp-Ed-ak6NoX_4Aeg_-1126394129")]
[DisplayName("De Minimus Applicable")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeMinimusApplicable1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeMinimusApplicable1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeMinimusApplicable1( System.String reqNewIssuePermission )
    {
        NewIssuePermission = reqNewIssuePermission;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor permits its beneficial owners that are restricted persons, if any, to participate in profits and losses allocated to the investor that are attribute to new issue securities.
    /// </summary>
    [IsoId("_RSSsUdp-Ed-ak6NoX_4Aeg_-1045122513")]
    [DisplayName("New Issue Permission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewIssePrmssn")]
    #endif
    [IsoXmlTag("NewIssePrmssn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator NewIssuePermission { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NewIssuePermission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NewIssuePermission { get; init; } 
    #else
    public System.String NewIssuePermission { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the new issue profits and losses that it receives to beneficial owners that are restricted persons.
    /// </summary>
    [IsoId("_RSSsUtp-Ed-ak6NoX_4Aeg_-1042351920")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Percentage { get; init; } 
    #else
    public System.Decimal? Percentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
