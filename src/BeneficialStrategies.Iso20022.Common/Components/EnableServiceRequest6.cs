// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Enable Service Request6.
/// </summary>
[IsoId("_B8BpYZFHEe6reqfAp4CunQ")]
[DisplayName("Enable Service Request6")]
public record EnableServiceRequest6
{
    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage11? DisplayOutput { get; init; }

    /// <summary>
    /// Services Enabled.
    /// </summary>
    [DisplayName("Services Enabled")]
    [IsoXmlTag("SvcsNbld")]
    public RetailerService2Code? ServicesEnabled { get; init; }

    /// <summary>
    /// Transaction Action.
    /// </summary>
    [DisplayName("Transaction Action")]
    [IsoXmlTag("TxActn")]
    public required TransactionAction1Code TransactionAction { get; init; }
}
