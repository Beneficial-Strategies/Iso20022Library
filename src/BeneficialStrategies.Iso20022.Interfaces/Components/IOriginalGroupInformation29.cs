// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
[IsoId("_bVQMQdwYEee0mvR9H3APRg")]
public interface IOriginalGroupInformation29 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original message.
    /// </summary>
    [IsoId("_bmgUUdwYEee0mvR9H3APRg")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    Max35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, for example, pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_bmgUU9wYEee0mvR9H3APRg")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    Max35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_bmgUVdwYEee0mvR9H3APRg")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    ISODateTime? OriginalCreationDateTime { get; }
}
