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
/// Set of characteristics related to the reject of a transaction.
/// </summary>
[IsoId("_IJl-sY4BEeWrZqsymMFdfg")]
[DisplayName("Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Header28
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Header28 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Header28( System.String reqDownloadTransfer,System.String reqFormatVersion,System.DateTime reqCreationDateTime )
    {
        DownloadTransfer = reqDownloadTransfer;
        FormatVersion = reqFormatVersion;
        CreationDateTime = reqCreationDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    [IsoId("_IVN_4Y4BEeWrZqsymMFdfg")]
    [DisplayName("Download Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DwnldTrf")]
    #endif
    [IsoXmlTag("DwnldTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DownloadTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DownloadTransfer { get; init; } 
    #else
    public System.String DownloadTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_IVN_444BEeWrZqsymMFdfg")]
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
    [IsoId("_IVN_5Y4BEeWrZqsymMFdfg")]
    [DisplayName("Exchange Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgId")]
    #endif
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ExchangeIdentification { get; init; } 
    #else
    public System.UInt64? ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_IVN_544BEeWrZqsymMFdfg")]
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
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_IVN_6Y4BEeWrZqsymMFdfg")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification71? InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71? InitiatingParty { get; init; } 
    #else
    public GenericIdentification71? InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_IVN_644BEeWrZqsymMFdfg")]
    [DisplayName("Recipient Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptPty")]
    #endif
    [IsoXmlTag("RcptPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification92? RecipientParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification92? RecipientParty { get; init; } 
    #else
    public GenericIdentification92? RecipientParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
