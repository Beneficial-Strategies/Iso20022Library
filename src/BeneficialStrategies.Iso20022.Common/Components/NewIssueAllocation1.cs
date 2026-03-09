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
/// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
/// </summary>
[IsoId("_TUE97Np-Ed-ak6NoX_4Aeg_932071403")]
[DisplayName("New Issue Allocation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NewIssueAllocation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NewIssueAllocation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NewIssueAllocation1( System.String reqRestricted )
    {
        Restricted = reqRestricted;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor is eligible to participate in the profits and losses from a new issue.
    /// </summary>
    [IsoId("_TUE97dp-Ed-ak6NoX_4Aeg_1017959443")]
    [DisplayName("Restricted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctd")]
    #endif
    [IsoXmlTag("Rstrctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Restricted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Restricted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Restricted { get; init; } 
    #else
    public System.String Restricted { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for exemption.
    /// </summary>
    [IsoId("_TUOu4Np-Ed-ak6NoX_4Aeg_1035504314")]
    [DisplayName("Exempt Person Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptPrsnRsn")]
    #endif
    [IsoXmlTag("XmptPrsnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ExemptPersonReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExemptPersonReason { get; init; } 
    #else
    public System.String? ExemptPersonReason { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions applicable when the investor is covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_TUOu4dp-Ed-ak6NoX_4Aeg_-197331579")]
    [DisplayName("De Minimus Applicable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeMnmsAplbl")]
    #endif
    [IsoXmlTag("DeMnmsAplbl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeMinimusApplicable1? DeMinimusApplicable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeMinimusApplicable1? DeMinimusApplicable { get; init; } 
    #else
    public DeMinimusApplicable1? DeMinimusApplicable { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions applicable when the investor is not covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_TUOu4tp-Ed-ak6NoX_4Aeg_158223027")]
    [DisplayName("De Minimus Not Applicable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeMnmsNotAplbl")]
    #endif
    [IsoXmlTag("DeMnmsNotAplbl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeMinimusNotApplicable1? DeMinimusNotApplicable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeMinimusNotApplicable1? DeMinimusNotApplicable { get; init; } 
    #else
    public DeMinimusNotApplicable1? DeMinimusNotApplicable { get; set; } 
    #endif
    
    
    #nullable disable
    
}
