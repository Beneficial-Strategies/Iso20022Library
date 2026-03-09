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
[IsoId("_YW0-0W49EeiU9cctagi5ow")]
[DisplayName("Currency Control Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlHeader6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyControlHeader6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlHeader6( System.String reqMessageIdentification,System.DateTime reqCreationDateTime,System.String reqNumberOfItems,PartyIdentification135 reqReceivingParty,BranchAndFinancialInstitutionIdentification6 reqRegistrationAgent )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
        NumberOfItems = reqNumberOfItems;
        ReceivingParty = reqReceivingParty;
        RegistrationAgent = reqRegistrationAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_YggfQW49EeiU9cctagi5ow")]
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
    [IsoId("_YggfQ249EeiU9cctagi5ow")]
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
    [IsoId("_YggfRW49EeiU9cctagi5ow")]
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
    /// Party that receives the message.
    /// </summary>
    [IsoId("_YggfR249EeiU9cctagi5ow")]
    [DisplayName("Receiving Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgPty")]
    #endif
    [IsoXmlTag("RcvgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 ReceivingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 ReceivingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 ReceivingParty { get; init; } 
    #else
    public PartyIdentification135 ReceivingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Agent which sends the message.
    /// </summary>
    [IsoId("_YggfSW49EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAgt")]
    #endif
    [IsoXmlTag("RegnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
