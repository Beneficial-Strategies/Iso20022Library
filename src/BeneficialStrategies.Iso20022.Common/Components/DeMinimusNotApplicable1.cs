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
/// Conditions applicable when the investor is not covered by the &quot;de minimis&quot; exemption.
/// </summary>
[IsoId("_RSI7WNp-Ed-ak6NoX_4Aeg_88957855")]
[DisplayName("De Minimus Not Applicable")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeMinimusNotApplicable1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeMinimusNotApplicable1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeMinimusNotApplicable1( System.String reqRestrictedPersonReason )
    {
        RestrictedPersonReason = reqRestrictedPersonReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the restricted person.
    /// </summary>
    [IsoId("_RSI7Wdp-Ed-ak6NoX_4Aeg_491616181")]
    [DisplayName("Restricted Person Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctdPrsnRsn")]
    #endif
    [IsoXmlTag("RstrctdPrsnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text RestrictedPersonReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RestrictedPersonReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RestrictedPersonReason { get; init; } 
    #else
    public System.String RestrictedPersonReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
