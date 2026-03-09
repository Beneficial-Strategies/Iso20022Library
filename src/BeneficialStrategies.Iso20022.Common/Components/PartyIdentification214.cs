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
/// Identification of a party.
/// </summary>
[IsoId("_AQe65TqWEemL_ewJY9QP1g")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification214
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification214 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification214( PartyIdentification203Choice_ reqIdentification,System.String reqRecipientName,PartyAddress1 reqResponseRecipientAddress )
    {
        Identification = reqIdentification;
        RecipientName = reqRecipientName;
        ResponseRecipientAddress = reqResponseRecipientAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party to which the disclosure response must be sent.
    /// </summary>
    [IsoId("_LVUjYFSXEempisJfoIfvvQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification203Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification203Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification203Choice_ Identification { get; init; } 
    #else
    public PartyIdentification203Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the party to which the disclosure response must be sent.
    /// </summary>
    [IsoId("_rh-REFSXEempisJfoIfvvQ")]
    [DisplayName("Recipient Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptNm")]
    #endif
    [IsoXmlTag("RcptNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text RecipientName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RecipientName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RecipientName { get; init; } 
    #else
    public System.String RecipientName { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the party to which the disclosure response must be sent.
    /// </summary>
    [IsoId("_Evtr4FSYEempisJfoIfvvQ")]
    [DisplayName("Response Recipient Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnRcptAdr")]
    #endif
    [IsoXmlTag("RspnRcptAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyAddress1 ResponseRecipientAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyAddress1 ResponseRecipientAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAddress1 ResponseRecipientAddress { get; init; } 
    #else
    public PartyAddress1 ResponseRecipientAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
