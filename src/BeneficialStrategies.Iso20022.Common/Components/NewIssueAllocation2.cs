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
[IsoId("_0BdZcQgpEeSUG-8hqXsVMQ")]
[DisplayName("New Issue Allocation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NewIssueAllocation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NewIssueAllocation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NewIssueAllocation2( System.String reqRestricted )
    {
        Restricted = reqRestricted;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor is eligible to participate in the profits and losses from a new issue.
    /// </summary>
    [IsoId("_0cGHAwgpEeSUG-8hqXsVMQ")]
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
    [IsoId("_0cGHBQgpEeSUG-8hqXsVMQ")]
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
    [IsoId("_7u93sAgpEeSUG-8hqXsVMQ")]
    [DisplayName("De Minimus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeMnms")]
    #endif
    [IsoXmlTag("DeMnms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeMinimus1Choice_? DeMinimus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeMinimus1Choice_? DeMinimus { get; init; } 
    #else
    public DeMinimus1Choice_? DeMinimus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
