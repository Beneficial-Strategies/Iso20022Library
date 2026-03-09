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
/// Set of characteristics related to the transfer of transactions.
/// </summary>
[IsoId("_d7nnwAJXEeS2H9l84F_isg")]
[DisplayName("Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Header23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Header23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Header23( System.String reqFormatVersion,System.String reqExchangeIdentification,GenericIdentification32 reqInitiatingParty,System.UInt64 reqMessageSequenceNumber,System.DateTime reqCreationDateTime )
    {
        FormatVersion = reqFormatVersion;
        ExchangeIdentification = reqExchangeIdentification;
        InitiatingParty = reqInitiatingParty;
        MessageSequenceNumber = reqMessageSequenceNumber;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_eMpGUwJXEeS2H9l84F_isg")]
    [DisplayName("Format Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrmtVrsn")]
    #endif
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax6Text FormatVersion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FormatVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FormatVersion { get; init; } 
    #else
    public System.String FormatVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_eMpGVQJXEeS2H9l84F_isg")]
    [DisplayName("Exchange Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgId")]
    #endif
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeIdentification { get; init; } 
    #else
    public System.String ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_eMpGWQJXEeS2H9l84F_isg")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification32 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification32 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32 InitiatingParty { get; init; } 
    #else
    public GenericIdentification32 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_eMptYQJXEeS2H9l84F_isg")]
    [DisplayName("Recipient Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptPty")]
    #endif
    [IsoXmlTag("RcptPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? RecipientParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? RecipientParty { get; init; } 
    #else
    public GenericIdentification32? RecipientParty { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of this message in a conversation in integer.
    /// </summary>
    [IsoId("_waUXsAJXEeS2H9l84F_isg")]
    [DisplayName("Message Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgSeqNb")]
    #endif
    [IsoXmlTag("MsgSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber MessageSequenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 MessageSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 MessageSequenceNumber { get; init; } 
    #else
    public System.UInt64 MessageSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_eMpGVwJXEeS2H9l84F_isg")]
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
