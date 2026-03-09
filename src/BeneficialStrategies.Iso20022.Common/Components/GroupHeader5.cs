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
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_PuTKDNp-Ed-ak6NoX_4Aeg_-727666484")]
[DisplayName("Group Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GroupHeader5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GroupHeader5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GroupHeader5( System.String reqMessageIdentification,System.DateTime reqCreationDateTime )
    {
        MessageIdentification = reqMessageIdentification;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PuTKDdp-Ed-ak6NoX_4Aeg_-727666466")]
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
    /// Date and time at which the status report was created by the instructing party.
    /// </summary>
    [IsoId("_PuTKDtp-Ed-ak6NoX_4Aeg_-727666424")]
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
    /// Party initiating the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or the party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_Puc7ANp-Ed-ak6NoX_4Aeg_-727665536")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? InitiatingParty { get; init; } 
    #else
    public PartyIdentification8? InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain.
    /// </summary>
    [IsoId("_Puc7Adp-Ed-ak6NoX_4Aeg_-727665579")]
    [DisplayName("Forwarding Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwdgAgt")]
    #endif
    [IsoXmlTag("FwdgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Puc7Atp-Ed-ak6NoX_4Aeg_-727665890")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Puc7A9p-Ed-ak6NoX_4Aeg_-727665848")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Puc7BNp-Ed-ak6NoX_4Aeg_-727665985")]
    [DisplayName("Instructing Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgt")]
    #endif
    [IsoXmlTag("InstgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Puc7Bdp-Ed-ak6NoX_4Aeg_-727666020")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
