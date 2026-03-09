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
/// Status of a case resulting from a case assignment.
/// </summary>
[IsoId("_VJDihdp-Ed-ak6NoX_4Aeg_92437135")]
[DisplayName("Case Forwarding Notification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CaseForwardingNotification
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CaseForwardingNotification instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CaseForwardingNotification( CaseForwardingNotification1Code reqJustification )
    {
        Justification = reqJustification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Justification for the forward action.
    /// </summary>
    [IsoId("_VJDihtp-Ed-ak6NoX_4Aeg_172785479")]
    [DisplayName("Justification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Justfn")]
    #endif
    [IsoXmlTag("Justfn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseForwardingNotification1Code Justification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CaseForwardingNotification1Code Justification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseForwardingNotification1Code Justification { get; init; } 
    #else
    public CaseForwardingNotification1Code Justification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
