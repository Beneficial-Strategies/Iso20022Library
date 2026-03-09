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
/// Defines the criteria to extract the message(s) which should be resent.
/// </summary>
[IsoId("_jJzloO5NEeCisYr99QEiWA_840208955")]
[DisplayName("Resend Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResendSearchCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ResendSearchCriteria1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResendSearchCriteria1( PartyIdentification71Choice_ reqRecipient )
    {
        Recipient = reqRecipient;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the business day of the requested messages the resend function is used for.
    /// </summary>
    [IsoId("_jJzloe5NEeCisYr99QEiWA_2072733843")]
    [DisplayName("Business Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizDt")]
    #endif
    [IsoXmlTag("BizDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BusinessDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BusinessDate { get; init; } 
    #else
    public System.DateOnly? BusinessDate { get; set; } 
    #endif
    
    /// <summary>
    /// Independent counter for message sequence, which is available once per party technical address.|Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_jJzlou5NEeCisYr99QEiWA_-1176991045")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguously identifies the original business message, which was delivered by the business sender.
    /// </summary>
    [IsoId("_hdq1QGliEeGaMcKyqKNRfQ_1962590125")]
    [DisplayName("Original Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgNmId")]
    #endif
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalMessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalMessageNameIdentification { get; init; } 
    #else
    public System.String? OriginalMessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    [IsoId("_jJzlo-5NEeCisYr99QEiWA_-595981789")]
    [DisplayName("File Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FileRef")]
    #endif
    [IsoXmlTag("FileRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FileReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FileReference { get; init; } 
    #else
    public System.String? FileReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to unambiguously identify the recipient of the report message.
    /// </summary>
    [IsoId("_jJzlpO5NEeCisYr99QEiWA_-493610823")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification71Choice_ Recipient { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification71Choice_ Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_ Recipient { get; init; } 
    #else
    public PartyIdentification71Choice_ Recipient { get; set; } 
    #endif
    
    
    #nullable disable
    
}
