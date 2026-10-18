// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
[IsoId("_PhL7Htp-Ed-ak6NoX_4Aeg_1562111657")]
public interface IOriginalGroupInformation3 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_PhL7H9p-Ed-ak6NoX_4Aeg_1562112141")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    IsoMax35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, eg, pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_PhVsENp-Ed-ak6NoX_4Aeg_1562112527")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    IsoMax35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_PhVsEdp-Ed-ak6NoX_4Aeg_-1535886012")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    IsoISODateTime? OriginalCreationDateTime { get; }
}
