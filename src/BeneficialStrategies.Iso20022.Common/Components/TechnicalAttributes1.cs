// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies technical attributes of the message.
/// </summary>
[IsoId("_tEyDAISIEeW47-F5RGn37Q")]
[DisplayName("Technical Attributes")]
public record TechnicalAttributes1
{
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_4ErfEISIEeW47-F5RGn37Q")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public Reconciliation1Code? ReconciliationFlag { get; init; }
}
