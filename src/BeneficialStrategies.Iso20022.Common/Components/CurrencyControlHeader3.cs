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
/// Characteristics shared by all individual items included in the currency control message.
/// </summary>
[IsoId("_7l1ydjm6EeWDb47rJ6ki4Q")]
[DisplayName("Currency Control Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlHeader3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyControlHeader3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlHeader3( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,System.String reqNumberOfItems,Party28Choice_ reqInitiatingParty )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        NumberOfItems = reqNumberOfItems;
        InitiatingParty = reqInitiatingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_7l1ydzm6EeWDb47rJ6ki4Q")]
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
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_7l1yejm6EeWDb47rJ6ki4Q")]
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
    /// Number of individual items contained in the message.
    /// </summary>
    [IsoId("_7l1yezm6EeWDb47rJ6ki4Q")]
    [DisplayName("Number Of Items")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfItms")]
    #endif
    [IsoXmlTag("NbOfItms")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText NumberOfItems { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfItems { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfItems { get; init; } 
    #else
    public System.String NumberOfItems { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the instruction.
    /// </summary>
    [IsoId("_7l1yeDm6EeWDb47rJ6ki4Q")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party28Choice_ InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party28Choice_ InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party28Choice_ InitiatingParty { get; init; } 
    #else
    public Party28Choice_ InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Agent which forwards the message.
    /// </summary>
    [IsoId("_7l1yeTm6EeWDb47rJ6ki4Q")]
    [DisplayName("Forwarding Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwdgAgt")]
    #endif
    [IsoXmlTag("FwdgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
