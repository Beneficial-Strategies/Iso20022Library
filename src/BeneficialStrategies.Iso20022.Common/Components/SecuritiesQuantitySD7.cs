// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
[IsoId("_YsBOUQCnEeqouY-yI_q3qQ")]
[DisplayName("Securities Quantity SD")]
public record SecuritiesQuantitySD7
{
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    [IsoId("_ZAQY9QCnEeqouY-yI_q3qQ")]
    [DisplayName("Total Oversubscription Quantity")]
    [IsoXmlTag("TtlOvrsbcptQty")]
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; }

    /// <summary>
    /// Quantity covered but transactions not in &quot;MADE&quot; status.
    /// </summary>
    [IsoId("_ZAQY9wCnEeqouY-yI_q3qQ")]
    [DisplayName("Interim Covered Quantity")]
    [IsoXmlTag("IntrmCvrdQty")]
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_T-6pNACrEeqouY-yI_q3qQ")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; }
}
