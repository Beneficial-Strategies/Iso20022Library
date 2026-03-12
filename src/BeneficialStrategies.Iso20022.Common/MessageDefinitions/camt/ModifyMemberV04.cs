// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.015.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ModifyMember message is sent by a member to the transaction administrator.
/// It is used to request modifications to the static data related to the profile of a member that the transaction administrator maintains.
/// Usage
/// The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can, refer to information about the membership of the system.
/// At any time during the operating hours of the system, the member can request the transaction administrator to modify the information it maintains about the member.
/// The member will submit a message requesting modifications in one or more of the following criteria:
/// - identification of the member
/// - contact information for the member organization: postal address, e-mail address, telephone or fax number
/// - identification of contact persons for the member, their role and/or details (postal address, e-mail address, telephone or fax number)
/// Based on the criteria received within the Modify Member message, the transaction administrator will execute or reject the requested modifications.
/// In principle, the transaction administrator may send a Receipt message as a reply to the ModifyMember request. To verify the outcome of the request, the member may submit a GetMember message with the appropriate search criteria.
/// </summary>
[Description(@"Scope|The ModifyMember message is sent by a member to the transaction administrator.|It is used to request modifications to the static data related to the profile of a member that the transaction administrator maintains.|Usage|The transaction administrator is in charge of providing the members with business information. The term business information covers all information related to the management of the system, that is, not related to the transactions entered into the system. The type of business information available can vary depending on the system. Among other things, it can, refer to information about the membership of the system.|At any time during the operating hours of the system, the member can request the transaction administrator to modify the information it maintains about the member.|The member will submit a message requesting modifications in one or more of the following criteria:|- identification of the member|- contact information for the member organization: postal address, e-mail address, telephone or fax number|- identification of contact persons for the member, their role and/or details (postal address, e-mail address, telephone or fax number)|Based on the criteria received within the Modify Member message, the transaction administrator will execute or reject the requested modifications.|In principle, the transaction administrator may send a Receipt message as a reply to the ModifyMember request. To verify the outcome of the request, the member may submit a GetMember message with the appropriate search criteria.")]
[IsoId("_jwlbxxbvEeiyVv5j1vf1VQ")]
[DisplayName("Modify Member V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModifyMemberV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.015.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ModfyMmb";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.015.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModifyMemberV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModifyMemberV04( MessageHeader1 reqMessageHeader,MemberIdentification3Choice_ reqMemberIdentification,Member6 reqNewMemberValueSet )
    {
        MessageHeader = reqMessageHeader;
        MemberIdentification = reqMemberIdentification;
        NewMemberValueSet = reqNewMemberValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jwlbyxbvEeiyVv5j1vf1VQ")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader1 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1 MessageHeader { get; init; } 
    #else
    public MessageHeader1 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a system member, as assigned by the system, or the system administrator.
    /// </summary>
    [IsoId("_jwlbzRbvEeiyVv5j1vf1VQ")]
    [DisplayName("Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbId")]
    #endif
    [IsoXmlTag("MmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MemberIdentification3Choice_ MemberIdentification { get; init; } 
    #else
    public MemberIdentification3Choice_ MemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New member values.
    /// </summary>
    [IsoId("_jwlbzxbvEeiyVv5j1vf1VQ")]
    [DisplayName("New Member Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewMmbValSet")]
    #endif
    [IsoXmlTag("NewMmbValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Member6 NewMemberValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Member6 NewMemberValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Member6 NewMemberValueSet { get; init; } 
    #else
    public Member6 NewMemberValueSet { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jwlb0RbvEeiyVv5j1vf1VQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ModifyMemberV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ModifyMemberV04.

