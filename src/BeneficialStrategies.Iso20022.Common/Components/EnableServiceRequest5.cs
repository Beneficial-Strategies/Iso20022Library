// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request to enable a service.
/// </summary>
[IsoId("_a-vQwXGxEe2TbaNWBpRZpQ")]
[DisplayName("Enable Service Request")]
public record EnableServiceRequest5
{
    /// <summary>
    /// Action to realise on a transaction.
    /// </summary>
    [IsoId("_bFZSYXGxEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Action")]
    [IsoXmlTag("TxActn")]
    public required TransactionAction1Code TransactionAction { get; init; }

    /// <summary>
    /// Services enabled before the start-up of a transaction.
    /// </summary>
    [IsoId("_bFZSY3GxEe2TbaNWBpRZpQ")]
    [DisplayName("Services Enabled")]
    [IsoXmlTag("SvcsNbld")]
    public RetailerService2Code? ServicesEnabled { get; init; }

    /// <summary>
    /// Prompt or welcome message.
    /// </summary>
    [IsoId("_bFZSZXGxEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage10? DisplayOutput { get; init; }
}
