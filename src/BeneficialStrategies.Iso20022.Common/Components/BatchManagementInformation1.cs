// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements of identification of a batch management transaction.
/// </summary>
[IsoId("_A7J8gEBbEeepk8PtnyIgsg")]
[DisplayName("Batch Management Information")]
public record BatchManagementInformation1
{
    /// <summary>
    /// Identification of the collection to which the batch belongs.
    /// ISO 8583:2003 bit 69-2
    /// </summary>
    [IsoId("_NBPkkEBbEeepk8PtnyIgsg")]
    [DisplayName("Collection Identification")]
    [IsoXmlTag("ColltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CollectionIdentification { get; init; }

    /// <summary>
    /// Identification of the batch to which the message belongs.
    /// ISO 8583:2003 bit 69-2
    /// </summary>
    [IsoId("_QZUToEBbEeepk8PtnyIgsg")]
    [DisplayName("Batch Identification")]
    [IsoXmlTag("BtchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text BatchIdentification { get; init; }

    /// <summary>
    /// Sequence number of the message inside the batch.
    /// ISO 8583:87/93 bit 71
    /// ISO 8583:2003 bit 68-2
    /// </summary>
    [IsoId("_aLfYUEBbEeepk8PtnyIgsg")]
    [DisplayName("Message Sequence Number")]
    [IsoXmlTag("MsgSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? MessageSequenceNumber { get; init; }

    /// <summary>
    /// Value of the message to use for the computation of the checksum of the batch or collection of messages.
    /// </summary>
    [IsoId("_0gZPgEBbEeepk8PtnyIgsg")]
    [DisplayName("Message Checksum Input Value")]
    [IsoXmlTag("MsgChcksmInptVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? MessageChecksumInputValue { get; init; }
}
