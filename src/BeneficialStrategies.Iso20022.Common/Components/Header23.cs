// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the transfer of transactions.
/// </summary>
[IsoId("_d7nnwAJXEeS2H9l84F_isg")]
[DisplayName("Header")]
public partial record Header23
{
    #nullable enable
    
    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_eMpGUwJXEeS2H9l84F_isg")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public required IsoMax6Text FormatVersion { get; init; } 
    
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_eMpGVQJXEeS2H9l84F_isg")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_eMpGWQJXEeS2H9l84F_isg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification32 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_eMptYQJXEeS2H9l84F_isg")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification32? RecipientParty { get; init; } 
    
    /// <summary>
    /// Sequence of this message in a conversation in integer.
    /// </summary>
    [IsoId("_waUXsAJXEeS2H9l84F_isg")]
    [DisplayName("Message Sequence Number")]
    [IsoXmlTag("MsgSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber MessageSequenceNumber { get; init; } 
    
    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_eMpGVwJXEeS2H9l84F_isg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    
    #nullable disable
    
}
