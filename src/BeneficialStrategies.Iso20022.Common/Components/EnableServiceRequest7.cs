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
[IsoId("_NU5A4bZdEfCUZfsQO4rYeA")]
[DisplayName("Enable Service Request7")]
public record EnableServiceRequest7
{
    /// <summary>
    /// Action to realise on a transaction.
    /// </summary>
    [IsoId("_NWIXBbZdEfCUZfsQO4rYeA")]
    [DisplayName("Transaction Action")]
    [IsoXmlTag("TxActn")]
    public required TransactionAction1Code TransactionAction { get; init; }

    /// <summary>
    /// Services enabled before the start-up of a transaction.
    /// </summary>
    [IsoId("_NWIXC7ZdEfCUZfsQO4rYeA")]
    [DisplayName("Services Enabled")]
    [IsoXmlTag("SvcsNbld")]
    public RetailerService2Code? ServicesEnabled { get; init; }

    /// <summary>
    /// Prompt or welcome message.
    /// </summary>
    [IsoId("_NWIXEbZdEfCUZfsQO4rYeA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage12? DisplayOutput { get; init; }
}
