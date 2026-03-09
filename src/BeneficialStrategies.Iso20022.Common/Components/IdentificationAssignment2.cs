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
/// Provides the details of the identification assignment.
/// </summary>
[IsoId("_tpGiYVkyEeGeoaLUQk__nA_757109061")]
[DisplayName("Identification Assignment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IdentificationAssignment2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IdentificationAssignment2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IdentificationAssignment2( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,Party12Choice_ reqAssigner,Party12Choice_ reqAssignee )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        Assigner = reqAssigner;
        Assignee = reqAssignee;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the assigner, and sent to the next party in the chain to unambiguously identify the message.
    /// Usage: The assigner has to make sure that MessageIdentification is unique per assignee for a pre-agreed period.
    /// </summary>
    [IsoId("_tpGiYlkyEeGeoaLUQk__nA_-239963292")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the identification assignment was created.
    /// </summary>
    [IsoId("_tpGiY1kyEeGeoaLUQk__nA_-1350874711")]
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
    
    /// <summary>
    /// Party that created the identification assignment.
    /// </summary>
    [IsoId("_tpGiZFkyEeGeoaLUQk__nA_1013268714")]
    [DisplayName("Creator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cretr")]
    #endif
    [IsoXmlTag("Cretr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party12Choice_? Creator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party12Choice_? Creator { get; init; } 
    #else
    public Party12Choice_? Creator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the first agent in the identification chain, following the payment initiating party.
    /// </summary>
    [IsoId("_tpQTYFkyEeGeoaLUQk__nA_-597652062")]
    [DisplayName("First Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAgt")]
    #endif
    [IsoXmlTag("FrstAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? FirstAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? FirstAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? FirstAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party that assigns the identification assignment to another party. This is also the sender of the message.
    /// </summary>
    [IsoId("_tpQTYVkyEeGeoaLUQk__nA_-1094715058")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party12Choice_ Assigner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party12Choice_ Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party12Choice_ Assigner { get; init; } 
    #else
    public Party12Choice_ Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Party that the identification assignment is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_tpQTYlkyEeGeoaLUQk__nA_322874245")]
    [DisplayName("Assignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgne")]
    #endif
    [IsoXmlTag("Assgne")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party12Choice_ Assignee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party12Choice_ Assignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party12Choice_ Assignee { get; init; } 
    #else
    public Party12Choice_ Assignee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
