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
/// Represents the assignment of a case to a party.
/// </summary>
[IsoId("_HIRcwbTgEeef0oKPLRNatg")]
[DisplayName("Case Assignment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CaseAssignment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CaseAssignment4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CaseAssignment4( System.String reqIdentification,Party35Choice_ reqAssigner,Party35Choice_ reqAssignee,System.DateTime reqCreationDateTime )
    {
        Identification = reqIdentification;
        Assigner = reqAssigner;
        Assignee = reqAssignee;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_HQTXYbTgEeef0oKPLRNatg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party who assigns the case. |Usage: This is also the sender of the message.
    /// </summary>
    [IsoId("_HQTXY7TgEeef0oKPLRNatg")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party35Choice_ Assigner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party35Choice_ Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party35Choice_ Assigner { get; init; } 
    #else
    public Party35Choice_ Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the receiver of the message.
    /// </summary>
    [IsoId("_HQTXZbTgEeef0oKPLRNatg")]
    [DisplayName("Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgne")]
    #endif
    [IsoXmlTag("Assgne")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party35Choice_ Assignee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party35Choice_ Assignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party35Choice_ Assignee { get; init; } 
    #else
    public Party35Choice_ Assignee { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the assignment was created.
    /// </summary>
    [IsoId("_HQTXZ7TgEeef0oKPLRNatg")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
